using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public Vector3 GetVector(int x, int y) => vectors[x, y];
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
        static readonly int animationFrames = 24;
        static readonly double changeOfAlpha = 2 * Math.PI / animationFrames;
        int R;
        public int step = 0;
        int xCenterOfCircle;
        int yCenterOfCircle;
        
        public MovingLight(int xCenter,int yCenter, int r)
        {
            xCenterOfCircle = xCenter;
            yCenterOfCircle = yCenter;
            R = r;
        }
        public void Update() => step = (step + 1) % animationFrames;
        
        public Vector3 GetVector(int x, int y) 
        {
            double alpha = step * changeOfAlpha;            
            return Vector3.Normalize(new Vector3((float)(xCenterOfCircle + R * Math.Cos(alpha) - x),
                    -(float)(yCenterOfCircle / 2 + R * Math.Sin(alpha) - y), 100));
        }
    }

    
}
