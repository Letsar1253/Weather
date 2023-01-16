using Downloaders.Downloaders;
using Downloaders.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Downloaders.Contollers
{
    public class CurrentWeatherProvider
    {
        private readonly CurrentWeatherDownloader _downloader = new();

        public async Task<List<CurrentWeather>> GetWeather(string city, string country)
        {
            var downloadedResult = await _downloader.Download(city, country);
           return downloadedResult;
        }
    }
}
