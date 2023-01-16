using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Downloaders.Downloaders.DownloadModels
{
    public struct Forecast
    {
        /// <summary>
        /// Unix Timestamp 
        /// </summary>
        public double? ts { get; set; }

        /// <summary>
        /// Timestamp in local time 
        /// </summary>
        public string? timestamp_local { get; set; }

        /// <summary>
        /// Timestamp UTC
        /// </summary>
        public string? timestamp_utc { get; set; }

        /// <summary>
        /// Date in format "YYYY-MM-DD:HH". All datetime is in (UTC) 
        /// </summary>
        public string? datetime { get; set; }

        /// <summary>
        /// Accumulated snowfall since last forecast point - default (mm)
        /// </summary>
        public double? snow { get; set; }

        /// <summary>
        /// Snow Depth - default (mm) 
        /// </summary>
        public double? snow_depth { get; set; }

        /// <summary>
        /// Accumulated precipitation since last forecast point - default (mm) 
        /// </summary>
        public double? precip { get; set; }

        /// <summary>
        /// Temperature (Average) - default (C) 
        /// </summary>
        public double? temp { get; set; }

        /// <summary>
        /// Dewpoint (Average) - default (C)
        /// </summary>
        public double? dewpt { get; set; }

        /// <summary>
        /// Maximum daily Temperature - default (C) 
        /// </summary>
        public double? max_temp { get; set; }

        /// <summary>
        /// Minimum daily Temperature - default (C)
        /// </summary>
        public double? min_temp { get; set; }

        /// <summary>
        /// Apparent Maximum daily Temperature - default (C)
        /// </summary>
        public double? app_max_temp { get; set; }

        /// <summary>
        /// Apparent Minimum daily Temperature - default (C) 
        /// </summary>
        public double? app_min_temp { get; set; }

        /// <summary>
        /// Relative Humidity as a percentage (%) 
        /// </summary>
        public int? rh { get; set; }

        /// <summary>
        /// Cloud cover as a percentage (%)
        /// </summary>
        public int? clouds { get; set; }

        public inline_model_0? weather { get; set; }

        /// <summary>
        /// Mean Sea level pressure (mb)
        /// </summary>
        public double? slp { get; set; }

        /// <summary>
        ///  Pressure (mb) 
        /// </summary>
        public double? pres { get; set; }

        /// <summary>
        /// UV Index
        /// </summary>
        public double? uv { get; set; }

        /// <summary>
        /// [Deprecated] Max direct component of solar insolation (W/m^2)
        /// </summary>
        public double? max_dhi { get; set; }

        /// <summary>
        /// Average Visibility default (KM)
        /// </summary>
        public double? vis { get; set; }

        /// <summary>
        /// Chance of Precipitation as a percentage (%)
        /// </summary>
        public double? pop { get; set; }

        /// <summary>
        /// Moon phase 
        /// </summary>
        public double? moon_phase { get; set; }

        /// <summary>
        /// Sunrise unix timestamp
        /// </summary>
        public int? sunrise_ts { get; set; }

        /// <summary>
        /// Sunset unix timestamp 
        /// </summary>
        public int? sunset_ts { get; set; }

        /// <summary>
        /// Moonrise unix timestamp
        /// </summary>
        public int? moonrise_ts { get; set; }

        /// <summary>
        /// Moonset unix timestamp
        /// </summary>
        public int? moonset_ts { get; set; }

        /// <summary>
        /// Part of the day (d = day, n = night) 
        /// </summary>
        public string? pod { get; set; }

        /// <summary>
        /// Wind Speed (default m/s)
        /// </summary>
        public double? wind_spd { get; set; }

        /// <summary>
        /// Wind direction
        /// </summary>
        public int? wind_dir { get; set; }

        /// <summary>
        /// Cardinal wind direction
        /// </summary>
        public string? wind_cdir { get; set; }

        /// <summary>
        /// Cardinal wind direction (text)
        /// </summary>
        public string? wind_cdir_full { get; set; }
    }
}
