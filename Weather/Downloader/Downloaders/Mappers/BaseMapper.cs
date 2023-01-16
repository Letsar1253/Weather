using Downloaders.Downloaders.DownloadModels;
using Downloaders.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Downloaders.Downloaders.Mappers
{
    public abstract class BaseMapper
    {
        protected WeatherIcon CreateWeatherIcon(inline_model inlineModel)
        {
            var weatherIcon = new WeatherIcon
            {
                Icon = inlineModel.icon,
                Code = inlineModel.code,
                Description = inlineModel.description
            };

            return weatherIcon;
        }
    }
}
