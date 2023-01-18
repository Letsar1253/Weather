using Server.DatabaseProvider.Models;
using Server.DownloadersProvider.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.DownloadersProvider.Mappers
{
    internal class MapperHistoryDaily2DailyWeather: BaseMapper
    {
        public List<DailyWeather> Map(HistoryDaily historyDaily)
        {
            if (historyDaily.data is null)
                throw new Exception("Нет данных для сопоставления");

            var dailyWeathers = new List<DailyWeather>();
            foreach (var Historyday in historyDaily.data)
            {
                var dailyWeather = CreateDailyWeather(Historyday);
                dailyWeathers.Add(dailyWeather);
            }

            return dailyWeathers;
        }

        private DailyWeather CreateDailyWeather(HistoryDay Historyday)
        {
            var dailyWeather = new DailyWeather
            {
                Date = Historyday.datetime is not null ? DateTime.Parse(Historyday.datetime) : null,
                SnowDepth = Historyday.snow_depth,
                AverageTemperature = Historyday.temp,
                AverageDewPoint = Historyday.dewpt,
                MaxTemperature = Historyday.max_temp,
                MinTemperature = Historyday.min_temp,
                MaxApparenTemperaturet = Historyday.max_temp,
                MinApparenTemperaturet = Historyday.min_temp,
                WindDirection = Historyday.wind_dir,
                CardinalWindDirection = "",
                WindSpeed = Historyday.wind_spd,
                Pressure = Historyday.pres,
                RelativeHumidity = Historyday.rh,
                Precipitation = Historyday.precip,
                Snowfall = Historyday.snow,
                CloudCover = Historyday.clouds,
                IsForecast = false
            };

            return dailyWeather;
        }
    }
}
