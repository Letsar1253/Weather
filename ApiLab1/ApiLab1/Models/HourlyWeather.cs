using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiLab1.Models
{
    internal class HourlyWeather : Weather
    {
        /// <summary>
        /// Дата и время прогноза
        /// </summary>
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// Глубина снега
        /// </summary>
        public double? SnowDepth { get; set; }

        /// <summary>
        /// Температура
        /// </summary>
        public double? Temperature { get; set; }

        /// <summary>
        /// Точка росы
        /// </summary>
        public double? DewPoint { get; set; }

        /// <summary>
        /// Ощущаемая температура
        /// </summary>
        public double? ApparenTemperaturet { get; set; }

        /// <summary>
        /// Часть дня
        /// </summary>
        public string? PartDay { get; set; }

        /// <summary>
        /// Прогноз ли это?
        /// </summary>
        public bool IsForecast { get; set; }

        /// <summary>
        /// Иконка погоды
        /// </summary>
        public WeatherIcon? WeatherIcon { get; set; }
    }
}
