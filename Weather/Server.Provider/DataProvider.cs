using Server.DatabaseProvider;
using Server.DatabaseProvider.Models;
using Server.DownloadersProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Server.Provider
{
    public  class DataProvider : IDataProvider
    {
        private IDownloadProvider _downloadProvider;
        private ContextManager _contextManager;

        public DataProvider()
        {
            var context = new WeatherAppDbContext();
            _contextManager = new ContextManager(context);
            var downloadProviderFactory = new DownloadProviderFactory();
            _downloadProvider = downloadProviderFactory.CreateDownloadProvider("Tomsk", "ru");
        }

        public async Task<CurrentWeather> GetCurrentWheather(DateTime date)
        {
            Expression<Func<CurrentWeather, bool>> expression = s => s.Date == date;
            var itemsFromDb = await _contextManager.FindAsync(expression, "WeatherIcon");

            if (itemsFromDb.Any())
                return itemsFromDb.First();

            var itemsFromApi = await _downloadProvider.GetCurrentWeathers();
            await _contextManager.Save(itemsFromApi);

            return itemsFromApi.First();
        }

        public async Task<DailyWeather> GetForecastWheather(DateTime date)
        {
            Expression<Func<DailyWeather, bool>> expression = s => s.Date == date && s.IsForecast;
            var itemsFromDb = await _contextManager.FindAsync(expression, "WeatherIcon");

            if (itemsFromDb.Any())
                return itemsFromDb.First();

            var itemsFromApi = await _downloadProvider.GetForecastDailyWeathers();
            await _contextManager.Save(itemsFromApi);

            return itemsFromApi.First();
        }

        public async Task<DailyWeather> GetHistoryWheather(DateTime date)
        {
            Expression<Func<DailyWeather, bool>> expression = s => s.Date == date && !s.IsForecast;
            var itemsFromDb = await _contextManager.FindAsync(expression, "WeatherIcon");

            if (itemsFromDb.Any())
                return itemsFromDb.First();

            var itemsFromApi = await _downloadProvider.GetHistoryDailyWeathers();
            await _contextManager.Save(itemsFromApi);

            return itemsFromApi.First();
        }
    }
}
