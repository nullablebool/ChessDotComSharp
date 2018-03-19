
using System;
using System.Collections.Generic;
using System.Text;

namespace ChessDotComSharp.Models
{
    using J = Newtonsoft.Json.JsonPropertyAttribute;

    public partial class PlayerTournaments
    {
        [J("finished")] public List<PlayerTournamentCompleted> Finished { get; set; }
        [J("in_progress")] public List<PlayerTournamentInProgress> InProgress { get; set; }
        [J("registered")] public List<PlayerTournament> Registered { get; set; }
    }

    public class PlayerTournament
    {
        [J("url")] public string Url { get; set; }
        [J("@id")] public string Id { get; set; }
        [J("status")] public TournamentState Status { get; set; }
        [J("total_players")] public int TotalPlayers { get; set; }
    }

    public class PlayerTournamentInProgress : PlayerTournament
    {
        [J("wins")] public int Wins { get; set; }
        [J("losses")] public int Losses { get; set; }
        [J("draws")] public int Draws { get; set; }
    }

    public class PlayerTournamentCompleted : PlayerTournamentInProgress
    {
        [J("points_awarded")] public int? PointsAwarded { get; set; }
        [J("placement")] public int? Placement { get; set; }
    }

}
