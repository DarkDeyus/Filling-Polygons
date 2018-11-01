using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filling_Polygons
{
    class Triangle
    {
        List<Point> vertices;
        

        int vertexSize = 10; 
        public Triangle(Point v1 , Point v2, Point v3) => vertices = new List<Point>() { v1, v2, v3 };

        public void Paint(PaintEventArgs e)
        {
            for(int i=0; i< vertices.Count; i++)
            {
                e.Graphics.DrawLine(Pens.Black, vertices[i], vertices[(i + 1) % vertices.Count]);
                Rectangle rect = new Rectangle(vertices[i].X - vertexSize / 2, vertices[i].Y - vertexSize / 2, vertexSize, vertexSize);
                e.Graphics.DrawEllipse(Pens.Black, rect);
                e.Graphics.FillEllipse(Brushes.Black, rect);

            }
            //Rectangle v1 = new Rectangle(firstVertex.X - vertexSize / 2, firstVertex.Y - vertexSize / 2, vertexSize, vertexSize);
            //Rectangle v2 = new Rectangle(secondVertex.X - vertexSize / 2, secondVertex.Y - vertexSize / 2, vertexSize, vertexSize);
            //Rectangle v3 = new Rectangle(thirdVertex.X - vertexSize / 2, thirdVertex.Y - vertexSize / 2, vertexSize, vertexSize);

            //e.Graphics.DrawLine(Pens.Black, firstVertex, secondVertex);
            //e.Graphics.DrawLine(Pens.Black, secondVertex, thirdVertex);
            //e.Graphics.DrawLine(Pens.Black, thirdVertex, firstVertex);

            //e.Graphics.DrawEllipse(Pens.Black, v1);
            //e.Graphics.FillEllipse(Brushes.Black, v1);
            //e.Graphics.DrawEllipse(Pens.Black, v2);
            //e.Graphics.FillEllipse(Brushes.Black, v2);
            //e.Graphics.DrawEllipse(Pens.Black, v3);
            //e.Graphics.FillEllipse(Brushes.Black, v3);

        }
    }
}
