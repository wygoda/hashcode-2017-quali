using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quali
{
    class Video
    {
        //id filmu i jego rozmiar
        public int Id { get; }
        public int Size { get; }

        public Video(int id, int size)
        {
            Id = id;
            Size = size;
        }
    }
}
