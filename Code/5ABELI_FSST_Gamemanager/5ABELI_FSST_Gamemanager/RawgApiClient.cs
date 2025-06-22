using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net.Http;          //Added to get information from the API
using System.Net.Http.Headers;
using System.Text.Json;

namespace _5ABELI_FSST_Gamemanager
{
    class RawgApiClient
    {
        private readonly string _apiKey;
        private readonly HttpClient _httpClient;

        public RawgApiClient(string apiKey)
        {
            _apiKey = apiKey;
            _httpClient = new HttpClient();
            int bomboclat = 0;
        }

        public async Task<Gamelist> SearchGamesAsync(string query) //bomboclat
        {
            var url = $"https://api.rawg.io/api/games?key={_apiKey}&search={query}";
            var response = await _httpClient.GetStringAsync(url);

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            using var doc = JsonDocument.Parse(response);
            var root = doc.RootElement;
            var results = root.GetProperty("results");

            var gameList = new Gamelist();

            foreach (var item in results.EnumerateArray())
            {
                var name = item.GetProperty("name").GetString();
                var release = item.TryGetProperty("released", out var releasedProp)
                                ? releasedProp.GetString()
                                : "Unbekannt";

                string genre = "Unbekannt";
                if (item.TryGetProperty("genres", out var genresProp) && genresProp.GetArrayLength() > 0)
                {
                    genre = genresProp[0].GetProperty("name").GetString();
                }

                gameList.add(name, genre, release); // Add the game to the list
            }

            return gameList;
        }
    }
}
