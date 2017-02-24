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
            //WE HAVE TO CHECK IF THERE IS ENOUGH OF STORAGE SPACE TO ADD THE VIDEO FIRST
            if (freeSpace<vid.Size||videosCachedOnServer.Contains(vid.Id))
            {
                Console.WriteLine("We dont have enough space or movie #"+vid.Id+" is already on the list");
                return;
            }
            videosCachedOnServer.Add(vid.Id);
            freeSpace -= vid.Size;
        }
    }
}
