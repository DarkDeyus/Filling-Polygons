using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Filling_Polygons
{
    public interface IVector
    {
        Vector3 GetVector(int x, int y);
        void Update();
    }
    class VectorArray : IVector
    {
        readonly Vector3[,] vectors;

        public VectorArray(Vector3[,] vectors) => this.vectors = vectors;

        public Vector3 GetVector(int x, int y)
        {
            return vectors[x, y];
        }

        public void Update() { }

    }

    class ConstantVector : IVector
    {
        readonly Vector3 vector;
        public ConstantVector(Vector3 v) => vector = v;
        public Vector3 GetVector(int x, int y) => vector;
        public void Update() { }
    }

    
    class MovingLight : IVector
    {
        static int animationFrames = 24;
        static readonly double changeOfAlpha = 2 * Math.PI / animationFrames;
        int R;
        int step = 0;
        int xCenterOfCircle;
        int yCenterOfCircle;

        
        public MovingLight(int xCenter,int yCenter, int r)
        {
            xCenterOfCircle = xCenter;
            yCenterOfCircle = yCenter;
            R = r;
        }
        public void Update()
        {
            step = (step + 1) % animationFrames;
        }
        
        public Vector3 GetVector(int x, int y) 
        {
            double alpha = step * changeOfAlpha;            
            return Vector3.Normalize(new Vector3((float)(xCenterOfCircle + R * Math.Cos(alpha) - x),
                    -(float)(yCenterOfCircle / 2 + R * Math.Sin(alpha) - y), 100));
        }
    }

    class Reflector
    {
        int m = 200;
        int height = 10;
        Color Color;
        int Xmiddlescreen;
        int Ymiddlescreen;
        int X;
        int Y;
        public Reflector(int xmiddlescreen, int ymiddlescreen, int reflectorX, int reflectorY, Color color)
        {
            Xmiddlescreen = xmiddlescreen;
            Ymiddlescreen = ymiddlescreen;
            X = reflectorX;
            Y = reflectorY;
            Color = color;           
        }

        public Vector3 GetVectorToReflector(int x, int y)
        {
            return Vector3.Normalize(new Vector3(X - x, Y - y, height));
        }
        public Vector3 GetReflectorColor(int x, int y)
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
    }
}
