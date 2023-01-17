using Server.DownloadersProvider.Models;
using Server.DownloadersProvider.Mappers;
using Common.Data.Models;

namespace Server.DownloadersProvider.Downloaders
{
    public class ForecastHourlyWeatherDownloader
    {
        private readonly string _pathApi = "forecast/hourly";

        public async Task<List<HourlyWeather>> Download(string city, string county)
        {
            var argumentsForQuery = new List<string>
            {
                "city=" + city,
                "country=" + county
            };
            var downloadedResult = await WeatherDownloader.Download<ForecastHourly>(_pathApi, argumentsForQuery);
            var hoyrlyWeathers = HandleDownloadedResult(downloadedResult);

            return hoyrlyWeathers;
        }

        private List<HourlyWeather> HandleDownloadedResult(object? downloadedResult)
        {
            if (downloadedResult is not ForecastHourly forecastHourly)
                throw new Exception("Закаченные данные не соответствуют необходимому типу");

            var mapper = new MapperForecastHourly2HourlyWeather();
            var hourlyWeathers = mapper.Map(forecastHourly);
            if (hourlyWeathers.Count == 0)
                throw new Exception("Не удалось закачать данные о текущей погоде");

            return hourlyWeathers;
        }
    }
}
