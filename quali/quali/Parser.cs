using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace quali
{
    class Parser
    {

        static string filePath;
        private StreamReader sr = new StreamReader(filePath);

        public Parser(string pathToTheFile)
        {
            filePath = pathToTheFile;
        }
        public void Initialize()
        {
            
        }
        //zrob tablice filmow
        //zrob talice endpointow
        //zrob tablice requestow
        //zrob tablice cachy i wpisz ich rozmiary
        // uzupelnij dane w tablicy filmow
        // uzupelnij dane endpointow ( opoznienie do datacenter i zrob liste podlaczonych cache )
    }
}
