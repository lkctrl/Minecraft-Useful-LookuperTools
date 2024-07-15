using System;
using System.Text.Json;

namespace PlayerInfoLookuper
{
    internal class PlayerInfoJsonParser
    {
        internal static UserProfile DeserializeProfileJson(string rawjson) => JsonSerializer.Deserialize<UserProfile>(rawjson);
        internal static UserSession DeserializeSessionJson(string rawjson) => JsonSerializer.Deserialize<UserSession>(rawjson);
        internal static UserSession_properties_value DeserializeSession_valueJson(string rawjson) => JsonSerializer.Deserialize<UserSession_properties_value>(rawjson);
    }
    public class UserProfile
    {
        public string id { get; set; }
        public string name { get; set; }
    }
    public class UserSession
    {
        public string id { get; set; }
        public string name { get; set; }
        public UserSession_properties[] properties { get; set; }
        public string[] profileActions { get; set; }
    }
    public class UserSession_properties
    {
        public string name { get; set; }
        public string value { get; set; }
    }
    public class UserSession_properties_value
    {
        public long timestamp { get; set; }
        public string profileId { get; set; }
        public string profileName { get; set; }
        public UserSession_properties_value_textures textures { get; set; }
    }
    public class UserSession_properties_value_textures
    {
        public UserSession_properties_value_textures_xxx_url SKIN { get; set; }
        public UserSession_properties_value_textures_xxx_url CAPE { get; set; }
    }
    public class UserSession_properties_value_textures_xxx_url
    {
        public string url { get; set; }
    }
    /*
     Profilejson like this:
{
    "id": "e3ed0693263749c6b8f237334fc35800",
    "name": "TypeNameHere"
}
    */

    /*
    Sessionjson like this:
{
    "id": "e3ed0693263749c6b8f237334fc35800",
    "name": "TypeNameHere",
    "properties": [
        {
            "name": "textures",
            "value": "ewogICJ0aW1lc3RhbXAiIDogMTcyMDc2NTk2MTU0MSwKICAicHJvZmlsZUlkIiA6ICJlM2VkMDY5MzI2Mzc0OWM2YjhmMjM3MzM0ZmMzNTgwMCIsCiAgInByb2ZpbGVOYW1lIiA6ICJUeXBlTmFtZUhlcmUiLAogICJ0ZXh0dXJlcyIgOiB7CiAgICAiU0tJTiIgOiB7CiAgICAgICJ1cmwiIDogImh0dHA6Ly90ZXh0dXJlcy5taW5lY3JhZnQubmV0L3RleHR1cmUvZTIzNTY2ODA4OGYwODkzZWJkMzlkZDU0OWM4NjJiYjg0OTk0ZDY5NzRiYzUxOWM3M2Q0NjMyMzBhMDIyMjExYiIKICAgIH0KICB9Cn0="
        }
    ],
    "profileActions": []
}

    properties-valuejson like this(after decoded):
{
  "timestamp" : 1720765961541,
  "profileId" : "e3ed0693263749c6b8f237334fc35800",
  "profileName" : "TypeNameHere",
  "textures" : {
    "SKIN" : {
      "url" : "http://textures.minecraft.net/texture/e235668088f0893ebd39dd549c862bb84994d6974bc519c73d463230a022211b"
    }
  }
}
     */
}
