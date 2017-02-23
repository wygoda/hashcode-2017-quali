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
            StreamWriter sw = new StreamWriter(string.Format(args[0] + "_output"));
            sw.WriteLine(cachedServers.Length);
            for (int i = 0; i < cachedServers.Length; i++)
            {
                for (int j = 0; j <= cachedServers[i].videosCachedOnServer.Count; j++)
                {
                    if (cachedServers[i].videosCachedOnServer.Count==0)
                    {
                        sw.WriteLine(i + " 0");
                        break;
                    }
                    sw.Write(cachedServers[i].videosCachedOnServer[j]);
                }
                sw.Write("\n");
            }
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
    }
}
