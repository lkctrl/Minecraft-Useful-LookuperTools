using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace MinecraftUsefulApiTools
{
    public partial class LookuperUI : Form
    {
        public const string Version = "x2.0base";
        public string PlayerName;
        public Image PlayerSkin;
        public Image PlayerCape;
        public LookuperUI() => InitializeComponent();
        private void LookuperUI_Load(object sender, EventArgs e)
        {
            label_version.Text = Version;
        }
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
            ServerStatusJsonParserAsync();
        }
        private async void PlayerInfoJsonParserAsync()
        {
            ChangeConnectStatus(ConnectStatusEnum.Searching);
            string UserProfileRawjson = await Lookuper.GetWebData(Lookuper.ProfileApiLink, textBox_PlayerInfo_in_Name.Text);
            if (UserProfileRawjson == null | UserProfileRawjson == "ERROR")
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

            /*-----↑ProfileParse↑ ↓SessionParse↓-----*/

            string UserSessionRawjson = await Lookuper.GetWebData(Lookuper.SessionApiLink, UserProfilejson.id);
            if (UserProfileRawjson == null | UserProfileRawjson == "ERROR")
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
        }
        private async void ServerStatusJsonParserAsync()
        {
            ChangeConnectStatus(ConnectStatusEnum.Searching);
            string AddtionIP = "3/";
            //if (comboBox_ServerStatus_PingType.SelectedIndex == 0) AddtionIP = "/3/"; //default
            if (comboBox_ServerStatus_PingType.SelectedIndex == 1) AddtionIP = "bedrock/3/";
            string PortText = null;
            if (textBox_ServerStatus_in_Port.Text != "") PortText = ":" + textBox_ServerStatus_in_Port.Text;
            string StatusRawjson = await Lookuper.GetWebData(Lookuper.ServerStatusApiLink + AddtionIP, textBox_ServerStatus_in_IP.Text + PortText);
            richTextBox_ServerStatus.Text = StatusRawjson;

            ServerStatus ServerStatus = ServerStatusJsonParser.DeserializeStatusJson(StatusRawjson);
            if (ServerStatus.online == true)
            {
                ChangeServerStatus(ServerStatusEnum.Online);
                label_ServerAddress.Text = ServerStatus.hostname;
                toolTip.SetToolTip(label_ServerAddress, ServerStatus.ip);
                pictureBox_ServerIcon.Image = ServerStatusJsonParser.IconParser(ServerStatus.icon);
            }

            ChangeConnectStatus(ConnectStatusEnum.Waiting);
            button_ServerStatus_Ping.Enabled = true;
        }
        private void button_SaveSkin_Click(object sender, EventArgs e)
        {
            string SkinUrl = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + "\\Minecraft Skins\\";
            SaveImage(PlayerSkin, SkinUrl, PlayerName + ".png", "Skin was saved in:");
        }
        private void button_Minecraft_SaveCape_Click(object sender, EventArgs e)
        {
            string CapeUrl = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + "\\Minecraft Skins\\";
            SaveImage(PlayerCape, CapeUrl, PlayerName + "'s Cape.png", "Cape was saved in:");
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
                    label_status.ForeColor = Color.Green;
                    label_status.Text = "Online";
                    return;
                case 2:
                    label_status.ForeColor = Color.Gray;
                    label_status.Text = "Offline";
                    return;
                case 3:
                    label_status.ForeColor = Color.Red;
                    label_status.Text = "Error";
                    return;
                case 4:
                    label_status.ForeColor = SystemColors.ControlText;
                    label_status.Text = "Waiting";
                    return;
                case 5:
                    label_status.ForeColor = Color.Orange;
                    label_status.Text = "Searching";
                    return;
                default:
                    label_status.ForeColor = SystemColors.ControlText;
                    label_status.Text = "Waiting";
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
    Searching = 5,
}
