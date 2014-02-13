using System.Collections.Generic;

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
