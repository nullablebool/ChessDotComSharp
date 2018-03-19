using System;
using System.Collections.Generic;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace ChessDotComSharp.Models
{
    public class ClubMatches
    {
        [J("finished")] public List<ClubMatch> Finished { get; set; }
        [J("in_progress")] public List<ClubMatch> InProgress { get; set; }
        [J("registered")] public List<ClubMatch> Registered { get; set; }
    }

    public class ClubMatch
    {
        [J("name")] public string Name { get; set; }
        [J("@id")] public string Id { get; set; }
        [J("opponent")] public string Opponent { get; set; }
        [J("result")] public ClubMatchResult Result { get; set; }
    }
}
