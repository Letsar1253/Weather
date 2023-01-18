using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Server.DatabaseProvider.Models
{
    internal class WeatherAppDbContext : DbContext
    {
        public DbSet<CurrentWeather> currentWeather { get; set; }
        public DbSet<DailyWeather> dailyWeather { get; set; }
        public DbSet<HourlyWeather> hourlyWeather { get; set; }
        public DbSet<WeatherIcon> weatherIcon { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=weather;Username=postgres;Password=1253");
        }
    }
}
