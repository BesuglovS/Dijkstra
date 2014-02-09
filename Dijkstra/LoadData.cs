using System.Collections.Generic;
using System.IO;

namespace Dijkstra
{
    public static class LoadData
    {
        public static GraphData Run(string filename)
        {
            var sr = new StreamReader(filename);

            var rank = int.Parse(sr.ReadLine());                        

            var edges = new List<Edge>();
            
            string line;
            while((line = sr.ReadLine()) != null)
            {
                var edge = line.Split(' ');

                var edgeStart = int.Parse(edge[0]);
                var edgeEnd = int.Parse(edge[1]);
                var edgeWeight = double.Parse(edge[2]);

                edges.Add(new Edge(edgeStart, edgeEnd, edgeWeight));
            }
            sr.Close();

            return new GraphData(rank, edges);
        }
    }
}
