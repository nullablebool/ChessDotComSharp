using ChessDotComSharp.Models;
using ChessDotComSharp.Resources;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace ChessDotComSharp
{
    public partial class ChessDotComClient : IDisposable
    {
        private static HttpClient _client;

        /// <summary>
        /// Creates a client.
        /// </summary>
        /// <param name="userAgent">
        /// User-Agent sent with every request. This is required: Chess.com's Public API requires
        /// callers to identify themselves with a User-Agent that contains developer contact
        /// information, and may block applications that do not.
        /// </param>
        /// <exception cref="ArgumentException">
        /// Thrown when <paramref name="userAgent"/> is null, empty or whitespace.
        /// </exception>
        public ChessDotComClient(string userAgent)
        {
            if (string.IsNullOrWhiteSpace(userAgent))
            {
                throw new ArgumentException(
                    "A User-Agent is required. Chess.com's Public API requires a User-Agent that identifies your application and contains contact information; requests from clients without one may be blocked.",
                    nameof(userAgent));
            }

            _client = new HttpClient();
            _client.DefaultRequestHeaders.Add("User-Agent", userAgent);
        }

        private async Task<T> GetAsync<T>(string uri)
        {
            var response = await _client.GetAsync(uri).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            return JsonConvert.DeserializeObject<T>(content, Converter.Settings);
        }

        public void Dispose()
        {
            _client?.Dispose();
        }
    }
}
