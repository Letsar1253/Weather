namespace Server.DownloadersProvider.Models
{
    internal struct CurrentObsGroup
    {
        /// <summary>
        /// Count of found observations 
        /// </summary>
        public int? count { get; set; }

        public CurrentObs[]? data { get; set; }
    }
}
