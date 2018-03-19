using System;
using System.Collections.Generic;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace ChessDotComSharp.Models
{
    public class Tournament
    {
        [J("name")] public string Name { get; set; }
        [J("url")] public string Url { get; set; }
        [J("description")] public string Description { get; set; }
        [J("creator")] public string Creator { get; set; }
        [J("status")] public TournamentState Status { get; set; }
        [J("finish_time")] public DateTime FinishTime { get; set; }
        [J("settings")] public TournamentSettings Settings { get; set; }
        [J("players")] public List<TournamentPlayer> Players { get; set; }
        [J("rounds")] public List<string> Rounds { get; set; }
    }

    public class TournamentPlayer
    {
        [J("username")] public string Username { get; set; }
        [J("status")] public PlayerTournamentStatus Status { get; set; }
    }

    public class TournamentSettings
    {
        [J("type")] public string Type { get; set; } //TODO: Enum
        [J("rules")] public GameVariant Rules { get; set; }
        [J("time_class")] public TimeClass TimeClass { get; set; }
        [J("time_control")] public string TimeControl { get; set; }
        [J("is_rated")] public bool IsRated { get; set; }
        [J("is_official")] public bool IsOfficial { get; set; }
        [J("is_invite_only")] public bool IsInviteOnly { get; set; }
        [J("min_rating")] public int MinRating { get; set; }
        [J("max_rating")] public int MaxRating { get; set; }
        [J("initial_group_size")] public int InitialGroupSize { get; set; }
        [J("user_advance_count")] public int UserAdvanceCount { get; set; }
        [J("use_tiebreak")] public bool IsTiebreakPossible { get; set; }
        [J("allow_vacation")] public bool IsVacationAllowed { get; set; }
        [J("winner_places")] public int WinnerPlaces { get; set; }
        [J("registered_user_count")] public int RegisteredUserCount { get; set; }
        [J("games_per_opponent")] public int GamesPerOpponent { get; set; }
        [J("total_rounds")] public int TotalRounds { get; set; }
        [J("concurrent_games_per_opponent")] public int ConcurrentGamesPerOpponent { get; set; }
    }

}
