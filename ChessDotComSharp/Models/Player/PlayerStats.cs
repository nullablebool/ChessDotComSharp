using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using J = Newtonsoft.Json.JsonPropertyAttribute;
using System.Globalization;

namespace ChessDotComSharp.Models
{
    public partial class PlayerStats
    {
        [J("chess_daily")] public ChessDaily ChessDaily { get; set; }
        [J("chess960_daily")] public ChessDaily Chess960Daily { get; set; }
        [J("chess_rapid")] public Chess ChessRapid { get; set; }
        [J("chess_bullet")] public Chess ChessBullet { get; set; }
        [J("chess_blitz")] public Chess ChessBlitz { get; set; }
    }

    public partial class ChessDaily
    {
        [J("last")] public RecordLast Last { get; set; }
        [J("best")] public RecordBest Best { get; set; }
        [J("record")] public Chess960DailyRecord Record { get; set; }
        [J("tournament")] public TournamentRecord Tournament { get; set; }
    }

    public partial class RecordBest
    {
        [J("rating")] public int Rating { get; set; }
        [J("date")] public DateTime Date { get; set; }
        [J("game")] public string Game { get; set; }
    }

    public partial class RecordLast
    {
        [J("rating")] public int Rating { get; set; }
        public DateTime Date { get; set; }
        /// <summary>
        /// The Glicko "RD" value used to calculate ratings changes
        /// </summary>
        [J("rd")] public int GlickoRd { get; set; }
    }

    public partial class Chess960DailyRecord
    {
        [J("win")] public int Win { get; set; }
        [J("loss")] public int Loss { get; set; }
        [J("draw")] public int Draw { get; set; }
        /// <summary>
        /// The number of seconds per average move
        /// </summary>
        [J("time_per_move")] public int TimePerMove { get; set; }
        /// <summary>
        /// Timeout percentage in the last 90 days
        /// </summary>
        [J("timeout_percent")] public int TimeoutPercent { get; set; }
    }

    public partial class TournamentRecord
    {
        [J("points")] public int Points { get; set; }
        [J("withdraw")] public int Withdraw { get; set; }
        [J("count")] public int Count { get; set; }
        [J("highest_finish")] public int HighestFinish { get; set; }
    }

    public partial class Chess
    {
        [J("last")] public RecordLast Last { get; set; }
        [J("best")] public RecordBest Best { get; set; }
        [J("record")] public ChessRecord Record { get; set; }
    }

    public partial class ChessRecord
    {
        [J("win")] public int Win { get; set; }
        [J("loss")] public int Loss { get; set; }
        [J("draw")] public int Draw { get; set; }
    }

}
