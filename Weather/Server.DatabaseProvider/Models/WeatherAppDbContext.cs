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
        public DbSet<CurrentWeather> currentW { get; set; }
        public DbSet<DailyWeather> dailyW { get; set; }
        public DbSet<HourlyWeather> hourlyW { get; set; }
        public DbSet<WeatherIcon> wIcon { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=weatherDb;Username=postgres;Password=weatherAd");
        }
    }
}
