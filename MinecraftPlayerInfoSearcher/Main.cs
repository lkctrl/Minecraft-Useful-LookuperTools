using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerInfoLookuper
{
    internal static class Lookuper
    {
        public const string ProfileApiLink = "https://api.mojang.com/users/profiles/minecraft/";
        public const string SessionApiLink = "https://sessionserver.mojang.com/session/minecraft/profile/";
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
        internal static async Task<string> GetJsonData(string BaseLink,string Link)
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
                MessageBox.Show($"[WEB Error]:An error has occurred:{ex.Message}.\nCheck your network and connection to Mojang.\nTry to find out the reason yourself\nOr contact the author");
                return "ERROR";
            }
        }
    }
}
