using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.DownloadersProvider.Models
{
    internal class HistoryDaily
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
        /// <summary>
        /// city_id
        /// </summary>
        public string? city_id { get; set; }
        /// <summary>
        /// List of data sources used in response.
        /// </summary>
        public string? sources { get; set; }
        /// <summary>
        /// [DEPRECATED] Nearest station.
        /// </summary>
        public string? station_id { get; set; }

        public HistoryDay[]? data { get; set; }
    }
}
