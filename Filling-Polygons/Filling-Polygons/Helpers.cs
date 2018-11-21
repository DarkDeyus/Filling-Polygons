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
        static public Vector3[,] GetNormalVectorArray(PixelMapSharp.PixelMap bitmap)
        {
            Vector3[,] vectors = new Vector3[bitmap.Width, bitmap.Height];
            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    vectors[x, y] = GetNVector(bitmap[x, y]);                    
                }
            }
            return vectors;
        }       
        static public Vector3[,] GetDistortionVectorArray(PixelMapSharp.PixelMap bitmap, IVector vector)
        {
            Vector3[,] vectors = new Vector3[bitmap.Width, bitmap.Height];
            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {                  
                    Vector3 T = new Vector3(1, 0, -vector.GetVector(x,y).X);
                    Vector3 B = new Vector3(0, 1, -vector.GetVector(x,y).Y);
                    int dhx = VectorToGreyscale(bitmap[(x + 1) % bitmap.Width, y]) - VectorToGreyscale(bitmap[x, y]);
                    int dhy = VectorToGreyscale(bitmap[x, (y + 1) % bitmap.Height]) - VectorToGreyscale(bitmap[x, y]);
                    vectors[x, y] = T * dhx /32 + B* dhy /32;
                }
            }
            return vectors;
        }
        public static Vector3 GetVector(Color c) => new Vector3(c.R / 255f, c.G / 255f, c.B / 255f);

        static int VectorToGreyscale(PixelMapSharp.Pixel pixel) => (int)Math.Round(0.21 * pixel.R + 0.72 * pixel.G + 0.07 * pixel.B);       
        static Vector3 NVectorFromRGB(int R, int G, int B)
        {
            // to <-1, 1>
            float x = (float)(2 * R) / 255 - 1;
            // to <-1, 1>
            float y = (float)(2 * G) / 255 - 1;
            // to <0, 1>
            float z = (float) B / 255;
            return new Vector3(x, y, z);
        }
        static public Vector3 GetNVector(Color color) => NVectorFromRGB(color.R, color.G, color.B);
        static public Vector3 GetNVector(PixelMapSharp.Pixel pixel ) => NVectorFromRGB(pixel.R, pixel.G, pixel.B);
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
                vector = Vector3.Normalize(vector);
            }
            return vector;
        }
        static public Color GetColorFromVector(Vector3 vector)
        {
            int R = Math.Max(Math.Min((int)(vector.X * 255), 255), 0);
            int G = Math.Max(Math.Min((int)(vector.Y * 255), 255), 0);
            int B = Math.Max(Math.Min((int)(vector.Z * 255), 255), 0);
            return Color.FromArgb(R, G, B);
        }
        
    }
}
