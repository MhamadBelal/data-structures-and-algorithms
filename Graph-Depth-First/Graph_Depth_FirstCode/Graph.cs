using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph_Depth_FirstCode
{
    public class Graph
    {
        private Dictionary<string, List<string>> adjacencyList;

        public Graph()
        {
            adjacencyList = new Dictionary<string, List<string>>();
        }

        // Add a vertex to the graph
        public void AddVertex(string vertex)
        {
            if (!adjacencyList.ContainsKey(vertex))
            {
                adjacencyList[vertex] = new List<string>();
            }
        }

        // Add an edge between two vertices
        public void AddEdge(string from, string to)
        {
            if (!adjacencyList.ContainsKey(from) || !adjacencyList.ContainsKey(to))
            {
                throw new ArgumentException("Both vertices must exist in the graph.");
            }

            adjacencyList[from].Add(to);
        }


        public List<string> GetVertices()
        {
            List<string> vertices = new List<string>(adjacencyList.Keys);
            return vertices;
        }

        // Get neighbors of a vertex
        public List<string> GetNeighbors(string vertex)
        {
            if (!adjacencyList.ContainsKey(vertex))
            {
                throw new ArgumentException("Vertex not found in the graph.");
            }

            List<string> neighbors = adjacencyList[vertex];
            return neighbors;
        }

        // Depth First Traversal
        public List<string> DepthFirst(string startNode)
        {
            List<string> result = new List<string>();
            HashSet<string> visited = new HashSet<string>();

            void DFS(string node)
            {
                if (!visited.Contains(node))
                {
                    visited.Add(node);
                    result.Add(node);

                    foreach (var neighbor in adjacencyList[node])
                    {
                        DFS(neighbor);
                    }
                }
            }

            DFS(startNode);
            return result;
        }
    }
}
