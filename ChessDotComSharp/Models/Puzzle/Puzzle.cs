using System;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace ChessDotComSharp.Models
{
    public partial class Puzzle
    {
        [J("title")] public string Title { get; set; }
        [J("url")] public string Url { get; set; }
        [J("publish_time")] public DateTime PublishTime { get; set; }
        [J("fen")] public string Fen { get; set; }
        [J("pgn")] public string Pgn { get; set; }
        [J("image")] public string Image { get; set; }
    }
}
