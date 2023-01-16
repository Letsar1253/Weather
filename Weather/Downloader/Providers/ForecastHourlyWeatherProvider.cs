using Downloaders.Downloaders;
using Downloaders.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Downloaders.Providers
{
    public class ForecastHourlyWeatherProvider
    {
        private readonly ForecastHourlyWeatherDownloader _downloader = new();

        public async Task<List<HourlyWeather>> GetWeather(string city, string country)
        {
            var downloadedResult = await _downloader.Download(city, country);
            return downloadedResult;
        }
    }
}
