using System;
using System.Collections.Generic;
using System.Text;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace ChessDotComSharp.Models
{
    public class GameBase
    {
        [J("url")] public string Url { get; set; }
        [J("pgn")] public string Pgn { get; set; }
        /// <summary>
        /// Specific time control used in the game, in the PGN standard notation <seealso cref="http://www.saremba.de/chessgml/standards/pgn/pgn-complete.htm#c9.6"/> 
        /// </summary>
        [J("time_control")] public string TimeControl { get; set; }
        [J("rated")] public bool IsRated { get; set; }
        [J("fen")] public string Fen { get; set; }
        [J("start_time")] public DateTime? StartTime { get; set; }
        [J("time_class")] public TimeClass TimeClass { get; set; }
        [J("rules")] public GameVariant Rules { get; set; }
        [J("tournament")] public string Tournament { get; set; }
        /// <summary>
        /// URL pointing to team match (if available)  
        /// </summary>
        [J("match")] public string Match { get; set; }

    }
    public partial class ArchiveGame : GameBase
    {
        [J("end_time")] public int EndTime { get; set; }
        [J("white")] public PlayerInformation White { get; set; }
        [J("black")] public PlayerInformation Black { get; set; }
        /// <summary>
        /// URL pointing to ECO opening (if available)
        /// </summary>
        [J("eco")] public string Eco { get; set; }
    }

    public partial class GameList
    {
        [J("games")] public IReadOnlyList<ArchiveGame> Games { get; set; }
    }
 }
