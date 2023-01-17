using Server.DownloadersProvider.Models;
using Common.Data.Models;

namespace Server.DownloadersProvider.Mappers
{
    internal abstract class BaseMapper
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
