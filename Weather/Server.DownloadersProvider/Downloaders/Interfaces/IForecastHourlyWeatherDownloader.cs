using Common.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.DownloadersProvider.Downloaders.Interfaces
{
    internal interface IForecastHourlyWeatherDownloader
    {
        Task<List<HourlyWeather>> Download(string city, string county);
    }
}
