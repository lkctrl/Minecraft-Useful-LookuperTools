using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace MinecraftUsefulApiTools
{
    public partial class LookuperUI : Form
    {
        public const string Version = "v2.0.4R";
        public string PlayerName;
        public Image PlayerSkin;
        public Image PlayerCape;
        public Image ServerIcon;
        public LookuperUI() => InitializeComponent();
        private void LookuperUI_Load(object sender, EventArgs e) => label_version.Text = Version;
        private void button_PlayerInfoSearch_Click(object sender, EventArgs e)
        {
            button_PlayerInfo_SaveSkin.Enabled = false;
            button_PlayerInfo_SaveCape.Enabled = false;
            button_PlayerInfo_Search.Enabled = false;
            PlayerInfoJsonParserAsync();
        }
        private void button_ServerStatus_Ping_Click(object sender, EventArgs e)
        {
            button_ServerStatus_Ping.Enabled = false;
            if (comboBox_ServerStatus_PingType.SelectedIndex == 1)
            {
                ServerStatusJsonParserAsync(textBox_ServerStatus_in_IP.Text, textBox_ServerStatus_in_Port.Text, "bedrock/3/");//type=1:java type=2:bedrock
                return;
            }
            ServerStatusJsonParserAsync(textBox_ServerStatus_in_IP.Text, textBox_ServerStatus_in_Port.Text, "3/");//default
            return;
        }
        #region Some SHIT Codes
        private async void PlayerInfoJsonParserAsync()
        {
            #region ProfileParse
            string UserProfileRawjson;
            ChangeConnectStatus(ConnectStatusEnum.Searching);
            try
            {
                UserProfileRawjson = await Lookuper.GetWebData(Lookuper.ProfileApiLink, textBox_PlayerInfo_in_Name.Text);
            }
            catch
            {
                button_PlayerInfo_Search.Enabled = true;
                ChangeConnectStatus(ConnectStatusEnum.Error);
                return;
            }
            if (UserProfileRawjson == null)
            {
                button_PlayerInfo_Search.Enabled = true;
                ChangeConnectStatus(ConnectStatusEnum.Error);
                return;
            }
            richTextBox_PlayerInfo_RawInfo.Text = UserProfileRawjson;

            UserProfile UserProfilejson = PlayerInfoJsonParser.DeserializeProfileJson(UserProfileRawjson);
            PlayerName = UserProfilejson.name;
            label_PlayerInfo_Name.Text = UserProfilejson.name;
            label_PlayerInfo_UUID.Text = UserProfilejson.id;
            #endregion
            #region SessionParse
            string UserSessionRawjson = await Lookuper.GetWebData(Lookuper.SessionApiLink, UserProfilejson.id);
            if (UserProfileRawjson == null)
            {
                button_PlayerInfo_Search.Enabled = true;
                ChangeConnectStatus(ConnectStatusEnum.Error);
                return;
            }
            richTextBox_PlayerInfo_RawInfo.Text = UserSessionRawjson;

            UserSession UserSessionjson = PlayerInfoJsonParser.DeserializeSessionJson(UserSessionRawjson);
            string UserSession_properties_valueRawjson = PlayerInfoJsonParser.DecodeBase64(UserSessionjson.properties[0].value);
            UserSession_properties_value UserSession_properties_valuejson = PlayerInfoJsonParser.DeserializeSession_valueJson(UserSession_properties_valueRawjson);

            PlayerSkin = Image.FromStream(WebRequest.Create(UserSession_properties_valuejson.textures.SKIN.url).GetResponse().GetResponseStream());
            pictureBox_PlayerInfo_PlayerSkin.Image = PlayerSkin;
            button_PlayerInfo_SaveSkin.Enabled = true;
            if (UserSession_properties_valuejson.textures.CAPE != null)
            {
                PlayerCape = Image.FromStream(WebRequest.Create(UserSession_properties_valuejson.textures.CAPE.url).GetResponse().GetResponseStream());
                pictureBox_PlayerInfo_PlayerCape.Image = PlayerCape;
                button_PlayerInfo_SaveCape.Enabled = true;
            }
            else
            {
                pictureBox_PlayerInfo_PlayerCape.Image = MinecraftPlayerInfoSearcher.Properties.Resources._NOCAPE2015;
            }
            ChangeConnectStatus(ConnectStatusEnum.Waiting);
            button_PlayerInfo_Search.Enabled = true;
            #endregion
        }
        private async void ServerStatusJsonParserAsync(string ServerIP, string port, string AddtionUrl)
        {
            ChangeConnectStatus(ConnectStatusEnum.Searching);
            ChangeServerStatus(ServerStatusEnum.Pinging);
            string AddtionPort = null;
            if (port != "") AddtionPort = ":" + port;
            string StatusRawjson;
            try
            {
                StatusRawjson = await Lookuper.GetWebData(Lookuper.ServerStatusApiLink + AddtionUrl, ServerIP + AddtionPort);
            }
            catch (Exception ex)
            {
                ChangeConnectStatus(ConnectStatusEnum.Error);
                button_ServerStatus_Ping.Enabled = true;
                richTextBox_ServerStatus.Text = ex.Message;
                //throw new Exception(ex.Message);
                return;
            }
            richTextBox_ServerStatus.Text = StatusRawjson;
            ServerStatus ServerStatus = ServerStatusJsonParser.DeserializeStatusJson(StatusRawjson);
            if (ServerStatus.online == true)
            {
                ChangeServerStatus(ServerStatusEnum.Online);
                label_ServerStatus_ServerAddress.Text = ServerStatus.hostname;
                toolTip.SetToolTip(label_ServerStatus_ServerAddress, ServerStatus.ip + ":" + ServerStatus.port);
                label_ServerStatus_PlayerNumber.Text = ServerStatus.players.online.ToString() + " / " + ServerStatus.players.max.ToString();
                string motd1 = null, motd2 = null;
                if (ServerStatus.motd.html[0] != null) motd1 = ServerStatus.motd.html[0];
                if (ServerStatus.motd.html[1] != null) motd2 = ServerStatus.motd.html[1];
                webBrowser_ServerStatus_ServerMotd.DocumentText = "<div>" + motd1 + motd2 + "</div>" + "<style>div{style:\"font-family:Microsoft Yahei;font-size: 10px;\"}</style>";
                //Actually these CSS doesn't work really. But its really a long time from i last write html5.
                //TODO: make these html work again.
                label_ServerStatus_ServerCore.Text = ServerStatus.software;
                label_ServerStatus_ServerVersion.Text = ServerStatus.version;
                if (ServerStatus.icon != null)
                {
                    ServerIcon = ServerStatusJsonParser.IconParser(ServerStatus.icon);
                    pictureBox_ServerStatus_ServerIcon.Image = ServerIcon;
                }
                button_ServerStatus_Ping.Enabled = true;
                button_ServerStatus_SaveServerIcon.Enabled = true;
            }
            else
            {
                if (ServerStatus.debug.error.ping != "")
                {
                    ChangeServerStatus(ServerStatusEnum.Error);
                    MessageBox.Show(ServerStatus.debug.error.ping);
                    button_ServerStatus_Ping.Enabled = true;
                    return;
                }
                ChangeServerStatus(ServerStatusEnum.Offline);
                button_ServerStatus_Ping.Enabled = true;
                return;
            }
        }
        #endregion SHIT
        private void button_SaveSkin_Click(object sender, EventArgs e)
        {
            string SkinUrl = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + "\\Minecraft Useful Tools\\";
            SaveImage(PlayerSkin, SkinUrl, PlayerName + ".png", "Skin was saved in:");
        }
        private void button_Minecraft_SaveCape_Click(object sender, EventArgs e)
        {
            string CapeUrl = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + "\\Minecraft Useful Tools\\";
            SaveImage(PlayerCape, CapeUrl, PlayerName + "'s Cape.png", "Cape was saved in:");
        }
        private void button_ServerStatus_SaveServerIcon_Click(object sender, EventArgs e)
        {
            string IconUrl = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + "\\Minecraft Useful Tools\\Server Icons\\";
            SaveImage(ServerIcon, IconUrl, label_ServerStatus_ServerAddress.Text + ".png", "Icon was saved in:");
        }
        private void SaveImage(Image Image, string FileUrl, string FileName, string Message)
        {
            if (!Directory.Exists(FileUrl))
            {
                Directory.CreateDirectory(FileUrl);
            }
            Image.Save(FileUrl + FileName);
            MessageBox.Show(Message + FileUrl + FileName);
        }
        internal void ChangeConnectStatus(ConnectStatusEnum status)
        {
            int IntStatus = (int)status;
            switch (IntStatus)
            {
                case 1:
                    label_status.ForeColor = Color.Green;
                    label_status.Text = "Waiting";
                    return;
                case 2:
                    label_status.ForeColor = Color.Blue;
                    label_status.Text = "Searching";
                    return;
                case 3:
                    label_status.ForeColor = Color.Yellow;
                    label_status.Text = "ConnectionError";
                    return;
                case 5:
                    label_status.ForeColor = Color.Red;
                    label_status.Text = "Error";
                    return;
                default:
                    label_status.ForeColor = Color.Green;
                    label_status.Text = "Waiting";
                    return;
            }
        }
        internal void ChangeServerStatus(ServerStatusEnum status)
        {
            int IntStatus = (int)status;
            switch (IntStatus)
            {
                case 1:
                    label_ServerStatus_IsServerOnline.ForeColor = Color.Green;
                    label_ServerStatus_IsServerOnline.Text = "Online";
                    return;
                case 2:
                    label_ServerStatus_IsServerOnline.ForeColor = Color.Gray;
                    label_ServerStatus_IsServerOnline.Text = "Offline";
                    return;
                case 3:
                    label_ServerStatus_IsServerOnline.ForeColor = Color.Red;
                    label_ServerStatus_IsServerOnline.Text = "Error";
                    return;
                case 4:
                    label_ServerStatus_IsServerOnline.ForeColor = SystemColors.ControlText;
                    label_ServerStatus_IsServerOnline.Text = "Waiting";
                    return;
                case 5:
                    label_ServerStatus_IsServerOnline.ForeColor = Color.Orange;
                    label_ServerStatus_IsServerOnline.Text = "Pinging";
                    return;
                default:
                    label_ServerStatus_IsServerOnline.ForeColor = SystemColors.ControlText;
                    label_ServerStatus_IsServerOnline.Text = "Waiting";
                    return;
            }
        }
        private void linkLabel_Mojang_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Lookuper.OpenBrowserUrl("https://www.minecraft.net");
        private void linkLabel_Github_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Lookuper.OpenBrowserUrl("https://github.com/lkctrl/Minecraft-UsefulTools/");
    }
}
internal enum ConnectStatusEnum
{
    Waiting = 1,
    Searching = 2,
    ConnectionError = 3,
    Error = 5,
}
internal enum ServerStatusEnum
{
    Online = 1,
    Offline = 2,
    Error = 3,
    Waiting = 4,
    Pinging = 5,
}
