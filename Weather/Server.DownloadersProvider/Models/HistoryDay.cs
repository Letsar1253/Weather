using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.DownloadersProvider.Models
{
    internal class HistoryDay
    {
        /// <summary>
        ///  Date (YYYY-MM-DD).
        /// </summary>
        public string? datetime { get; set; }
        /// <summary>
        /// Timestamp UTC (Unix Timestamp).
        /// </summary>
        public double? ts { get; set; }
        /// <summary>
        /// Data revision status - interim (subject to revisions) or final.
        /// </summary>
        public string? revision_status { get; set; }
        /// <summary>
        /// Average pressure (mb).
        /// </summary>
        public double? pres { get; set; }
        /// <summary>
        ///  Average sea level pressure (mb).
        /// </summary>
        public double? slp { get; set; }
        /// <summary>
        /// Average wind speed (Default m/s).
        /// </summary>
        public double? wind_spd { get; set; }
        /// <summary>
        /// Wind gust speed (m/s).
        /// </summary>
        public double? wind_gust_spd { get; set; }
        /// <summary>
        /// Maximum 2 minute wind speed (m/s).
        /// </summary>
        public double? max_wind_spd { get; set; }
        /// <summary>
        ///Average wind direction (degrees)
        /// </summary>
        public double? wind_dir { get; set; }
        /// <summary>
        /// Direction of maximum 2 minute wind gust (degrees).
        /// </summary>
        public double? max_wind_dir { get; set; }
        /// <summary>
        /// Time of maximum wind gust UTC (Unix Timestamp).
        /// </summary>
        public double? max_wind_ts { get; set; }
        /// <summary>
        /// Average temperature (default Celsius).
        /// </summary>
        public double? temp { get; set; }
        /// <summary>
        ///  Maximum temperature (default Celsius).
        /// </summary>
        public double? max_temp { get; set; }
        /// <summary>
        /// Minimum temperature (default Celsius).
        /// </summary>
        public double? min_temp { get; set; }
        /// <summary>
        /// Time of daily maximum temperature UTC (Unix Timestamp).
        /// </summary>
        public double? max_temp_ts { get; set; }
        /// <summary>
        /// Time of daily minimum temperature UTC (Unix Timestamp).
        /// </summary>
        public double? min_temp_ts { get; set; }
        /// <summary>
        ///  Average relative humidity (%).
        /// </summary>
        public double? rh { get; set; }
        /// <summary>
        /// Average dew point (default Celsius).
        /// </summary>
        public double? dewpt { get; set; }
        /// <summary>
        ///  [Satellite based] average cloud coverage (%).
        /// </summary>
        public double? clouds { get; set; }
        /// <summary>
        /// Accumulated precipitation (default mm).
        /// </summary>
        public double? precip { get; set; }
        /// <summary>
        ///  Accumulated precipitation [satellite/radar estimated] (default mm).
        /// </summary>
        public double? precip_gpm { get; set; }
        /// <summary>
        /// Accumulated snowfall (default mm).
        /// </summary>
        public double? snow { get; set; }
        /// <summary>
        ///  Snow Depth (default mm).
        /// </summary>
        public double? snow_depth { get; set; }
        /// <summary>
        /// Average solar radiation (W/M^2)
        /// </summary>
        public double? solar_rad { get; set; }
        /// <summary>
        ///Total solar radiation (W/M^2)
        /// </summary>
        public double? t_solar_rad { get; set; }
        /// <summary>
        ///  Average global horizontal solar irradiance (W/m^2).
        /// </summary>
        public double? ghi { get; set; }
        /// <summary>
        /// Day total global horizontal solar irradiance (W/m^2) [Clear Sky]
        /// </summary>
        public double? t_ghi { get; set; }
        /// <summary>
        /// Maximum value of global horizontal solar irradiance in day (W/m^2) [Clear Sky]
        /// </summary>
        public double? max_ghi { get; set; }
        /// <summary>
        /// Average direct normal solar irradiance (W/m^2) [Clear Sky]
        /// </summary>
        public double? dni { get; set; }
        /// <summary>
        ///  Day total direct normal solar irradiance (W/m^2) [Clear Sky]
        /// </summary>
        public double? t_dni { get; set; }
        /// <summary>
        /// Maximum value of direct normal solar irradiance in day (W/m^2) [Clear Sky]
        /// </summary>
        public double? max_dni { get; set; }
        /// <summary>
        /// Average diffuse horizontal solar irradiance (W/m^2) [Clear Sky]
        /// </summary>
        public double? dhi { get; set; }
        /// <summary>
        ///  Day total diffuse horizontal solar irradiance (W/m^2) [Clear Sky]
        /// </summary>
        public double? t_dhi { get; set; }
        /// <summary>
        ///  Maximum value of diffuse horizontal solar irradiance in day (W/m^2) [Clear Sky]
        /// </summary>
        public double? max_dhi { get; set; }
        /// <summary>
        /// Maximum UV Index (0-11+)
        /// </summary>
        public double? max_uv { get; set; }

    }
}
