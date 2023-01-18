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
        public WeatherModel GetData(DateTime day)
        {
            WeatherModel weatherModel = new WeatherModel();
            var timeNow = DateTime.Now;
            if (day == timeNow)
                dataProvider.GetCurrentWheather(day);
            else if (day > timeNow)
                dataProvider.GetForecastWheather(day);
            else
                dataProvider.GetHistoryWheather(day);
            return weatherModel;
        }
    }
}
