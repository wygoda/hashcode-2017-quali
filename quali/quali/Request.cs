using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quali
{
    class Request
    {
        //id video, id endpointa i liczbe requestow
        public int VidId { get; }
        public int EndpointId { get; }
        public int ReqCount { get; }

        public Request(int vidId, int endpointId, int reqCount)
        {
            VidId = vidId;
            EndpointId = endpointId;
            ReqCount = reqCount;
        }
    }
}
