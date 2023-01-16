using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Downloaders.Downloaders.DownloadModels
{
    public struct CurrentObsGroup
    {
        /// <summary>
        /// Count of found observations 
        /// </summary>
        public int? count { get; set; }

        public CurrentObs[]? data { get; set; }
    }
}
