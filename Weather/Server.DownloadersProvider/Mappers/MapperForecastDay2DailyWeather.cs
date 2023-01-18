using Server.DownloadersProvider.Models;
using Server.DatabaseProvider.Models;

namespace Server.DownloadersProvider.Mappers
{
    internal class MapperForecastDay2DailyWeather : BaseMapper
    {
        public List<DailyWeather> Map(ForecastDay forecastDay)
        {
            if (forecastDay.data is null)
                throw new Exception("Нет данных для сопоставления");

            var dailyWeathers = new List<DailyWeather>();
            foreach (var forecast in forecastDay.data)
            {
                var dailyWeather = CreateDailyWeather(forecast);
                dailyWeathers.Add(dailyWeather);
            }

            return dailyWeathers;
        }

        private DailyWeather CreateDailyWeather(Forecast forecast)
        {
            var dailyWeather = new DailyWeather
            {
                DailyWeatherId = Guid.NewGuid(),
                Date = forecast.datetime is not null ? DateTime.Parse(forecast.datetime).ToUniversalTime().Date : null,
                SnowDepth = forecast.snow_depth,
                AverageTemperature = forecast.temp,
                AverageDewPoint = forecast.dewpt,
                MaxTemperature = forecast.max_temp,
                MinTemperature = forecast.min_temp,
                MaxApparenTemperaturet = forecast.app_max_temp,
                MinApparenTemperaturet = forecast.app_min_temp,
                WindDirection = forecast.wind_dir,
                CardinalWindDirection = forecast.wind_cdir,
                WindSpeed = forecast.wind_spd,
                Pressure = forecast.pres,
                RelativeHumidity = forecast.rh,
                Precipitation = forecast.precip,
                Snowfall = forecast.snow,
                CloudCover = forecast.clouds,
                IsForecast = true
            };

            if (forecast.weather is not null)
            {
                var inlineModel = forecast.weather;
                dailyWeather.WeatherIcon = CreateWeatherIcon(inlineModel);
            }

            return dailyWeather;
        }
    }
}
