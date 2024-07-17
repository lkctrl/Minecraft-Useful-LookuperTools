using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace MinecraftUsefulApiTools
{
    internal class ServerStatusJsonParser
    {
        internal static ServerStatus DeserializeStatusJson(string rawjson) => JsonSerializer.Deserialize<ServerStatus>(rawjson);
        internal static Image IconParser(string rawstring)
        {
            StringBuilder builder = new StringBuilder(rawstring);
            builder.Remove(0, 22);//remove "data:image\/png;base64,"
            byte[] imgdata = Convert.FromBase64String(builder.ToString());
            MemoryStream stream = new MemoryStream(imgdata);
            return Image.FromStream(stream);
        }
    }
    public class ServerStatus
    {
        public bool online { get; set; }
        public string ip { get; set; }
        public ushort port { get; set; }
        public string hostname { get; set; }
        public ServerStatus_debug debug { get; set; }
        public string version { get; set; }
        public ServerStatus_protocol protocol { get; set; }
        public string icon { get; set; }
        public string software { get; set; }
        public ServerStatus_RCH map { get; set; }
        public string gamemode { get; set; }
        public string serverid { get; set; }
        public bool eula_blocked { get; set; }
        public ServerStatus_RCH motd { get; set; }
        public ServerStatus_players players { get; set; }
        public ServerStatus_plugins[] plugins { get; set; }
        public ServerStatus_plugins[] mods { get; set; }
        public ServerStatus_RCH info { get; set; }
    }
    public class ServerStatus_debug
    {
        public bool ping { get; set; }
        public bool query { get; set; }
        public bool srv { get; set; }
        public bool querymismatch { get; set; }
        public bool ipinsrv { get; set; }
        public bool cnameinsrv { get; set; }
        public bool animatedmotd { get; set; }
        public bool cachehit { get; set; }
        public int cachetime { get; set; }
        public int cacheexpire { get; set; }
        public int apiversion { get; set; }
        public ServerStatus_debug_error error { get; set; }
    }
    public class ServerStatus_debug_error
    {
        public string ping { get; set; }
        public string query { get; set; }
    }
    public class ServerStatus_protocol
    {
        public ushort version { get; set; }
        public string name { get; set; }
    }
    public class ServerStatus_RCH
    {
        public string[] raw { get; set; }
        public string[] clean { get; set; }
        public string[] html { get; set; }
    }
    public class ServerStatus_players
    {
        public int online { get; set; }
        public int max { get; set; }
        public ServerStatus_players_list[] list { get; set; }
    }
    public class ServerStatus_players_list
    {
        public string name { get; set; }
        public string uuid { get; set; }
    }
    public class ServerStatus_plugins
    {
        public string name { get; set; }
        public string version { get; set; }
    }
    /*Response when server is Online
            {
                "online": true,
                "ip": "127.0.0.1",
                "port": 25567,
                "hostname": "server.mymcserver.tld", //Only included when a hostname is detected
                "debug": { //See section below for information about the values
                    "ping": true,
                    "query": true,
                    "srv": true,
                    "querymismatch": false,
                    "ipinsrv": false,
                    "cnameinsrv": false,
                    "animatedmotd": false,
                    "cachehit": true,
                    "cachetime": 1518553220,
                    "cacheexpire": 1518553280,
                    "apiversion": 2
                },
                "version": "1.12", //Could include multiple versions or additional text
                "protocol": { //Only included when ping is used
                    "version": 340,
                    "name": "1.12.2" //Only included if a version name is found
                },
                "icon": "data:image\/png;base64,iVBORw0KGgoAAAANSUhEU...dSk6AAAAAElFTkSuQmCC", //Only included when an icon is detected
                "software": "BungeeCord", //Only included when software is detected
                "map": {
                    "raw": "MyMcWorld",
                    "clean": "MyMcWorld",
                    "html": "MyMcWorld"
                },
                "gamemode": "Survival", //Only included for Bedrock servers
                "serverid": "2438134582716697305", //Only included for Bedrock servers
                "eula_blocked": false, //Only included for Java servers
                "motd": {
                    "raw": [
                        "\u00a7cEver\u00a7r\u00a79PvP \u00a7r\u00a77- \u00a7r\u00a72\u00c9n server, for alle",
                        "\u00a7r\u00a7fSe dine stats p\u00e5 \u00a7r\u00a76stats.everpvp.dk\u00a7r"
                    ],
                    "clean": [
                        "EverPvP - \u00c9n server, for alle",
                        "Se dine stats p\u00e5 stats.everpvp.dk"
                    ],
                    "html": [
                        "<span style=\"color: #FF5555\">Ever<\/span><span style=\"color: #5555FF\">PvP <\/span><span style=\"color: #AAAAAA\">- <\/span><span style=\"color: #00AA00\">\u00c9n server, for alle<\/span>",
                        "<span style=\"color: #FFFFFF\">Se dine stats p\u00e5 <\/span><span style=\"color: #FFAA00\">stats.everpvp.dk<\/span>"
                    ]
                },
                "players": {
                    "online": 2,
                    "max": 100,
                    "list": [ //Only included when there are players
                        {
                            "name": "Spirit55555",
                            "uuid": "f6792ad3-cbb4-4596-8296-749ee4158f97"
                        },
                        {
                            "name": "sarsum33",
                            "uuid": "d3512599-d4d9-4520-808f-a81f4cdfe8d0"
                        }
                    ],
                },
                "plugins": [ //Only included when plugins are detected
                    {
                        "name": "WordEdit",
                        "version": "6.1.5"
                    },
                    {
                        "name": "WorldGuard",
                        "version": "6.2"
                    }
                ],
                "mods": [ //Only included when mods are detected
                    {
                        "name": "BiomesOPlenty",
                        "version": "2.1.0"
                    },
                    {
                        "name": "MoreFurnaces",
                        "version": "1.3.9"
                    }
                ],
                "info": { //Only included when detecting that the player samples are used for information
                    "raw": [
                        "\u00a77\u00bb \u00a7cKitPvP \u00a77:: \u00a7f1 \u00a77online",
                        "\u00a77\u00bb \u00a7bSurvivalGames \u00a77:: \u00a7f0 \u00a77online"
                    ],
                    "clean": [
                        "\u00bb KitPvP :: 1 online",
                        "\u00bb SurvivalGames :: 0 online"
                    ],
                    "html": [
                        "<span style=\"color: #AAAAAA\">\u00bb <\/span><span style=\"color: #FF5555\">KitPvP <\/span><span style=\"color: #AAAAAA\">:: <\/span><span style=\"color: #FFFFFF\">1 <\/span><span style=\"color: #AAAAAA\">online<\/span>",
                        "<span style=\"color: #AAAAAA\">\u00bb <\/span><span style=\"color: #55FFFF\">SurvivalGames <\/span><span style=\"color: #AAAAAA\">:: <\/span><span style=\"color: #FFFFFF\">0 <\/span><span style=\"color: #AAAAAA\">online<\/span>"
                    ]
                }
            }
    */
    /*Response when server is Offline
            {
                "online": false,
                "ip": "127.0.0.1", //Could be empty
                "port": 25567, //Could be empty
                "hostname": "not-working.mymcserver.tld", //Only included when a hostname is detected
                "debug": { //See section below for information about the values
                    "ping": false,
                    "query": false,
                    "srv": false,
                    "querymismatch": false,
                    "ipinsrv": false,
                    "cnameinsrv": false,
                    "animatedmotd": false,
                    "cachehit": false,
                    "cachetime": 1518553220,
                    "cacheexpire": 1518553280,
                    "apiversion": 2
                }
            }
    */
}