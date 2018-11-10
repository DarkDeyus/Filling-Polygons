using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filling_Polygons
{
    class AET
    {
        public Vertex start { get; }
        public Vertex end { get; }
        public float x { get; set; }
        public float inverseOfM { get; }

        public AET(Vertex v1, Vertex v2)
        {
            start = v1;
            end = v2;
            x = v1.X;
            float y = (v1.Y - v2.Y); 
            inverseOfM = (y == 0 ? 0 : (v1.X - v2.X) / y);            
        }      
    }
}
