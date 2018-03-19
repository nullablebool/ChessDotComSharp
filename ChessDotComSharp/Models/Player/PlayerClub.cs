using System;
using System.Collections.Generic;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace ChessDotComSharp.Models
{
    public class PlayerClubs
    {
        [J("clubs")] public List<PlayerClubDetails> Clubs { get; set; }
    }

    public class PlayerClubDetails
    {
        [J("url")] public string Url { get; set; }
        [J("joined")] public DateTime Joined { get; set; }
        [J("last_activity")] public DateTime LastActivity { get; set; }
    }
}
