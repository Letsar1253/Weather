using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Server.DatabaseProvider;
using Server.DatabaseProvider.Models;

namespace Server.Provider
{
    public interface IDataProvider
    {
        public Task<CurrentWeather> GetCurrentWheather(DateTime date);

        public Task<DailyWeather> GetForecastWheather(DateTime date);

        public Task<DailyWeather> GetHistoryWheather(DateTime date);
    }
}
