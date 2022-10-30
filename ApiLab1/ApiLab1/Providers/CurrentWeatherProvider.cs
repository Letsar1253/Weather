using ApiLab1.Downloaders;
using ApiLab1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiLab1.Contollers
{
    internal class CurrentWeatherProvider
    {
        private readonly CurrentWeatherDownloader _downloader = new();

        public async Task<List<CurrentWeather>> GetWeather(string city, string country)
        {
            var downloadedResult = await _downloader.Download(city, country);
           return downloadedResult;
        }
    }
}
