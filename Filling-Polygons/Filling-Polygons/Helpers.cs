using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Filling_Polygons
{
    static class Helpers
    {
        static public Vector3[,] VectorArrayFromBitmap(PixelMapSharp.PixelMap bitmap)
        {
            Vector3[,] vectors = new Vector3[bitmap.Width, bitmap.Height];
            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    vectors[x, y] = GetVector(bitmap[x, y]);
                }
            }
            return vectors;
        }

        static public Vector3[,] VectorDistortionFromBitmap(PixelMapSharp.PixelMap bitmap, IVector vector)
        {
            Vector3[,] vectors = new Vector3[bitmap.Width, bitmap.Height];
            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    //int color = VectorToGreyscale(bitmap[x, y]);
                    Vector3 T = new Vector3(1, 0, -vector.GetVector(x,y).X);
                    Vector3 B = new Vector3(0, 1, -vector.GetVector(x,y).Y);
                    int dhx = VectorToGreyscale(bitmap[(x + 1) % bitmap.Width, y]) - VectorToGreyscale(bitmap[x, y]);
                    int dhy = VectorToGreyscale(bitmap[x, (y + 1) % bitmap.Height]) - VectorToGreyscale(bitmap[x, y]);
                    vectors[x, y] = T * dhx /64 + B* dhy /64;
                }
            }
            return vectors;
        }
        static public float Cos(Vector3 v1, Vector3 v2)
        {
            return v1.X * v2.X + v1.Y * v2.Y + v1.Z * v2.Z;
        }
        static int VectorToGreyscale(PixelMapSharp.Pixel pixel)
        {
            return (int)Math.Round(0.21 * pixel.R + 0.72 * pixel.G + 0.07 * pixel.B);
        }
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
