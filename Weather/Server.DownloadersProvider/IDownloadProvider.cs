using Server.DatabaseProvider.Models;
using Server.DownloadersProvider.Downloaders.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.DownloadersProvider
{
    public interface IDownloadProvider
    {
        public Task<List<CurrentWeather>> GetCurrentWeathers();

        public Task<List<DailyWeather>> GetForecastDailyWeathers();

        public Task<List<HourlyWeather>> GetForecastHourlyWeathers();

        public Task<List<DailyWeather>> GetHistoryDailyWeathers();

        public Task<List<HourlyWeather>> GetHistoryHourlyWeathers();
    }
}
