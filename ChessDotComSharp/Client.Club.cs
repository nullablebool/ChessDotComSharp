using ChessDotComSharp.Models;
using ChessDotComSharp.Resources;
using System.Threading.Tasks;

namespace ChessDotComSharp
{
    public partial class ChessDotComClient
    {
        /// <summary>
        /// Get additional details about a club
        /// </summary>
        /// <param name="club">The club id/slug. The slug is the same as found in the URL for the club's web page on www.chess.com</param>
        /// <returns></returns>
        public async Task<Club> GetClubProfileAsync(string club)
        {
            return await GetAsync<Club>(Endpoints.Club.GetClubProfile(club)).ConfigureAwait(false);
        }

        /// <summary>
        /// Get additional details about a club
        /// </summary>
        /// <param name="club">The club id/slug. The slug is the same as found in the URL for the club's web page on www.chess.com</param>
        /// <returns></returns>
        public async Task<ClubMembers> GetClubMembersAsync(string club)
        {
            return await GetAsync<ClubMembers>(Endpoints.Club.GetClubMembers(club)).ConfigureAwait(false);
        }

        /// <summary>
        /// List of club matches, grouped by status (registered, in progress, finished). 
        /// </summary>
        /// <param name="club">The club id/slug. The slug is the same as found in the URL for the club's web page on www.chess.com</param>
        /// <returns></returns>
        public async Task<ClubMatches> GetClubMatchesAsync(string club)
        {
            return await GetAsync<ClubMatches>(Endpoints.Club.GetClubMatches(club)).ConfigureAwait(false);
        }
    }
}
