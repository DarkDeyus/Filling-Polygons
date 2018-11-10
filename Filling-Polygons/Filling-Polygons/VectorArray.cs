using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Filling_Polygons
{
    interface IVector
    {
        Vector3 GetVector(int x, int y);
    }
    class VectorArray : IVector
    {
        readonly Vector3[,] vectors;

        public VectorArray(Vector3[,] vectors) => this.vectors = vectors;

        public Vector3 GetVector(int x, int y)
        {
            return vectors[x, y];
        }
    }

    class ConstantVector : IVector
    {
        readonly Vector3 vector;
        public ConstantVector(Vector3 v) => vector = v;

        public Vector3 GetVector(int x, int y) => vector;

    }
}
