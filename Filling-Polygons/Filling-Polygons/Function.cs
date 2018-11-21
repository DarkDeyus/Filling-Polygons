using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Filling_Polygons
{
    class Function
    {
        double A;
        double alpha;
        double beta;
        
        
        public Function(double A, double alpha, double beta)
        {
            this.A = A;
            this.alpha = alpha;
            this.beta = beta;
        }

        // z(x,y) = A * sin(alpha * x) * cos(beta * y)
        double Z(int x, int y) => A* Math.Sin(alpha* x) * Math.Cos(beta* y);
        float xDerivativeOfZ(int x,int y) => (float)(alpha * A * Math.Cos(alpha * x) * Math.Cos(beta * y));
        float yDerivativeOfZ(int x, int y) => (float)(-A * beta * Math.Sin(alpha * x) * Math.Sin(beta * y));
        public VectorArray getNormalMap(int width, int height)
        {
            Vector3[,] vectors = new Vector3[width, height];
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    double z = Z(x, y);
                    Vector3 Zx = new Vector3(1, 0, xDerivativeOfZ(x, y));
                    Vector3 Zy = new Vector3(0, 1, yDerivativeOfZ(x, y));
                    Vector3 result = Vector3.Cross(Zx, Zy);
                    result.Z = Math.Abs(result.Z);
                    vectors[x, y] = result;
                }
            }

            return new VectorArray(vectors);
        }
    }
}
