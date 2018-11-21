using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Filling_Polygons
{
    class Reflector
    {
        Vector3[,] reflectorColor;
        int m = 200;
        int height = 10;
        Color Color;
        int Xmiddlescreen;
        int Ymiddlescreen;
        int X;
        int Y;
        public Reflector(int xmiddlescreen, int ymiddlescreen, int reflectorX, int reflectorY, Color color, int width, int height)
        {
            Xmiddlescreen = xmiddlescreen;
            Ymiddlescreen = ymiddlescreen;
            X = reflectorX;
            Y = reflectorY;
            Color = color;
            reflectorColor = new Vector3[width, height];
            for (int x = 0; x < width; x++)
                for (int y = 0; y < height; y++)
                    reflectorColor[x, y] = SetReflectorColor(x, y);
        }

        public Vector3 GetVectorToReflector(int x, int y) => Vector3.Normalize(new Vector3(X - x, Y - y, height));

        public Vector3 SetReflectorColor(int x, int y)
        {
            Vector3 ReflectorVector = Vector3.Normalize(new Vector3(Xmiddlescreen - X, Ymiddlescreen - Y, -height));
            Vector3 PointVector = Vector3.Normalize(new Vector3(x - X, y - Y, -height));

            double cosine = Vector3.Dot(ReflectorVector, PointVector);
            if (cosine < 0)
                cosine = 0;

            double intensity = Math.Pow(cosine, m);

            Color c = Color.FromArgb((int)(Color.R * intensity), (int)(Color.G * intensity), (int)(Color.B * intensity));
            return Helpers.GetVector(c);
        }
        public Vector3 GetReflectorColor(int x, int y) => reflectorColor[x, y];

    }
}
