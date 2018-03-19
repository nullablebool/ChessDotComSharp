using System;
using System.Collections.Generic;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace ChessDotComSharp.Models
{
    public  class TournamentRound
    {
        [J("groups")] public List<string> Groups { get; set; }
        [J("players")] public List<TournamentRoundPlayer> Players { get; set; }
    }

    public class TournamentRoundPlayer
    {
        [J("username")] public string Username { get; set; }
        /// <summary>
        /// {true, false}, only if this tournament is completed 
        /// </summary>
        [J("is_advancing")] public bool IsAdvancing { get; set; }
    }

}
