using Common.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.DownloadersProvider.Downloaders.Interfaces
{
    public interface ICurrentWeatherDownloader
    {
        Task<List<CurrentWeather>> Download(string city, string county);
    }
}
