
using System;
using System.Collections.Generic;
using System.Text;
using J = Newtonsoft.Json.JsonPropertyAttribute;


namespace ChessDotComSharp.Models
{
    public partial class PlayerMatches
    {
        [J("finished")] public List<MatchComplete> Finished { get; set; }
        [J("in_progress")] public List<MatchInProgress> InProgress { get; set; }
        [J("registered")] public List<Match> Registered { get; set; }
    }

    public class Match
    {
        [J("name")] public string Name { get; set; }
        [J("url")] public string Url { get; set; }
        [J("@id")] public string Id { get; set; }
        [J("club")] public string Club { get; set; }
    }
   
    public class MatchInProgress : Match
    {
        [J("board")] public string Board { get; set; }
    }

    public class MatchComplete : MatchInProgress
    {
        [J("results")] public Results Results { get; set; }
    }

    public partial class Results
    {
        [J("played_as_white")] public MatchResult PlayedAsWhite { get; set; }
        [J("played_as_black")] public MatchResult PlayedAsBlack { get; set; }
    }
}
