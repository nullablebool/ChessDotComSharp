using ChessDotComSharp.Models;
using ChessDotComSharp.Resources;
using System.Threading.Tasks;

namespace ChessDotComSharp
{
    public partial class ChessDotComClient
    {
        /// <summary>
        /// Get additional details about a country
        /// </summary>
        /// <param name="countryCode">All country-based URLs use the country's 2-character ISO 3166 code to specify which 
        /// country you want data for. 
        /// Chess.com supports players and clubs identifying with some regions that are not recognized countries in this ISO list. 
        /// These countries are identified with codes within the "user-assigned code" ranges. When possible, we tried to use codes 
        /// that are commonly used in other applications. This is a list of these codes at Chess.com 
        /// <see cref="https://www.chess.com/news/view/published-data-api#pubapi-endpoint-country"/></param>
        public async Task<Country> GetCountryAsync(string countryCode)
        {
            return await GetAsync<Country>(Endpoints.Country.GetCountry(countryCode.ToUpper())).ConfigureAwait(false);
        }

        /// <summary>
        /// List of URLs for clubs identified as being in or associated with this country
        /// </summary>
        /// <param name="countryCode">All country-based URLs use the country's 2-character ISO 3166 code to specify which 
        /// country you want data for. 
        /// Chess.com supports players and clubs identifying with some regions that are not recognized countries in this ISO list. 
        /// These countries are identified with codes within the "user-assigned code" ranges. When possible, we tried to use codes
        /// that are commonly used in other applications. This is a list of these codes at Chess.com 
        /// <see cref="https://www.chess.com/news/view/published-data-api#pubapi-endpoint-country"/></param>
        public async Task<CountryClubs> GetCountryClubsAsync(string countryCode)
        {
            return await GetAsync<CountryClubs>(Endpoints.Country.GetCountryClubs(countryCode.ToUpper())).ConfigureAwait(false);
        }

        /// <summary>
        /// Get additional details about a country
        /// </summary>
        /// <param name="countryCode">All country-based URLs use the country's 2-character ISO 3166 code to specify which 
        /// country you want data for. 
        /// Chess.com supports players and clubs identifying with some regions that are not recognized countries in this ISO list. 
        /// These countries are identified with codes within the "user-assigned code" ranges. When possible, we tried to use codes 
        /// that are commonly used in other applications. This is a list of these codes at Chess.com 
        /// <see cref="https://www.chess.com/news/view/published-data-api#pubapi-endpoint-country"/></param>
        /// <remarks>
        /// Note: complete lists of all players are not available to download. By requesting this list once per day, you will obtain 
        /// a list of all new registrants and all people who are currently active on Chess.com and identify themselves as being in 
        /// (or associated with) this country. People who switch their country designation will be included in the next generation of
        /// the list.
        /// </remarks>
        public async Task<CountryPlayers> GetCountryPlayersAsync(string countryCode)
        {
            return await GetAsync<CountryPlayers>(Endpoints.Country.GetCountryPlayers(countryCode.ToUpper())).ConfigureAwait(false);
        }


    }
}
