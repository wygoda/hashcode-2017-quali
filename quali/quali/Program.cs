using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace quali
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            StreamReader sr = new StreamReader(args[0]);
            Video[] videos;
            Endpoint[] endpoints;
            Request[] requests;
            CacheServer[] cachedServers;            
            //brzydkie gowno over here
            #region Initialization
            {
                int[] numbers = ConvertLineToIntArray(ref sr);
                videos = new Video[numbers[0]];
                endpoints = new Endpoint[numbers[1]];
                requests = new Request[numbers[2]];
                cachedServers = new CacheServer[numbers[3]];
                string []numbersFromLine = sr.ReadLine().Split(' ');
                for (int i = 0; i < videos.Length; i++)
                {
                    videos[i] = new Video(i, Convert.ToInt32(numbersFromLine[i]));
                }
            }

            #endregion



            //zrob tablice filmow
            //zrob talice endpointow
            //zrob tablice requestow
            //zrob tablice cachy i wpisz ich rozmiary
            // uzupelnij dane w tablicy filmow
            // uzupelnij dane endpointow ( opoznienie do datacenter i zrob liste podlaczonych cache )


            //globalna lista filmow listaFilmow[i] rozmiar video i
        }
        static Endpoint ReadEndpointFromFile(ref StreamReader sr)
        {
            int dataCenterLantency;
            int numberOfEndpoints;

            return null;
        }
        static int [] ConvertLineToIntArray(ref StreamReader sr)
        {
            string[] numbersFromLine = sr.ReadLine().Split(' ');
            int[] numbers = new int[numbersFromLine.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(numbersFromLine[i]);
            }
            return numbers;
        }
    }
}
