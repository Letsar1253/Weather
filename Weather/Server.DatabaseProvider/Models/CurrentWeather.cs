using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Server.DatabaseProvider.Models
{
    internal class CurrentWeather: Common.Data.Models.CurrentWeather
    {
        [Key] 
        public Guid Id { get; set; }

        public Guid WeatherIconId{ get; set; }

        public WeatherIcon weatherIcon { get; set; }

    }
}
