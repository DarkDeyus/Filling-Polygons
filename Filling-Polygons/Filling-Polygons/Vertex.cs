using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filling_Polygons
{
    class Vertex
    {
        public int X;
        public int Y;

        public Vertex(int x, int y)
        {
            X = x;
            Y = y;
        }
        public Point ToPoint() => new Point(X, Y); 
    }
}
