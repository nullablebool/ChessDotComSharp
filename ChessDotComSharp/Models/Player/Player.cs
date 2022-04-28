using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using J = Newtonsoft.Json.JsonPropertyAttribute;
using System.Globalization;

namespace ChessDotComSharp.Models
{

    public partial class PlayerProfile
    {
        [J("avatar")] public string Avatar { get; set; }
        [J("player_id")] public int PlayerId { get; set; }
        [J("@id")] public string Id { get; set; }
        [J("name")] public string Name { get; set; }
        [J("username")] public string Username { get; set; }
        [J("url")] public string Url { get; set; }
        [J("followers")] public int Followers { get; set; }
        [J("country")] public string Country { get; set; }
        [J("location")] public string Location { get; set; }
        [JsonConverter(typeof(UnixDateTimeConverter))] [J("last_online")] public DateTime LastOnline { get; set; }
        [JsonConverter(typeof(UnixDateTimeConverter))] [J("joined")] public DateTime Joined { get; set; }
        [J("status")] public string Status { get; set; }
    }

    public class PlayerOnlineStatus
    {
        public bool Online { get; set; }
    }

    public partial class PlayerUsernameList
    {
        [J("players")] public List<string> Players { get; set; }
    }

}
