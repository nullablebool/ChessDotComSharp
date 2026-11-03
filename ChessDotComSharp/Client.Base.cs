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
        /// <summary>
        /// Fallback User-Agent used when the caller does not supply one. Chess.com requires a
        /// recognisable User-Agent containing contact information, so callers should pass their own.
        /// </summary>
        public const string DefaultUserAgent = "ChessDotComSharp/1.0 (+https://github.com/Hyper-Dragon/ChessDotComSharp)";

        private static HttpClient _client;

        public ChessDotComClient(string userAgent = DefaultUserAgent)
        {
            _client = new HttpClient();
            _client.DefaultRequestHeaders.Add("User-Agent", string.IsNullOrWhiteSpace(userAgent) ? DefaultUserAgent : userAgent);
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
