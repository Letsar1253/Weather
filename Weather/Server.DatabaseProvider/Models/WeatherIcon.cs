using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.DatabaseProvider.Models
{
    internal class WeatherIcon : Common.Data.Models.WeatherIcon
    {
        public Guid Id { get; set; }
    }
}
