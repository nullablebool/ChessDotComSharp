using System;
using System.Collections.Generic;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace ChessDotComSharp.Models
{
    public class ClubMembers
    {
        [J("weekly")] public List<ClubMember> Weekly { get; set; }
        [J("monthly")] public List<ClubMember> Monthly { get; set; }
        [J("all_time")] public List<ClubMember> AllTime { get; set; }
    }

    public class ClubMember
    {
        [J("username")] public string Username { get; set; }
        [J("joined")] public DateTime Joined { get; set; }
    }
}
