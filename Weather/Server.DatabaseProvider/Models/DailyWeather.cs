using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.DatabaseProvider.Models
{
    internal class DailyWeather
    {
        [Key]
        public Guid DailyWeatherId { get; set; }

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

        public Guid WeatherIconId { get; set; }

        public WeatherIcon WeatherIcon { get; set; }
    }
}
