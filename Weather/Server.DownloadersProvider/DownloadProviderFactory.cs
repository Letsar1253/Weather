using Server.DownloadersProvider.Downloaders;
using Server.DownloadersProvider.Downloaders.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.DownloadersProvider
{
    public class DownloadProviderFactory : IDownloadProviderFactory
    {
        private readonly ICurrentWeatherDownloader _currentWeatherDownloader = new CurrentWeatherDownloader();
        private readonly IForecastDailyWeatherDownloader _forecastDailyWeatherDownloader = new ForecastDailyWeatherDownloader();
        private readonly IForecastHourlyWeatherDownloader _forecastHourlyWeatherDownloader = new ForecastHourlyWeatherDownloader();
        private readonly IHistoryDailyWeatherDownloader _historyDailyWeatherDownloader = new HistoryDailyWeatherDownloader();
        private readonly IHistoryHourlyWeatherDownloader _historyHourlyWeatherDownloader = new HistoryHourlyWeatherDownloader();

        public IDownloadProvider CreateDownloadProvider(string city, string county)
        {
            var downloadProvider = new DownloadProvider(_currentWeatherDownloader, _forecastDailyWeatherDownloader, _forecastHourlyWeatherDownloader, _historyDailyWeatherDownloader, _historyHourlyWeatherDownloader,city, county);
            return downloadProvider;
        }
    }
}
