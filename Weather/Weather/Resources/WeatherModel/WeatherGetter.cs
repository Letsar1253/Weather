using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Server.Provider;

namespace Weather.Resources.WeatherModel
{
    public class WeatherGetter
    {
        private IDataProvider dataProvider;
        readonly Dictionary<int, string> weatherTypeImages = new() {
        { 200,            "thunder_rain" },
        { 201,             "thunder_rain" },
        { 202,             "thunder_rain" },
        { 230,          "thunder_rain" },
        { 231, "thunder_rain" },
        { 232,            "thunder_rain" },
        { 233,             "thunder" },
        { 300,          "rain" },
        { 301,     "rain" },
        { 302,            "rain" },
        { 500,             "rain" },
        { 501,             "rain" },
        { 502,          "rain" },
        { 511, "rain" },
        { 520,            "rain" },
        { 521,             "rain" },
        { 522,          "rain" },
        { 600,     "snow" },
        { 601,            "snow" },
        { 602,             "snow" },
        { 610,             "snow" },
        { 611,          "sleet" },
        { 612, "sleet" },
        { 621,            "snow" },
        { 622,             "snow" },
        { 623,          "snow" },
        { 700,     "thunder_rain" },
        { 711,            "haze" },
        { 721,             "haze" },
        { 731,             "haze" },
        { 741,          "haze" },
        { 751, "haze" },
        { 800,            "sunny" },
        { 801,             "cloudly" },
        { 802,          "cloudly" },
        { 803,     "overcast_cloudly" },
        { 804,          "overcast_cloudly" },
        { 900,     "overcast_cloudly" },
    };

        public WeatherGetter()
        {
            dataProvider = new DataProvider();
        }

        public async Task<WeatherModel> GetData(DateTime day)
        {
            day = day.ToUniversalTime().Date;
            WeatherModel weatherModel = new WeatherModel();
            var timeNow = DateTime.Now.ToUniversalTime().Date;
            if (day == timeNow)
            {
                var item = await dataProvider.GetCurrentWheather(day);
                weatherModel.Day = item.Date;
                weatherModel.TemperatureValue = (double)item.Temperature;
                weatherModel.WeatherTypeName = weatherTypeImages[Convert.ToInt32(item.WeatherIcon.Code)];
            }
            else if (day > timeNow)
            {
                var item = await dataProvider.GetForecastWheather(day);
                weatherModel.Day = (DateTime)item.Date;
                weatherModel.TemperatureValue = (double)item.AverageTemperature;
                weatherModel.WeatherTypeName = weatherTypeImages[Convert.ToInt32(item.WeatherIcon.Code)];
            }
            else
            {
                var item = await dataProvider.GetHistoryWheather(day);
                weatherModel.Day = (DateTime)item.Date;
                weatherModel.TemperatureValue = (double)item.AverageTemperature;
                weatherModel.WeatherTypeName = weatherTypeImages[Convert.ToInt32(item.WeatherIcon.Code)];
            }

            return weatherModel;
        }

   
    }
}
