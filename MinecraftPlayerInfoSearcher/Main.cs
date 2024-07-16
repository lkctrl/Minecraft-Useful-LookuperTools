using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinecraftUsefulApiTools
{
    internal static class Lookuper
    {
        public const string ProfileApiLink = "https://api.mojang.com/users/profiles/minecraft/";
        public const string SessionApiLink = "https://sessionserver.mojang.com/session/minecraft/profile/";
        public const string ServerStatusApiLink = "https://api.mcsrvstat.us/";//java+3/<address> ,Bedrock+bedrock/3/<address>
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LookuperUI());
        }
        internal static async Task<string> GetWebData(string BaseLink, string Link)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(BaseLink);
                    HttpResponseMessage response = await client.GetAsync(Link);
                    if (response.IsSuccessStatusCode)
                    {
                        return await response.Content.ReadAsStringAsync();
                    }
                    else
                    {
                        MessageBox.Show($"Search failed! Code:{response.StatusCode}");
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"[WEB Error]:An error has occurred:\n{ex.Message}.\nErrorInfo:\n{ex.StackTrace}\nPossible resolution:\nCheck your network and connection to Api.\nTry to find out the reason yourself\nOr contact the author");
                return "ERROR";
            }
        }
        internal static void OpenBrowserUrl(string url)
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
    }
}
