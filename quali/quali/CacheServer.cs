using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quali
{
    class CacheServer
    {
        // statyczna stala z rozmiarem serwera - jedna dla wszystkich serwerow
        static readonly int ServerCapacity;
        // lista id filmow
        List<int> videosCachedOnServer = new List<int>();
        // dostepne miejsce
        int freeSpace;
        void AddMovie(Video vid)
        {
            videosCachedOnServer.Add(vid.Id);
            freeSpace -= vid.Size;
        }
    }
}
