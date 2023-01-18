using Common.Data.Models;
using Server.DownloadersProvider.Downloaders.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.DownloadersProvider
{
    internal class DownloadProvider : IDownloadProvider
    {
        private readonly ICurrentWeatherDownloader _currentWeatherDownloader;
        private readonly IForecastDailyWeatherDownloader _forecastDailyWeatherDownloader;
        private readonly IForecastHourlyWeatherDownloader _forecastHourlyWeatherDownloade;

        private readonly string _city;
        private readonly string _county;

        internal DownloadProvider(ICurrentWeatherDownloader currentWeatherDownloader, IForecastDailyWeatherDownloader forecastDailyWeatherDownloader, IForecastHourlyWeatherDownloader forecastHourlyWeatherDownloade, string city, string county)
        {
            _currentWeatherDownloader = currentWeatherDownloader;
            _forecastDailyWeatherDownloader = forecastDailyWeatherDownloader;
            _forecastHourlyWeatherDownloade = forecastHourlyWeatherDownloade;

            _city = city;
            _county = county;
        }

        public async Task<List<CurrentWeather>> GetCurrentWeathers()
        {
            var currentWeathers = await _currentWeatherDownloader.Download(_city, _county);
            return currentWeathers;
        }

        public async Task<List<DailyWeather>> GetForecastDailyWeathers()
        {
            var forecastDailyWeathers = await _forecastDailyWeatherDownloader.Download(_city, _county);
            return forecastDailyWeathers;
        }

        public async Task<List<HourlyWeather>> GetForecastHourlyWeathers()
        {
            var forecastHourlyWeathers = await _forecastHourlyWeatherDownloade.Download(_city, _county);
            return forecastHourlyWeathers;
        }
    }
}
