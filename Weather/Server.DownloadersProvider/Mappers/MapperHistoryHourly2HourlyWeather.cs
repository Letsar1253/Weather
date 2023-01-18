using Common.Data.Models;
using Server.DownloadersProvider.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.DownloadersProvider.Mappers
{
    internal class MapperHistoryHourly2HourlyWeather: BaseMapper
    {
        public List<HourlyWeather> Map(HistoryHourly historyHourly)
        {
            if (historyHourly.data is null)
                throw new Exception("Нет данных для сопоставления");

            var hourlyWeathers = new List<HourlyWeather>();
            foreach (var history in historyHourly.data)
            {
                var hourlyWeather = CreateDailyWeather(history);
                hourlyWeathers.Add(hourlyWeather);
            }

            return hourlyWeathers;
        }

        private HourlyWeather CreateDailyWeather(HistoryHour history)
        {
            var hourlyWeather = new HourlyWeather
            {
                DateTime = history.timestamp_local is not null ? DateTime.Parse(history.timestamp_local) : null,
                SnowDepth = history.snow,
                Temperature = history.temp,
                DewPoint = history.dewpt,
                ApparenTemperaturet = history.app_temp,
                PartDay = history.pod,
                WindDirection = history.wind_dir,
                CardinalWindDirection = "",
                WindSpeed = history.wind_spd,
                Pressure = history.pres,
                RelativeHumidity = history.rh,
                Precipitation = history.precip,
                Snowfall = history.snow,
                CloudCover = history.clouds,
                IsForecast = false
            };

            if (history.weather is not null)
            {
                var inlineModel = history.weather;
                hourlyWeather.WeatherIcon = CreateWeatherIcon(inlineModel);
            }

            return hourlyWeather;
        }
    }
}
