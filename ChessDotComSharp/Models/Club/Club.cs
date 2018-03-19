using System;
using System.Collections.Generic;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace ChessDotComSharp.Models
{
    public partial class Club
    {
        [J("@id")] public string Id { get; set; }
        [J("name")] public string Name { get; set; }
        [J("club_id")] public int ClubId { get; set; }
        [J("country")] public string Country { get; set; }
        [J("created")] public DateTime Created { get; set; }
        [J("last_activity")] public DateTime LastActivity { get; set; }
        [J("admin")] public List<string> Admin { get; set; }
        [J("visibility")] public Visibility Visibility { get; set; }
        [J("join_request")] public string JoinRequest { get; set; }
        [J("icon")] public string Icon { get; set; }
        [J("description")] public string Description { get; set; }
        [J("url")] public string Url { get; set; }
    }

}
