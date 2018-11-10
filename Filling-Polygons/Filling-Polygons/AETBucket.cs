using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filling_Polygons
{
    class AETBucket
    {
        List<AET> bucket;
        public int Count => bucket.Count;
        public AETBucket() => bucket = new List<AET>();
        
        public bool Add(Vertex start, Vertex end)
        {
            AET aet = new AET(start, end);
            AET a = new AET(end, start);

            if ((bucket.Contains(aet) || bucket.Contains(a)))
                return false;
            else
            {
                bucket.Add(aet);
                return true;
            }
        }

        public void Remove(Vertex start, Vertex end) => bucket.RemoveAll(a => (a.start == start && a.end == end || a.start == end && a.end == start));
        public void Sort()
        {
            bucket = bucket.OrderBy(a => a.x).ToList();
        }
        public AET this[int index]
        {
            get { return bucket[index]; }
            set { bucket[index] = value; }
        }
    }
}
