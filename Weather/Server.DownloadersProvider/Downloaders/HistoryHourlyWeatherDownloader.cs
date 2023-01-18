using Server.DatabaseProvider.Models;
using Server.DownloadersProvider.Downloaders.Interfaces;
using Server.DownloadersProvider.Mappers;
using Server.DownloadersProvider.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.DownloadersProvider.Downloaders
{
    internal class HistoryHourlyWeatherDownloader: IHistoryHourlyWeatherDownloader
    {
        private readonly string _pathApi = "history/hourly";

        public async Task<List<HourlyWeather>> Download(string city, string county)
        {
            var argumentsForQuery = new List<string>
            {
                "city=" + city,
                "country=" + county
            };
            var downloadedResult = await WeatherDownloader.Download<HistoryHourly>(_pathApi, argumentsForQuery);
            var hoyrlyWeathers = HandleDownloadedResult(downloadedResult);

            return hoyrlyWeathers;
        }

        private List<HourlyWeather> HandleDownloadedResult(object? downloadedResult)
        {
            if (downloadedResult is not HistoryHourly historyHourly)
                throw new Exception("Закаченные данные не соответствуют необходимому типу");

            var mapper = new MapperHistoryHourly2HourlyWeather();
            var hourlyWeathers = mapper.Map(historyHourly);
            if (hourlyWeathers.Count == 0)
                throw new Exception("Не удалось закачать данные о прошлой погоде");

            return hourlyWeathers;
        }
    }
}
