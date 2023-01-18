using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.DatabaseProvider.Models
{
    internal class DailyWeather : Common.Data.Models.DailyWeather
    {
        [Key]
        public Guid Id { get; set; }

        public Guid WeatherIconId { get; set; }

        public WeatherIcon weatherIcon { get; set; }
    }
}
