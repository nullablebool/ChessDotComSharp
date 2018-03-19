using ChessDotComSharp.Models;
using ChessDotComSharp.Resources;
using System.Threading.Tasks;

namespace ChessDotComSharp
{
    public partial class ChessDotComClient
    {
        /// <summary>
        /// Get details about a team match and players playing that match. After the match is finished there will be a link to 
        /// players' stats endpoint, in order to get up-to-date information about the player. 
        /// </summary>
        /// <param name="match">The id of the match</param>
        /// <returns></returns>
        public async Task<TeamMatch> GetTeamMatchAsync(int match)
        {
            return await GetAsync<TeamMatch>(Endpoints.TeamMatch.GetTeamMatchInformation(match)).ConfigureAwait(false);
        }

        /// <summary>
        /// Get details about a team match board. Only in-progress or finished games will be included, so there may be one or 
        /// two games in this list. 
        /// </summary>
        /// <param name="match">The id of the match</param>
        /// <param name="board">The board id</param>
        /// <returns></returns>
        public async Task<TeamMatchBoard> GetTeamMatchBoardAsync(int match, int board)
        {
            return await GetAsync<TeamMatchBoard>(Endpoints.TeamMatch.GetTeamMatchBoardInformation(match, board)).ConfigureAwait(false);
        }

    }
}
