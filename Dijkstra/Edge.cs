using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dijkstra
{
    public class Edge
    {
        public int EdgeStart { get; set; }
        public int EdgeEnd { get; set; }
        public double EdgeWeight { get; set; }

        public Edge(int edgeStart, int edgeEnd, double edgeWeight)
        {
            EdgeStart = edgeStart;
            EdgeEnd = edgeEnd;
            EdgeWeight = edgeWeight;
        }
    }
}
