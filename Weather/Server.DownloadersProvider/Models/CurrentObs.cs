namespace Server.DownloadersProvider.Models
{
    internal struct CurrentObs
    {
        /// <summary>
        /// City name (closest) 
        /// </summary>
        public string? city_name { get; set; }

        /// <summary>
        /// State abbreviation
        /// </summary>
        public string? state_code { get; set; }

        /// <summary>
        /// Country abbreviation 
        /// </summary>
        public string? country_code { get; set; }

        /// <summary>
        /// Local IANA time zone 
        /// </summary>
        public string? timezone { get; set; }

        /// <summary>
        /// Latitude 
        /// </summary>
        public double? lat { get; set; }

        /// <summary>
        /// Longitude 
        /// </summary>
        public double? lon { get; set; }

        /// <summary>
        /// Source Station ID
        /// </summary>
        public string? station { get; set; }

        /// <summary>
        /// List of data sources used in response
        /// </summary>
        public string[]? sources { get; set; }

        /// <summary>
        /// Visibility - default (M)
        /// </summary>
        public int? vis { get; set; }

        /// <summary>
        /// Relative humidity (%) 
        /// </summary>
        public double? rh { get; set; }

        /// <summary>
        /// Dew point temperature - default (C) 
        /// </summary>
        public double? dewpt { get; set; }

        /// <summary>
        /// Wind direction (degrees) 
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

        /// <summary>
        /// Wind speed - Default (m/s) 
        /// </summary>
        public double? wind_speed { get; set; }

        /// <summary>
        /// Temperature - Default (C)
        /// </summary>
        public double? temp { get; set; }

        /// <summary>
        /// Apparent temperature - Default (C) 
        /// </summary>
        public double? app_temp { get; set; }

        /// <summary>
        /// Cloud cover (%) 
        /// </summary>
        public int? clouds { get; set; }

        public inline_model_3? weather { get; set; }

        /// <summary>
        /// Cycle Hour (UTC) of observation
        /// </summary>
        public string? datetime { get; set; }

        /// <summary>
        /// Full time (UTC) of observation (YYYY-MM-DD HH:MM)
        /// </summary>
        public string? ob_time { get; set; }

        /// <summary>
        /// Unix Timestamp
        /// </summary>
        public double? ts { get; set; }

        /// <summary>
        /// Time (UTC) of Sunrise (HH:MM)
        /// </summary>
        public string? sunrise { get; set; }

        /// <summary>
        /// Time (UTC) of Sunset (HH:MM) 
        /// </summary>
        public string? sunset { get; set; }

        /// <summary>
        /// Mean sea level pressure in millibars (mb) 
        /// </summary>
        public double? slp { get; set; }

        /// <summary>
        /// Pressure (mb)
        /// </summary>
        public double? pres { get; set; }

        /// <summary>
        /// Air quality index (US EPA standard 0 to +500)
        /// </summary>
        public double? aqi { get; set; }

        /// <summary>
        /// UV Index
        /// </summary>
        public double? uv { get; set; }

        /// <summary>
        /// Estimated solar radiation (W/m^2) 
        /// </summary>
        public double? solar_rad { get; set; }

        /// <summary>
        /// Global horizontal irradiance (W/m^2) 
        /// </summary>
        public double? ghi { get; set; }

        /// <summary>
        /// Direct normal irradiance (W/m^2) 
        /// </summary>
        public double? dni { get; set; }

        /// <summary>
        /// Diffuse horizontal irradiance (W/m^2) 
        /// </summary>
        public double? dhi { get; set; }

        /// <summary>
        /// Current solar elevation angle (Degrees)
        /// </summary>
        public double? elev_angle { get; set; }

        /// <summary>
        /// Current solar hour angle (Degrees) 
        /// </summary>
        public double? hour_angle { get; set; }

        /// <summary>
        /// Part of the day (d = day, n = night) 
        /// </summary>
        public string? pod { get; set; }

        /// <summary>
        /// Precipitation in last hour - Default (mm) 
        /// </summary>
        public double? precip { get; set; }

        /// <summary>
        /// Snowfall in last hour - Default (mm)
        /// </summary>
        public double? snow { get; set; }

    }
}
