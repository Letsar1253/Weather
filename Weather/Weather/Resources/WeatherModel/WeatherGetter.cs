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

        public WeatherGetter()
        {
            dataProvider = new DataProvider();
        }

        public async Task<WeatherModel> GetData(DateTime day)
        {
            WeatherModel weatherModel = new WeatherModel();
            var timeNow = DateTime.Now.Date;
            if (day == timeNow)
            {
                var item = await dataProvider.GetCurrentWheather(day);
                weatherModel.Day = item.Date;
                weatherModel.TemperatureValue = (double)item.Temperature;
                weatherModel.WeatherTypeName = "sunny";
            }
            else if (day > timeNow)
            {
                var item = await dataProvider.GetForecastWheather(day);
                weatherModel.Day = (DateTime)item.Date;
                weatherModel.TemperatureValue = (double)item.AverageTemperature;
                weatherModel.WeatherTypeName = "sunny";
            }
            else
            {
                var item = await dataProvider.GetHistoryWheather(day);
                weatherModel.Day = (DateTime)item.Date;
                weatherModel.TemperatureValue = (double)item.AverageTemperature;
                weatherModel.WeatherTypeName = "sunny";
            }

            return weatherModel;
        }
    }
}
