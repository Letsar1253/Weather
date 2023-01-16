using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Downloaders.Downloaders.DownloadModels
{
    public class inline_model
    {
        /// <summary>
        /// Icon code for forecast image display 
        /// </summary>
        public string? icon { get; set; }

        /// <summary>
        /// Weather Condition code
        /// </summary>
        public string? code { get; set; }

        /// <summary>
        /// Weather Condition description
        /// </summary>
        public string? description { get; set; }
    }
}
