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
        static int ServerCapacity;
        // lista id filmow
        public List<int> videosCachedOnServer = new List<int>();
        // dostepne miejsce
        int freeSpace;
        public CacheServer(int cap)
        {
            ServerCapacity = cap;
            freeSpace = ServerCapacity;
        }
        public void AddMovie(Video vid)
        {
            videosCachedOnServer.Add(vid.Id);
            freeSpace -= vid.Size;
        }
    }
}
