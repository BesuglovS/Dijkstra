using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra
{
    public class GraphData
    {
        public int Rank { get; set; }
        public List<Edge> Edges { get; set; }

        public GraphData(int rank, List<Edge> edges)
        {
            Rank = rank;
            Edges = edges;
        }
    }
}
