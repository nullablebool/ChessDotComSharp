using ChessDotComSharp.Models;

namespace ChessDotComSharp.Resources
{
    internal static class Endpoints
    {
        private static string apiBase = "https://api.chess.com/pub";
        public static class Player
        {
            public static string GetPlayerProfile(string username) => $"{apiBase}/player/{username}";
            public static string GetIsPlayerOnline(string username) => $"{apiBase}/player/{username}/is-online";
            public static string GetPlayerStats(string username) => $"{apiBase}/player/{username}/stats";
            public static string GetPlayerGames(string username) => $"{apiBase}/player/{username}/games";
            public static string GetPlayerGamestoMove(string username) => $"{apiBase}/player/{username}/games/to-move";
            public static string GetPlayerGameArchives(string username) => $"{apiBase}/player/{username}/games/archives";
            public static string GetPlayerGameMonthlyArchive(string username, int year, int month) => $"{apiBase}/player/{username}/games/{year}/{month:00}";
            public static string GetPlayerGameArchivePGN(string username, int year, int month) => $"{apiBase}/player/{username}/games/{year}/{month:00}/pgn";
            public static string GetPlayerClubs(string username) => $"{apiBase}/player/{username}/clubs";
            public static string GetPlayerMatches(string username) => $"{apiBase}/player/{username}/matches";
            public static string GetPlayerTournaments(string username) => $"{apiBase}/player/{username}/tournaments";
            public static string GetTitledPlayers(PlayerTitle title) => $"{apiBase}/titled/{title.ToString()}";
        }

        public static class Club
        {
            //Note: Cache invalidation: These endpoints refresh at most once every 12 hours

            public static string GetClubProfile(string clubName) => $"{apiBase}/club/{clubName}";
            public static string GetClubMembers(string clubName) => $"{apiBase}/club/{clubName}/members";
            public static string GetClubMatches(string clubName) => $"{apiBase}/club/{clubName}/matches";
        }

        public static class Tournament
        {
            public static string GetTournamentInformation(string urlId) => $"{apiBase}/tournament/{urlId}";
            public static string GetTournamentRoundInformation(string urlId, int round) => $"{apiBase}/tournament/{urlId}/{round}";
            public static string GetTournamentRoundGroupInformation(string urlId, int round, int group) => $"{apiBase}/tournament/{urlId}/{round}/{group} ";
        }

        public static class TeamMatch
        {
            public static string GetTeamMatchInformation(int match) => $"{apiBase}/match/{match}";
            public static string GetTeamMatchBoardInformation(int match, int board) => $"{apiBase}/match/{match}/{board}";
        }

        public static class Country
        {
            public static string GetCountry(string country) => $"{apiBase}/country/{country}";
            public static string GetCountryPlayers(string country) => $"{apiBase}/country/{country}/players";
            public static string GetCountryClubs(string country) => $"{apiBase}/country/{country}/clubs";
        }
        public static class Puzzle
        {
            public static string GetDailyPuzzle => "{apiBase}/puzzle";
            public static string GetRandomPuzzle => "{apiBase}/puzzle/puzzle";
        }
    }
}
