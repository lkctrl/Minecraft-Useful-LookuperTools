using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace PlayerInfoLookuper
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
            PlayerInfoJsonParser();
        }
        private void button_ServerStatus_Ping_Click(object sender, EventArgs e)
        {
            button_ServerStatus_Ping.Enabled = false;
            ServerStatusJsonParser();
        }
        private async void PlayerInfoJsonParser()
        {

            ChangeConnectStatus(ConnectStatus.Searching);
            string UserProfileRawjson = await Lookuper.GetJsonData(Lookuper.ProfileApiLink, textBox_PlayerInfo_in_Name.Text);
            if (UserProfileRawjson == null | UserProfileRawjson == "ERROR")
            {
                button_PlayerInfo_Search.Enabled = true;
                ChangeConnectStatus(ConnectStatus.Error);
                return;
            }
            richTextBox_PlayerInfo_RawInfo.Text = UserProfileRawjson;

            UserProfile UserProfilejson = PlayerInfoLookuper.PlayerInfoJsonParser.DeserializeProfileJson(UserProfileRawjson);
            PlayerName = UserProfilejson.name;
            label_PlayerInfo_Name.Text = UserProfilejson.name;
            label_PlayerInfo_UUID.Text = UserProfilejson.id;

            /*-----↑ProfileParse↑ ↓SessionParse↓-----*/

            string UserSessionRawjson = await Lookuper.GetJsonData(Lookuper.SessionApiLink, UserProfilejson.id);
            if (UserProfileRawjson == null | UserProfileRawjson == "ERROR")
            {
                button_PlayerInfo_Search.Enabled = true;
                ChangeConnectStatus(ConnectStatus.Error);
                return;
            }
            richTextBox_PlayerInfo_RawInfo.Text = UserSessionRawjson;

            UserSession UserSessionjson = PlayerInfoLookuper.PlayerInfoJsonParser.DeserializeSessionJson(UserSessionRawjson);
            string UserSession_properties_valueRawjson = PlayerInfoLookuper.PlayerInfoJsonParser.DecodeBase64(UserSessionjson.properties[0].value);
            UserSession_properties_value UserSession_properties_valuejson = PlayerInfoLookuper.PlayerInfoJsonParser.DeserializeSession_valueJson(UserSession_properties_valueRawjson);

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
            ChangeConnectStatus(ConnectStatus.Waiting);
            button_PlayerInfo_Search.Enabled = true;
        }
        private async void ServerStatusJsonParser()
        {
            string AddtionIP = "/3/";
            if (comboBox_ServerStatus_PingType.SelectedIndex == 1) AddtionIP = "/bedrock/3/";
            ChangeConnectStatus(ConnectStatus.Searching);
            string StatusRawjson = await Lookuper.GetJsonData(Lookuper.ServerStatusApiLink + AddtionIP, textBox_ServerStatus_in_IP.Text + ":" + textBox_ServerStatus_in_Port.Text);
            ChangeConnectStatus(ConnectStatus.Waiting);
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

        internal void ChangeConnectStatus(ConnectStatus status)
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
        private void linkLabel_Mojang_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Lookuper.OpenBrowserUrl("https://www.minecraft.net");
        private void linkLabel_Github_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Lookuper.OpenBrowserUrl("https://github.com/lkctrl/Minecraft-UsefulTools/");
    }
}

internal enum ConnectStatus
{
    Waiting = 1, Searching = 2,
    ConnectionError = 3,
    Error = 5,
}
