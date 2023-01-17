﻿using Downloaders.Downloaders.DownloadModels;
using Downloaders.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Downloaders.Downloaders.Mappers
{
    public class MapperForecastHourly2HourlyWeather : BaseMapper
    {
        public List<HourlyWeather> Map(ForecastHourly forecastHourly)
        {
            if (forecastHourly.data is null)
                throw new Exception("Нет данных для сопоставления");

            var hourlyWeathers = new List<HourlyWeather>();
            foreach (var forecast in forecastHourly.data)
            {
                var hourlyWeather = CreateDailyWeather(forecast);
                hourlyWeathers.Add(hourlyWeather);
            }

            return hourlyWeathers;
        }

        private HourlyWeather CreateDailyWeather(ForecastHour forecast)
        {
            var hourlyWeather = new HourlyWeather
            {
                DateTime = forecast.timestamp_local is not null ? DateTime.Parse(forecast.timestamp_local) : null,
                SnowDepth = forecast.snow_depth,
                Temperature = forecast.temp,
                DewPoint = forecast.dewpt,
                ApparenTemperaturet = forecast.app_temp,
                PartDay = forecast.pod,
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
                hourlyWeather.WeatherIcon = CreateWeatherIcon(inlineModel);
            }

            return hourlyWeather;
        }
    }
}