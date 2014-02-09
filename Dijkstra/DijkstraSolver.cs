using System.Collections.Generic;
using System.Linq;

namespace Dijkstra
{
    public static class DijkstraSolver
    {
        public static GraphPointData Run(GraphData graphData, int pathStart, int pathFinish)
        {
            var rank = graphData.Rank;

            var unvisited = Enumerable.Range(0, rank).ToList();

            var GraphPointsData = new Dictionary<int, GraphPointData>();
            for (int i = 0; i < rank; i++)
            {
                GraphPointsData.Add(i, new GraphPointData(double.MaxValue, null));
            }
            GraphPointsData[pathStart] = new GraphPointData(0.0, new List<int>() { pathStart });

            while(unvisited.Any())
            {
                var minValue = GraphPointsData
                    .Where(p => unvisited.Contains(p.Key))
                    .Select(p => p.Value.PathLength)
                    .Min();
                
                var startingPoint = GraphPointsData
                    .First(p => unvisited.Contains(p.Key) && p.Value.PathLength == minValue)
                    .Key;

                foreach (var edge in graphData.Edges.Where(edge => edge.EdgeStart == startingPoint))
                {                    
                    var newPathLength = GraphPointsData[startingPoint].PathLength + edge.EdgeWeight;
                    if (newPathLength < GraphPointsData[edge.EdgeEnd].PathLength)
                    {
                        var newPath = new List<int>(GraphPointsData[startingPoint].Path);
                        newPath.Add(edge.EdgeEnd);

                        GraphPointsData[edge.EdgeEnd] = new GraphPointData(newPathLength, newPath);                            
                    }                    
                }

                unvisited.Remove(startingPoint);
            }            

            return GraphPointsData[pathFinish];
        }
    }
}
