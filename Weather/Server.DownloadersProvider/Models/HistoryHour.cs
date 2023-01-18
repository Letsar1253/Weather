using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.DownloadersProvider.Models
{
    internal class HistoryHour
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
        ///Average wind direction (degrees)
        /// </summary>
        public double? wind_dir { get; set; }

        /// <summary>
        /// Average temperature (default Celsius).
        /// </summary>
        public double? temp { get; set; }

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
        /// Accumulated snowfall (default mm).
        /// </summary>
        public double? snow { get; set; }

        /// <summary>
        /// Average solar radiation (W/M^2)
        /// </summary>
        public string? solar_rad { get; set; }

        /// <summary>
        ///  Average global horizontal solar irradiance (W/m^2).
        /// </summary>
        public string? ghi { get; set; }

        /// <summary>
        /// Average direct normal solar irradiance (W/m^2) [Clear Sky]
        /// </summary>
        public string? dni { get; set; }

        /// <summary>
        /// Average diffuse horizontal solar irradiance (W/m^2) [Clear Sky]
        /// </summary>
        public string? dhi { get; set; }

        /// <summary>
        /// Timestamp at Local time.
        /// </summary>
        public string? timestamp_local { get; set; }

        /// <summary>
        /// Timestamp at UTC time.
        /// </summary>
        public string? timestamp_utc { get; set; }

        /// <summary>
        /// Apparent/"Feels Like" temperature (default Celsius).
        /// </summary>
        public double? app_temp { get; set; }

        /// <summary>
        ///  Part of the day (d = day / n = night).
        /// </summary>
        public string? pod { get; set; }

        /// <summary>
        ///  Visibility (default KM).
        /// </summary>
        public string? vis { get; set; }

        /// <summary>
        ///  UV Index (0-11+).
        /// </summary>
        public string? uv { get; set; }

        /// <summary>
        /// Solar elevation angle (degrees).
        /// </summary>
        public string? elev_angle { get; set; }

        /// <summary>
        ///  Solar azimuth angle (degrees).
        /// </summary>
        public string? azimuth { get; set; }

        /// <summary>
        /// [DEPRECATED] Solar hour angle (degrees).
        /// </summary>
        public string? h_angle { get; set; }

        public inline_model_0? weather { get; set; }

    }
}
