using Server.DownloadersProvider.Models;
using Server.DatabaseProvider.Models;

namespace Server.DownloadersProvider.Mappers
{
    internal abstract class BaseMapper
    {
        protected WeatherIcon CreateWeatherIcon(inline_model inlineModel)
        {
            var weatherIcon = new WeatherIcon
            {
                WeatherIconId = Guid.NewGuid(),
                Icon = inlineModel.icon,
                Code = inlineModel.code,
                Description = inlineModel.description
            };

            return weatherIcon;
        }
    }
}
