using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dijkstra
{
    public class GraphPointData
    {
        public double PathLength { get; set; }
        public List<int> Path { get; set; }

        public GraphPointData(double pathLength, List<int> path)
        {
            PathLength = pathLength;
            Path = path;
        }
    }
}
