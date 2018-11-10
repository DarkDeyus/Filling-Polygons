using Filling_Polygons.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PixelMapSharp;
using System.Numerics;
namespace Filling_Polygons
{
    class Polygon
    {
        List<Vertex> vertices;
        readonly int vertexSize = 10;
        readonly int leeway = 10;
        public Color objectColor = Color.Green;       
        public PixelMap objectTexture = new PixelMap(Resources.normalmap);
        public bool color = true;
        public Polygon(List<Vertex> list) => vertices = list;                   
        public int VerticesCount() => vertices.Count;
        public void Paint(PaintEventArgs e)
        {           
            Scanline(e);
            for (int i = 0; i < vertices.Count; i++)
            {
                e.Graphics.DrawLine(Pens.Black, vertices[i].ToPoint(), vertices[(i + 1) % vertices.Count].ToPoint());
                Rectangle rect = new Rectangle(vertices[i].X - vertexSize / 2, vertices[i].Y - vertexSize / 2, vertexSize, vertexSize);
                e.Graphics.DrawEllipse(Pens.Black, rect);
                e.Graphics.FillEllipse(Brushes.Black, rect);               
            }
            
        }
        public void UpdateColor(Color color) => objectColor = color;
        public void UpdateTexture(Bitmap texture) => objectTexture =  new PixelMap(texture);
        public (bool, Vertex) GetVertex(Point location)
        {
            foreach (Vertex vertex in vertices)
                    if (Math.Pow((vertex.X - location.X), 2) +
                        Math.Pow((vertex.Y - location.Y), 2) <= Math.Pow(leeway, 2))
                        return (true, vertex);

            return (false, null);
        }
        public void movePolygon(int X, int Y)
        {
            for (int i = 0; i < vertices.Count; i++)
            {
                vertices[i].X += X;
                vertices[i].Y += Y;
            }
        }
        //TODO: remake it into point in polygon
        public bool PointInTriangle(Vertex pt)
        {
            double Sign(Vertex p1, Vertex p2, Vertex p3) => (p1.X - p3.X) * (p2.Y - p3.Y) - (p2.X - p3.X) * (p1.Y - p3.Y);   

            double d1, d2, d3;
            bool has_neg, has_pos;
            Vertex v1 = vertices[0];
            Vertex v2 = vertices[1];
            Vertex v3 = vertices[2];

            d1 = Sign(pt, v1, v2);
            d2 = Sign(pt, v2, v3);
            d3 = Sign(pt, v3, v1);

            has_neg = (d1 < 0) || (d2 < 0) || (d3 < 0);
            has_pos = (d1 > 0) || (d2 > 0) || (d3 > 0);

            return !(has_neg && has_pos);
        }

        Color GetColor(int X, int Y)
        {
            return color ? objectColor : objectTexture[X, Y].Color;
        }
        void Scanline(PaintEventArgs e)
        {
            Pen pen = new Pen(objectColor);
            int[] indexes = Enumerable.Range(0, vertices.Count).OrderBy(i => vertices[i].Y).ToArray();
            int ymin = vertices[indexes[0]].Y;
            int ymax = vertices[indexes[vertices.Count - 1]].Y;
            AETBucket bucket = new AETBucket();
            int k = 0;
            for(int y = ymin + 1; y <= ymax; y++)

            {
                while(vertices[indexes[k]].Y == y - 1)
                {                   
                    Vertex prev = vertices[(indexes[k] - 1 + vertices.Count()) % vertices.Count];
                    if(prev.Y > vertices[indexes[k]].Y)
                    {
                        bucket.Add(vertices[indexes[k]], prev);
                    }
                    else
                    {
                        bucket.Remove(vertices[indexes[k]], prev);
                    }

                    Vertex next = vertices[(indexes[k] + 1) % vertices.Count];
                    if (next.Y > vertices[indexes[k]].Y)
                    {
                        bucket.Add(vertices[indexes[k]], next);

                    }
                    else
                    {
                        bucket.Remove(vertices[indexes[k]], next);
                    }
                    k++;
                    
                }
                bucket.Sort();
                for(int i = 0; i< bucket.Count; i+= 2)
                {                    
                    float x1 = bucket[i].x;
                    float x2 = bucket[i + 1].x;
                    for( int x = (int)x1; x <= (int)x2; x++)
                    {
                        pen.Color = (GetColor(x, y - 1));
                        e.Graphics.DrawRectangle(pen, x, y - 1, 1, 1);
                    }
                    bucket[i].x += bucket[i].inverseOfM;
                    bucket[i + 1].x += bucket[i + 1].inverseOfM;
                }              
                    
            }

        }
    }
}
