using ChessDotComSharp.Models;
using ChessDotComSharp.Resources;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ChessDotComSharp
{
    public partial class ChessDotComClient
    {
        /// <summary>
        /// Get the daily puzzle of chess.com
        /// </summary>
        /// <remarks>if you are going to publish the Daily Puzzle somewhere please remember to give credits to Chess.com by means of a clearly visibile text link that points to the url of the puzzle page.</remarks>
        /// <returns></returns>
        public async Task<Puzzle> GetPuzzleAsync()
        {
            return await GetAsync<Puzzle>(Endpoints.Puzzle.GetDailyPuzzle).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a random puzzle from chess.com
        /// </summary>
        /// <remarks>if you are going to publish the Daily Puzzle somewhere please remember to give credits to Chess.com by means of a clearly visibile text link that points to the url of the puzzle page.</remarks>
        /// <returns></returns>
        public async Task<Puzzle> GetRandormPuzzleAsync()
        {
            return await GetAsync<Puzzle>(Endpoints.Puzzle.GetRandomPuzzle).ConfigureAwait(false);
        }
    }
}
