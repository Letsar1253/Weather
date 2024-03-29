﻿using Server.DownloadersProvider.Models;
using Server.DownloadersProvider.Mappers;
using Server.DatabaseProvider.Models;
using Server.DownloadersProvider.Downloaders.Interfaces;

namespace Server.DownloadersProvider.Downloaders
{
    internal class CurrentWeatherDownloader : ICurrentWeatherDownloader
    {
        private readonly string _pathApi = "current";

        public async Task<List<CurrentWeather>> Download(string city, string county)
        {
            var argumentsForQuery = new List<string>
            {
                "city=" + city,
                "country=" + county 
            };
            var downloadedResult = await WeatherDownloader.Download<CurrentObsGroup>(_pathApi, argumentsForQuery);
            var currentWeathers = HandleDownloadedResult(downloadedResult);

            return currentWeathers;
        }

        private List<CurrentWeather> HandleDownloadedResult(object? downloadedResult)
        {
            if (downloadedResult is not CurrentObsGroup currentObsGroup)
                throw new Exception("Закаченные данные не соответствуют необходимому типу");

            var mapper = new MapperCurrentObsGroup2CurrentWeather();
            var currentWeathers = mapper.Map(currentObsGroup);
            if (currentWeathers.Count == 0)
                throw new Exception("Не удалось закачать данные о текущей погоде");

            return currentWeathers;
        }
    }
}
