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
        #region Variables
        List<Vertex> vertices;
        readonly int vertexSize = 10;
        readonly int leeway = 10;
        public Color Color = Color.Green;
        public PixelMap Texture = new PixelMap(Resources.normalmap);
        IVector texture;
        IVector objectFilling;     
        Color[,] paint;
        public bool color = true;
        #endregion

        public Polygon(List<Vertex> list) => vertices = list;                   
        public int VerticesCount() => vertices.Count;
        public void Paint(PaintEventArgs e, DirectBitmap bitmap)
        {                      
            Scanline(bitmap);                       
        }
        public void PaintVertices(PaintEventArgs e)
        {
            for (int i = 0; i < vertices.Count; i++)
            {
                e.Graphics.DrawLine(Pens.Black, vertices[i].ToPoint(), vertices[(i + 1) % vertices.Count].ToPoint());
                Rectangle rect = new Rectangle(vertices[i].X - vertexSize / 2, vertices[i].Y - vertexSize / 2, vertexSize, vertexSize);
                e.Graphics.DrawEllipse(Pens.Black, rect);
                e.Graphics.FillEllipse(Brushes.Black, rect);
            }
        }
        public void CalculateColor(Color lightColor, IVector vector, IVector distortion, IVector lightVector, List<Reflector> reflectors, int width, int height )
        {
            objectFilling = color ? new ConstantVector(Helpers.GetVector(Color)) : texture; 
            Vector3 colorVector = Helpers.GetVector(lightColor);           
            Color[,] map = new Color[width, height];
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {                   
                    Vector3 N = Helpers.NormalizeVector((vector.GetVector(x, y) + distortion.GetVector(x, y)));
                    Vector3 v = colorVector * objectFilling.GetVector(x, y);
                    float cos = Math.Max(Vector3.Dot(N, lightVector.GetVector(x, y)), 0);
                    Vector3 reflector = new Vector3(0, 0, 0);

                    foreach (Reflector light in reflectors)
                    {
                        reflector += light.GetReflectorColor(x, y) * objectFilling.GetVector(x, y) * Math.Max(Vector3.Dot(N, light.GetVectorToReflector(x, y)), 0);
                    }
                    map[x,y] = Helpers.GetColorFromVector( new Vector3(v.X * cos, v.Y * cos, v.Z * cos) + reflector);
                }
            }
            paint = map;
        }
        public void UpdateColor(Color color) => Color = color;       
        public void UpdateTexture(Bitmap texture)
        {
           Texture = new PixelMap(texture);
           this.texture = new VectorArray(Helpers.GetNormalVectorArray(Texture));
        }
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
            try
            {
                Color color = paint[X, Y];
            }
            catch 
            {
                return Color.White;
            }
            return paint[X, Y];
        }
        void Scanline(DirectBitmap bitmap)
        {
            Pen pen = new Pen(Color);
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
                    Parallel.For((int)x1, (int)x2 + 1, x =>{
                      if (x >= 0 && x < bitmap.Width && y > 0 && y<= bitmap.Height) bitmap.SetPixel(x, y - 1, GetColor(x, y - 1));
                  });
                   
                    bucket[i].x += bucket[i].inverseOfM;
                    bucket[i + 1].x += bucket[i + 1].inverseOfM;
                }              
                    
            }

        }
    }
}
