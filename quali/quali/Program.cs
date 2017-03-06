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
                int[] numbers = ConvertLineToIntArray(ref sr);
                videos = new Video[numbers[0]];
                endpoints = new Endpoint[numbers[1]];
                requests = new Request[numbers[2]];
                cachedServers = new CacheServer[numbers[3]];
                for (int i = 0; i < cachedServers.Length; i++)
                {
                    cachedServers[i] = new CacheServer(numbers[4]);
                }
                //cachedServers[0] = new CacheServer(10);
                string []numbersFromLine = sr.ReadLine().Split(' ');
                for (int i = 0; i < videos.Length; i++)
                {
                    videos[i] = new Video(i, Convert.ToInt32(numbersFromLine[i]));
                }
                for (int i = 0; i < endpoints.Length; i++)
                {
                    endpoints[i] = ReadEndpointFromFile(ref sr);
                }
                for (int i = 0; i < requests.Length; i++)
                {
                    requests[i] = ReadRequestFromFile(ref sr);
                }
            }
            #endregion
            ProcessAndChooseRequests(ref videos,ref endpoints,ref requests,ref cachedServers);
            SaveOutputToFile(cachedServers, args[0] + "_output.txt");
            Console.ReadKey();
        
        }
        static Endpoint ReadEndpointFromFile(ref StreamReader sr)
        {
            int[] arr = ConvertLineToIntArray(ref sr);//arr[0]==latency to main server arr[1]==numbers of cache servers connected
            Endpoint end = new Endpoint(arr[0], arr[1]);
            for (int i  = 0; i  <end.cachesAndLatency.Length; i ++)
            {
                arr = ConvertLineToIntArray(ref sr);//arr[0]=id cache arr[1]=latencyFromEndpointToCache
                end.cachesAndLatency[i] = new Tuple<int, int>(arr[0], arr[1]);
            }
            return end;
        }
        static Request ReadRequestFromFile(ref StreamReader sr)
        {
            int[] arr = ConvertLineToIntArray(ref sr);//arr[0] = vidID arr[1]=endpoint id arr[2]=number of request
            Request req = new Request(arr[0], arr[1], arr[2]);
            return req;
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
        static void SaveOutputToFile(CacheServer[] servers,string sourcePath)
        {
            List<int> IDsOfUsedServers = new List<int>();
            StreamWriter sw = new StreamWriter(string.Format(sourcePath + "_output.txt"));
            //this loop searches for used servers to write a proper value in first line of output file
            //and adds their IDs so we dont have to loop throug all servers again
            for (int i = 0; i < servers.Length; i++)
            {
                if (servers[i].videosCachedOnServer.Count > 0)
                    IDsOfUsedServers.Add(i);

            }
            sw.WriteLine(IDsOfUsedServers.Count);
            for (int i = 0; i < IDsOfUsedServers.Count; i++)
            {
                //0 1 2 3 - this means server#0 got videos#1,2 and 3 on it
                sw.Write(IDsOfUsedServers[i]+" ");//first we write id of server
                for (int j = 0; j < servers[IDsOfUsedServers[j]].videosCachedOnServer.Count; j++)//than we loop throug all videos posted on it
                {
                    sw.Write(servers[IDsOfUsedServers[j]].videosCachedOnServer[j]+" ");
                }
                sw.WriteLine();
            }
            sw.Close();
        }
        static void ProcessAndChooseRequests(ref Video[] videos, ref Endpoint[] endpoints, ref Request[] requests,ref CacheServer[] cachedServers)
        {
            for (int i = 0; i < requests.Length; i++)
            {
                cachedServers[endpoints[requests[i].EndpointId].cachesAndLatency[0].Item1].AddMovie(videos[requests[i].VidId]);
            }
        }
        static void CalculateSavedTime(ref Video[] videos, ref Endpoint[] endpoints, ref Request[] requests, ref CacheServer[] cachedServers)
        {
            long timeSaved;
            int videoID;//tu bedzie trzymany id video z requesta
            int minimalLatency;
            int idOfBest;
            //dla kazdego requesta trzeba wyszukac najkrotszy czas przesylu
            for (int i = 0; i < requests.Length; i++)
            {
                videoID = requests[i].VidId;
                for (int j = 0; j < cachedServers.Length; j++)
                {

                }
            }
        }
    }
}
