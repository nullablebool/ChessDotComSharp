using System;
using System.Collections.Generic;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace ChessDotComSharp.Models
{
    public partial class TournamentRoundGroup
    {
        [J("games")] public List<ArchiveGame> Games { get; set; }
        [J("players")] public List<TournamentRoundGroupPlayer> Players { get; set; }
    }
    

    public partial class TournamentRoundGroupPlayer : TournamentRoundPlayer
    {
        [J("points")] public double Points { get; set; }
        [J("tie_break")] public double TieBreak { get; set; }
    }
}
