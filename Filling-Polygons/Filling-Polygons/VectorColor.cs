using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Filling_Polygons
{
    static class Vector
    {
        static Vector3 VectorFromRGB(int R, int G, int B)
        {
            // to <-1, 1>
            float x = (float)(2 * R) / 255 - 1;
            // to <-1, 1>
            float y = (float)(2 * G) / 255 - 1;
            // to <0, 1>
            float z = (float) B / 255;
            return new Vector3(x, y, z);
        }
        static public Vector3 GetVector(Color color)
        {
            return VectorFromRGB(color.R, color.G, color.B);
        }
        static public Vector3 GetVector(PixelMapSharp.Pixel pixel )
        {
            return VectorFromRGB(pixel.R, pixel.G, pixel.B);
        }
        static public Vector3 NormalizeVector(Vector3 vector)
        {
            if (vector.Z != 0)
            {
                vector.X /= vector.Z;
                vector.Y /= vector.Z;
                //vector.Z / vector.Z = 1 
                vector.Z = 1;
            }
            else
            {
                vector = ToUnitVector(vector);
            }
            return vector;
        }
        static public Vector3 ToUnitVector(Vector3 vector)
        {
            float length = vector.Length();
            vector.X /= length;
            vector.Y /= length;
            vector.Z /= length;
            return vector;
        }
        static public Color GetColorFromVector(Vector3 vector)
        {
            int R = (int)((vector.X + 1) * 255 / 2);
            int G = (int)((vector.Y + 1) * 255 / 2);
            int B = (int)(vector.Z * 255);
            return Color.FromArgb(R, G, B);
        }
    }
}
