using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Server.DatabaseProvider.Models
{
    public class WeatherAppDbContext : DbContext
    {
        public DbSet<CurrentWeather> CurrentWeather { get; set; }
        public DbSet<DailyWeather> DailyWeather { get; set; }
        public DbSet<HourlyWeather> HourlyWeather { get; set; }
        public DbSet<WeatherIcon> WeatherIcon { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=weather;Username=postgres;Password=1253");
        }
    }
}
