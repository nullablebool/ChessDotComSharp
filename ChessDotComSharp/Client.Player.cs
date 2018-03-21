using ChessDotComSharp.Models;

using ChessDotComSharp.Resources;
using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace ChessDotComSharp
{
    public partial class ChessDotComClient
    {
        /// <summary>
        /// Get additional details about a player
        /// </summary>
        /// <param name="username">The player's username</param>
        /// <returns></returns>
        public async Task<PlayerProfile> GetPlayerProfileAsync(string username)
        {
            return await GetAsync<PlayerProfile>(Endpoints.Player.GetPlayerProfile(username)).ConfigureAwait(false);
        }

        /// <summary>
        /// Tells if an unser has been online in the last five minutes
        /// </summary>
        /// <param name="username">The player's username</param>
        /// <returns></returns>
        public async Task<bool> GetIsPlayerOnlineAsync(string username)
        {
            var online = await GetAsync<PlayerOnlineStatus>(Endpoints.Player.GetIsPlayerOnline(username)).ConfigureAwait(false);
            return online.Online;
        }

        /// <summary>
        /// List of titled-player usernames
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        public async Task<PlayerUsernameList> GetTitledPlayersAsync(PlayerTitle title)
        {
            return await GetAsync<PlayerUsernameList>(Endpoints.Player.GetTitledPlayers(title)).ConfigureAwait(false);
        }

        /// <summary>
        /// Get ratings, win/loss, and other stats about a player's game play.
        /// </summary>
        /// <param name="username">The player's username</param>
        /// <returns></returns>
        public async Task<PlayerStats> GetPlayerStatsAsync(string username)
        {
            return await GetAsync<PlayerStats>(Endpoints.Player.GetPlayerStats(username)).ConfigureAwait(false);
        }

        #region Games

        /// <summary>
        /// Array of Daily Chess games that a player is currently playing.
        /// </summary>
        /// <param name="username">The player's username</param>
        /// <returns></returns>
        public async Task<PlayerGames> GetPlayerGamesAsync(string username)
        {
            return await GetAsync<PlayerGames>(Endpoints.Player.GetPlayerGames(username)).ConfigureAwait(false);
        }

        /// <summary>
        /// Array of Daily Chess games where it is the player's turn to act
        /// </summary>
        /// <param name="username">The player's username</param>
        /// <returns></returns>
        public async Task<PlayerToMoveGames> GetPlayerGamestoMoveAsync(string username)
        {
            return await GetAsync<PlayerToMoveGames>(Endpoints.Player.GetPlayerGamestoMove(username)).ConfigureAwait(false);
        }

        /// <summary>
        /// Tells if an unser has been online in the last five minutes
        /// </summary>
        /// <param name="username">The player's username</param>
        /// <returns></returns>
        public async Task<ArchivedGamesList> GetPlayerGameArchivesAsync(string username)
        {
            return await GetAsync<ArchivedGamesList>(Endpoints.Player.GetPlayerGameArchives(username)).ConfigureAwait(false);
        }

        /// <summary>
        /// Array of Live and Daily Chess games that a player has finished
        /// </summary>
        /// <param name="username">The player's username</param>
        /// <param name="year">The year, e.g. 2018</param>
        /// <param name="month">The month, e.g 1</param>
        /// <returns></returns>
        public async Task<PlayerArchivedGames> GetPlayerGameMonthlyArchiveAsync(string username, int year, int month)
        {
            return await GetAsync<PlayerArchivedGames>(Endpoints.Player.GetPlayerGameMonthlyArchive(username, year, month)).ConfigureAwait(false);
        }

        /// <summary>
        /// Standard multi-game format PGN containing all games for a month
        /// </summary>
        /// <param name="username">The player's username</param>
        /// <param name="year">The year, e.g. 2018</param>
        /// <param name="month">The month, e.g 1</param>
        /// <returns></returns>
        public async Task<Stream> DownloadPlayerGameArchiveAsStreamAsync(string username, int year, int month)
        {
            return await _client.GetStreamAsync(Endpoints.Player.GetPlayerGameArchivePGN(username, year, month)).ConfigureAwait(false);
        }

        /// <summary>
        /// Standard multi-game format PGN containing all games for a month
        /// </summary>
        /// <param name="username">The player's username</param>
        /// <param name="year">The year, e.g. 2018</param>
        /// <param name="month">The month, e.g 1</param>
        /// <param name="filename">The filename to save to. Defaults to username_YYYY_MM.pgn</param>
        /// <param name="overwrite">Whethere to overwrite an exisiting file.</param>
        /// <exception cref="InvalidOperationException">Thrown when <paramref name="overwrite"/> is set to false and the <paramref name="filename"/> exists, override behaviour by setting <paramref name="throwIfExists"/> to false.</exception>
        /// <returns></returns>
        public async Task DownloadPlayerGameArchiveToFileAsync(string username, int year, int month, string filename = null, bool overwrite = false, bool throwIfExists = true)
        {
            var path = Path.GetFullPath(filename ?? $"{username}_{year}_{month}.pgn");

            if (!overwrite && File.Exists(path))
                if (throwIfExists) throw new InvalidOperationException($"File {path} already exists.");
                else return;

            using (var stream = await DownloadPlayerGameArchiveAsStreamAsync(username, year, month))
            using (var fs = new FileStream(path, FileMode.Create))
            {
                if (stream.Length > 0)
                    await stream.CopyToAsync(fs);
            }
        }

        #endregion

        /// <summary>
        /// List of clubs the player is a member of, with joined date and last activity date 
        /// </summary>
        /// <param name="username">The player's username</param>
        /// <returns></returns>
        public async Task<PlayerClubs> GetPlayerClubsAsync(string username)
        {
            return await GetAsync<PlayerClubs>(Endpoints.Player.GetPlayerClubs(username)).ConfigureAwait(false);
        }

        /// <summary>
        /// List of Team matches the player has attended, is participating or is currently registered
        /// </summary>
        /// <param name="username">The player's username</param>
        /// <returns></returns>
        public async Task<PlayerMatches> GetPlayerTeamMatchesAsync(string username)
        {
            return await GetAsync<PlayerMatches>(Endpoints.Player.GetPlayerMatches(username)).ConfigureAwait(false);
        }

        /// <summary>
        /// List of tournaments the player is registered, is attending or has attended in the past. 
        /// </summary>
        /// <param name="username">The player's username</param>
        /// <returns></returns>
        public async Task<PlayerMatches> GetPlayerTournamentsAsync(string username)
        {
            return await GetAsync<PlayerMatches>(Endpoints.Player.GetPlayerTournaments(username)).ConfigureAwait(false);
        }
    }
}
