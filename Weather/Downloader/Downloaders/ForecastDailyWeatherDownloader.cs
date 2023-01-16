using Downloaders.Downloaders.DownloadModels;
using Downloaders.Downloaders.Mappers;
using Downloaders.Models;

namespace Downloaders.Downloaders
{
    public class ForecastDailyWeatherDownloader
    {
        private readonly string _pathApi = "forecast/daily";

        public async Task<List<DailyWeather>> Download(string city, string county)
        {
            var argumentsForQuery = new List<string>
            {
                "city=" + city,
                "country=" + county
            };
            var downloadedResult = await WeatherDownloader.Download<ForecastDay>(_pathApi, argumentsForQuery);
            var dailyWeathers = HandleDownloadedResult(downloadedResult);

            return dailyWeathers;
        }

        private List<DailyWeather> HandleDownloadedResult(object? downloadedResult)
        {
            if (downloadedResult is not ForecastDay forecastDay)
                throw new Exception("Закаченные данные не соответствуют необходимому типу");

            var mapper = new MapperForecastDay2DailyWeather();
            var dailyWeathers = mapper.Map(forecastDay);
            if (dailyWeathers.Count == 0)
                throw new Exception("Не удалось закачать данные о текущей погоде");

            return dailyWeathers;
        }
    }
}
