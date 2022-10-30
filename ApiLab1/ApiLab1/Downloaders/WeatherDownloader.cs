using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ApiLab1.Downloaders
{
    internal class WeatherDownloader
    {
        private static readonly HttpClient _client = new ();
        private static readonly string _baseQuery = "https://api.weatherbit.io/v2.0/";
        private static readonly string _languageArgument = "lang=ru";
        private static readonly string _keyArgument = "key=7b0b3f4bca4d4e49a8af69366ed9dacb";

        public static async Task<object> Download<T>(string pathApi, List<string> argumentsForQuery)
        {
            var uriQuery = PrepareUriQuery(pathApi, argumentsForQuery);
            var responseBody = await _client.GetStringAsync(uriQuery);
            var result = JsonConvert.DeserializeObject<T>(responseBody);

            if (result is null)
                throw new Exception("Не удалось скачать запрашиваемые данные");

            return result;
        }

        private static string PrepareUriQuery(string pathApi, List<string> argumentsForQuery)
        {
            var uriQuery = _baseQuery + pathApi + "?";
            foreach (var argument in argumentsForQuery)
                uriQuery += argument + "&";

            uriQuery += _languageArgument + "&" + _keyArgument;

            return uriQuery;
        }
    }
}
