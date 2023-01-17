namespace Server.DownloadersProvider.Models
{
    internal struct ForecastHour
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
        /// Accumulated snowfall since last forecast point - Default (mm)
        /// </summary>
        public double? snow { get; set; }

        /// <summary>
        /// Snow depth - Default (mm) 
        /// </summary>
        public double? snow_depth { get; set; }

        /// <summary>
        /// 6 hour accumulated snowfall. Default (mm)
        /// </summary>
        public double? snow6h { get; set; }

        /// <summary>
        /// Accumulated precipitation since last forecast point. Default (mm)
        /// </summary>
        public double? precip { get; set; }

        /// <summary>
        /// Temperature - Default (C)
        /// </summary>
        public double? temp { get; set; }

        /// <summary>
        /// Dewpoint - Default (C)
        /// </summary>
        public double? dewpt { get; set; }

        /// <summary>
        /// Apparent Temperature - Default (C)
        /// </summary>
        public double? app_temp { get; set; }

        /// <summary>
        /// Relative Humidity as a percentage (%)
        /// </summary>
        public int? rh { get; set; }

        /// <summary>
        /// Cloud cover as a percentage (%)
        /// </summary>
        public int? clouds { get; set; }

        public inline_model? weather { get; set; }

        /// <summary>
        /// Mean Sea level pressure (mb)
        /// </summary>
        public double? slp { get; set; }

        /// <summary>
        /// Pressure (mb)
        /// </summary>
        public double? pres { get; set; }

        /// <summary>
        /// UV Index
        /// </summary>
        public double? uv { get; set; }

        /// <summary>
        /// Estimated solar radiation (W/m^2)
        /// </summary>
        public double? solar_rad { get; set; }

        /// <summary>
        /// Global horizontal solar irradiance (W/m^2)
        /// </summary>
        public double? ghi { get; set; }

        /// <summary>
        /// Diffuse normal solar irradiance (W/m^2)
        /// </summary>
        public double? dhi { get; set; }

        /// <summary>
        /// Direct normal solar irradiance (W/m^2)
        /// </summary>
        public double? dni { get; set; }

        /// <summary>
        /// Visibility - Default (KM)
        /// </summary>
        public double? vis { get; set; }

        /// <summary>
        /// Part of day (d = day, n = night)
        /// </summary>
        public string? pod { get; set; }

        /// <summary>
        /// Chance of Precipitation as a percentage (%)
        /// </summary>
        public double? pop { get; set; }

        /// <summary>
        /// Wind Speed - Default (m/s)
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
