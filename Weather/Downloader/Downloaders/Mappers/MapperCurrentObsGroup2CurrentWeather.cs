using Downloaders.Downloaders.DownloadModels;
using Downloaders.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Downloaders.Downloaders.Mappers
{
    public class MapperCurrentObsGroup2CurrentWeather : BaseMapper
    {
        public List<CurrentWeather> Map(CurrentObsGroup currentObsGroup)
        {
            if (currentObsGroup.data is null)
                throw new Exception("Нет данных для сопоставления");

            var currentWeathers = new List<CurrentWeather>();
            foreach (var currentObs in currentObsGroup.data)
            {
                var currentWeather = CreateCurrentWeather(currentObs);
                currentWeathers.Add(currentWeather);
            }

            return currentWeathers;
        }

        private CurrentWeather CreateCurrentWeather(CurrentObs currentObs)
        {
            var currentWeather = new CurrentWeather
            {
                DewPoint = currentObs.dewpt,
                Temperature = currentObs.temp,
                ApparentTemperature = currentObs.app_temp,
                TimeSunrise = currentObs.sunrise is not null ? TimeOnly.Parse(currentObs.sunrise) : null,
                TimeSunset = currentObs.sunset is not null ? TimeOnly.Parse(currentObs.sunset) : null,
                AirQualityIndex = currentObs.aqi,
                PartDay = currentObs.pod,
                WindDirection = currentObs.wind_dir,
                CardinalWindDirection = currentObs.wind_cdir,
                WindSpeed = currentObs.wind_speed,
                Pressure = currentObs.pres,
                RelativeHumidity = currentObs.rh,
                Precipitation = currentObs.precip,
                Snowfall = currentObs.snow,
                CloudCover = currentObs.clouds
            };

            if (currentObs.weather is not null)
            {
                var inlineModel = currentObs.weather;
                currentWeather.WeatherIcon = CreateWeatherIcon(inlineModel);
            }

            return currentWeather;
        }
    }
}
