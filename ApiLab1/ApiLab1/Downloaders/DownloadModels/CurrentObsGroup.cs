using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiLab1.Downloaders.DownloadModels
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
