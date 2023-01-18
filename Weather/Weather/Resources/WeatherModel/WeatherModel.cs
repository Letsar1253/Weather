using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Web.AtomPub;

namespace Weather.Resources.WeatherModel
{
    public class WeatherModel
    {
        public DateTime Day { get; set; }
        public double TemperatureValue { get; set; }
        public string WeatherTypeName { get; set; }
    }
}
