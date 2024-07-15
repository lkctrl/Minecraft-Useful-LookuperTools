using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace PlayerInfoLookuper
{
    public partial class LookuperUI : Form
    {
        public const string Version = "v1.2Release";
        public string PlayerName;
        public Image PlayerSkin;
        public Image PlayerCape;
        public LookuperUI() => InitializeComponent();
        private void LookuperUI_Load(object sender, EventArgs e)
        {
            label_version.Text = Version;
        }

        private void linkLabel_op_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => OpenBrowserUrl("https://www.minecraft.net");
        private void button_Minecraft_Search_Click(object sender, EventArgs e)
        {
            button_Minecraft_SaveSkin.Enabled = false;
            button_Minecraft_SaveCape.Enabled = false;
            button_Search.Enabled = false;
            JsonParser();
        }
        private async void JsonParser()
        {

            ChangeConnectStatus(ConnectStatus.Searching);
            string UserProfileRawjson = await Lookuper.GetJsonData(Lookuper.ProfileApiLink, textBox_in_Name.Text);
            if (UserProfileRawjson == null | UserProfileRawjson == "ERROR")
            {
                button_Search.Enabled = true;
                ChangeConnectStatus(ConnectStatus.Error);
                return;
            }
            richTextBox_RawInfo.Text = UserProfileRawjson;

            UserProfile UserProfilejson = Parser.DeserializeProfileJson(UserProfileRawjson);
            PlayerName = UserProfilejson.name;
            label_Name.Text = UserProfilejson.name;
            label_UUID.Text = UserProfilejson.id;

            /*-----↑ProfileParse↑ ↓SessionParse↓-----*/

            string UserSessionRawjson = await Lookuper.GetJsonData(Lookuper.SessionApiLink, UserProfilejson.id);
            if (UserProfileRawjson == null | UserProfileRawjson == "ERROR")
            {
                button_Search.Enabled = true;
                ChangeConnectStatus(ConnectStatus.Error);
                return;
            }
            richTextBox_RawInfo.Text = UserSessionRawjson;

            UserSession UserSessionjson = Parser.DeserializeSessionJson(UserSessionRawjson);
            string UserSession_properties_valueRawjson = Parser.DecodeBase64(UserSessionjson.properties[0].value);
            UserSession_properties_value UserSession_properties_valuejson = Parser.DeserializeSession_valueJson(UserSession_properties_valueRawjson);

            PlayerSkin = Image.FromStream(WebRequest.Create(UserSession_properties_valuejson.textures.SKIN.url).GetResponse().GetResponseStream());
            pictureBox_PlayerSkin.Image = PlayerSkin;
            button_Minecraft_SaveSkin.Enabled = true;
            if (UserSession_properties_valuejson.textures.CAPE != null)
            {
                PlayerCape = Image.FromStream(WebRequest.Create(UserSession_properties_valuejson.textures.CAPE.url).GetResponse().GetResponseStream());
                pictureBox_PlayerCape.Image = PlayerCape;
                button_Minecraft_SaveCape.Enabled = true;
            }
            else
            {
                pictureBox_PlayerCape.Image = MinecraftPlayerInfoSearcher.Properties.Resources._NOCAPE2015;
            }
            ChangeConnectStatus(ConnectStatus.Waiting);
            button_Search.Enabled = true;
        }
        private void button_SaveSkin_Click(object sender, EventArgs e)
        {
            string SkinUrl = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + "\\Minecraft Skins\\";
            SaveImage(PlayerSkin, SkinUrl, PlayerName + ".png");
        }
        private void button_Minecraft_SaveCape_Click(object sender, EventArgs e)
        {
            string CapeUrl = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + "\\Minecraft Skins\\";
            SaveImage(PlayerCape, CapeUrl, PlayerName + "'s Cape.png");
        }
        private void SaveImage(Image Image, string FileUrl, string FileName)
        {
            if (!Directory.Exists(FileUrl))
            {
                Directory.CreateDirectory(FileUrl);
            }
            Image.Save(FileUrl + FileName);
            MessageBox.Show("Picture was saved in " + FileUrl + FileName);
        }
        private static void OpenBrowserUrl(string url)
        {
            try
            {
                Process.Start(url);
            }
            catch (Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2147467259)
                    MessageBox.Show(noBrowser.Message);
            }
            catch (Exception other)
            {
                MessageBox.Show(other.Message);
            }
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
    }
}

internal enum ConnectStatus
{
    Waiting = 1, Searching = 2,
    ConnectionError = 3,
    Error = 5,
}
