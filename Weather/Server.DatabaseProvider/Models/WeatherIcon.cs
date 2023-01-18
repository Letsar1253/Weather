using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.DatabaseProvider.Models
{
    internal class WeatherIcon
    {
        [Key]
        public Guid WeatherIconId { get; set; }

        public string? Icon { get; set; }

        public string? Code { get; set; }

        public string? Description { get; set; }
    }
}
