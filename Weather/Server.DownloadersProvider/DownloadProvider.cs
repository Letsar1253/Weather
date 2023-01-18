using Common.Data.Models;
using Server.DownloadersProvider.Downloaders;
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
        private readonly IHistoryDailyWeatherDownloader _historyDailyWeatherDownloader;
        private readonly IHistoryHourlyWeatherDownloader _historyHourlyWeatherDownloader;

        private readonly string _city;
        private readonly string _county;

        internal DownloadProvider(ICurrentWeatherDownloader currentWeatherDownloader, IForecastDailyWeatherDownloader forecastDailyWeatherDownloader, IForecastHourlyWeatherDownloader forecastHourlyWeatherDownloade, IHistoryDailyWeatherDownloader historyDailyWeatherDownloader, IHistoryHourlyWeatherDownloader historyHourlyWeatherDownloader, string city, string county)
        {
            _currentWeatherDownloader = currentWeatherDownloader;
            _forecastDailyWeatherDownloader = forecastDailyWeatherDownloader;
            _forecastHourlyWeatherDownloade = forecastHourlyWeatherDownloade;
            _historyDailyWeatherDownloader = historyDailyWeatherDownloader;
            _historyHourlyWeatherDownloader = historyHourlyWeatherDownloader;

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
        public async Task<List<DailyWeather>> GetHistoryDailyWeathers()
        {
            var historyDailyWeathers = await _historyDailyWeatherDownloader.Download(_city, _county);
            return historyDailyWeathers;
        }

        public async Task<List<HourlyWeather>> GetHistoryHourlyWeathers()
        {
            var historyHourlyWeathers = await _historyHourlyWeatherDownloader.Download(_city, _county);
            return historyHourlyWeathers;
        }
    }
}
