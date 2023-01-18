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
    internal class HistoryDailyWeatherDownloader: IHistoryDailyWeatherDownloader
    {
        private readonly string _pathApi = "history/daily";

        public async Task<List<DailyWeather>> Download(string city, string county)
        {
            var argumentsForQuery = new List<string>
            {
                "city=" + city,
                "country=" + county
            };
            var downloadedResult = await WeatherDownloader.Download<HistoryDaily>(_pathApi, argumentsForQuery);
            var dailyWeathers = HandleDownloadedResult(downloadedResult);

            return dailyWeathers;
        }

        private List<DailyWeather> HandleDownloadedResult(object? downloadedResult)
        {
            if (downloadedResult is not HistoryDaily historyDaily)
                throw new Exception("Закаченные данные не соответствуют необходимому типу");

            var mapper = new MapperHistoryDaily2DailyWeather();
            var dailyWeathers = mapper.Map(historyDaily);
            if (dailyWeathers.Count == 0)
                throw new Exception("Не удалось закачать данные о прошлой погоде");

            return dailyWeathers;
        }
    }
}
