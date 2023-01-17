namespace Server.DownloadersProvider.Models
{
    internal struct ForecastDay
    {
        /// <summary>
        /// City Name
        /// </summary>
        public string? city_name { get; set; }

        /// <summary>
        /// State Abbreviation 
        /// </summary>
        public string? state_code { get; set; }

        /// <summary>
        /// Country Abbreviation
        /// </summary>
        public string? country_code { get; set; }

        /// <summary>
        /// Latitude
        /// </summary>
        public string? lat { get; set; }

        /// <summary>
        /// Longitude
        /// </summary>
        public string? lon { get; set; }

        /// <summary>
        /// Local IANA time zone
        /// </summary>
        public string? timezone { get; set; }

        public Forecast[]? data { get; set; }
    }
}
