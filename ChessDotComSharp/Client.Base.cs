﻿using ChessDotComSharp.Models;
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

        public ChessDotComClient()
        {
            _client = new HttpClient();
            _client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_7) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/116.0.0.0 Safari/537.36");
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
