using Server.DatabaseProvider.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.DownloadersProvider.Downloaders.Interfaces
{
    internal interface IHistoryDailyWeatherDownloader
    {
        Task<List<DailyWeather>> Download(string city, string county);
    }
}
