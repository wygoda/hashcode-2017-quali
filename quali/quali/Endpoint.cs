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
        int LatencyToDataCenter;
        //tablica krotet z id podpietych cache i opoznien do nich
        Tuple<int, int>[] CacheLatencyTuple;
    }
}
