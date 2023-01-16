using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Downloaders.Models
{
    public class DailyWeather :  Weather
    {
        /// <summary>
        /// Дата
        /// </summary>
        public DateTime? Date { get; set; }

        /// <summary>
        /// Глубина снега
        /// </summary>
        public double? SnowDepth { get; set; }

        /// <summary>
        /// Средняя температура
        /// </summary>
        public double? AverageTemperature { get; set; }

        /// <summary>
        /// Средняя точка росы
        /// </summary>
        public double? AverageDewPoint { get; set; }

        /// <summary>
        /// Максимальная температура
        /// </summary>
        public double? MaxTemperature { get; set; }

        /// <summary>
        /// Минимальная температура
        /// </summary>
        public double? MinTemperature { get; set; }

        /// <summary>
        /// Максимальная ощущаемая температура
        /// </summary>
        public double? MaxApparenTemperaturet { get; set; }

        /// <summary>
        /// Минимальная ощущаемая температура
        /// </summary>
        public double? MinApparenTemperaturet { get; set; }

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
