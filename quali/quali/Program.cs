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
            StreamReader sr = new StreamReader(args[0]);
            Video[] videos;
            Endpoint[] endpoints;
            Request[] requests;
            CacheServer[] cachedServers;            
            //brzydkie gowno over here
            #region Initialization
            {
                string[] numbersFromLine = sr.ReadLine().Split(' ');
                int[] numbers = new int[numbersFromLine.Length];
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = Convert.ToInt32(numbersFromLine[i]);
                }
                videos = new Video[numbers[0]];
                endpoints = new Endpoint[numbers[1]];
                requests = new Request[numbers[2]];
                cachedServers = new CacheServer[numbers[3]];
                numbersFromLine = sr.ReadLine().Split(' ');
                for (int i = 0; i < numbers.Length; i++)
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
    }
}
