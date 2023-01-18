using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.DownloadersProvider
{
    public interface IDownloadProviderFactory
    {
        public IDownloadProvider CreateDownloadProvider(string city, string county);
    }
}
