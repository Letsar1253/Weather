using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiLab1.Models
{
    internal class CurrentWeather: Weather
    {
        /// <summary>
        /// Точка росы
        /// </summary>
        public double? DewPoint { get; set; }

        /// <summary>
        /// Температура
        /// </summary>
        public double? Temperature { get; set; }

        /// <summary>
        /// Ощущаемая температура
        /// </summary>
        public double? ApparentTemperature { get; set; }

        /// <summary>
        /// Время восхода
        /// </summary>
        public TimeOnly? TimeSunrise { get; set; }

        /// <summary>
        /// Время заката
        /// </summary>
        public TimeOnly? TimeSunset { get; set; }

        /// <summary>
        /// Качество воздуха
        /// </summary>
        public double? AirQualityIndex { get; set; }

        /// <summary>
        /// Часть дня
        /// </summary>
        public string? PartDay { get; set; }

        /// <summary>
        /// Иконка погоды
        /// </summary>
        public WeatherIcon? WeatherIcon { get; set; }
    }
}
