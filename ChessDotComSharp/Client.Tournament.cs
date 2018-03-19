using ChessDotComSharp.Models;
using ChessDotComSharp.Resources;
using System.Threading.Tasks;

namespace ChessDotComSharp
{
    public partial class ChessDotComClient
    {
        /// <summary>
        /// Get details about a tournament
        /// </summary>
        /// <param name="club">The tournament id/slug. The slug is the same as found in the URL for the tournament's web page on www.chess.com</param>
        /// <returns></returns>
        public async Task<Tournament> GetTournamentAsync(string tournament)
        {
            return await GetAsync<Tournament>(Endpoints.Tournament.GetTournamentInformation(tournament)).ConfigureAwait(false);
        }

        /// <summary>
        /// Get details about a tournament's round. 
        /// </summary>
        /// <param name="club">The tournament id/slug. The slug is the same as found in the URL for the tournament's web page on www.chess.com</param>
        /// <param name="round">The tournament's round to get information</param>
        /// <returns></returns>
        public async Task<TournamentRound> GetTournamentRoundAsync(string tournament, int round)
        {
            return await GetAsync<TournamentRound>(Endpoints.Tournament.GetTournamentRoundInformation(tournament, round)).ConfigureAwait(false);
        }


        /// <summary>
        /// Get details about a tournament's round group
        /// </summary>
        /// <param name="club">The tournament id/slug. The slug is the same as found in the URL for the tournament's web page on www.chess.com</param>
        /// <param name="round">The tournament's round to get information</param>
        /// <param name="group">The group to get information for</param>
        /// <returns></returns>
        public async Task<TournamentRoundGroup> GetTournamentGroupRoundAsync(string tournament, int round, int group)
        {
            return await GetAsync<TournamentRoundGroup>(Endpoints.Tournament.GetTournamentRoundGroupInformation(tournament, round, group)).ConfigureAwait(false);
        }
    }
}
