using System;
using System.Collections.Generic;
using System.Text;
using J = Newtonsoft.Json.JsonPropertyAttribute;


namespace ChessDotComSharp.Models
{
    public partial class TeamMatch
    {
        [J("@id")] public string Id { get; set; }
        [J("name")] public string Name { get; set; }
        [J("url")] public string Url { get; set; }
        [J("start_time")] public DateTime StartTime { get; set; }
        [J("end_time")] public DateTime EndTime { get; set; }
        [J("status")] public TeamMatchStatus Status { get; set; }
        [J("boards")] public int Boards { get; set; }
        [J("settings")] public TeamMatchSettings Settings { get; set; }
        [J("teams")] public Teams Teams { get; set; }
    }

    public class TeamMatchSettings
    {
        [J("rules")] public GameVariant Rules { get; set; }
        [J("time_class")] public TimeClass TimeClass { get; set; }
        [J("time_control")] public string TimeControl { get; set; }
        [J("min_team_players")] public int MinTeamPlayers { get; set; }
        [J("min_required_games")] public int MinRequiredGames { get; set; }
        [J("autostart")] public bool IsAutoStart { get; set; }
    }

    public class Teams
    {
        [J("team1")] public Team Team1 { get; set; }
        [J("team2")] public Team Team2 { get; set; }
    }

    public class Team
    {
        [J("@id")] public string Id { get; set; }
        [J("name")] public string Name { get; set; }
        [J("url")] public string Url { get; set; }
        [J("score")] public double Score { get; set; }
        [J("result")] public string Result { get; set; }
        [J("players")] public List<TeamPlayer> Players { get; set; }
    }

    public partial class TeamPlayer
    {
        [J("username")] public string Username { get; set; }
        [J("stats")] public string Stats { get; set; }
        [J("played_as_black")] public MatchResult PlayedAsBlack { get; set; }
        [J("played_as_white")] public MatchResult PlayedAsWhite { get; set; }
        [J("board")] public string Board { get; set; }
    }


}
