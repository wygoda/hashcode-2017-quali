using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quali
{
    class Endpoint
    {
        //opoznienie do datacenter
        public int LatencyToDatacenter { get; }

        //tablica krotek z id podpietych cache i opoznien do nich
        public Tuple<int, int>[] cachesAndLatency;

        public Endpoint(int ld, int cachesCount)
        {
            LatencyToDatacenter = ld;
            cachesAndLatency = new Tuple<int, int>[cachesCount];
        }
    }
}
