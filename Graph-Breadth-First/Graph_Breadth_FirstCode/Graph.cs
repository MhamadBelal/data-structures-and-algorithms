using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph_Breadth_FirstCode
{
    public class Graph
    {
        private List<Node> nodes;

        public Graph()
        {
            nodes = new List<Node>();
        }

        public void AddNode(string value)
        {
            nodes.Add(new Node(value));
        }

        public void AddEdge(Node node1, Node node2)
        {
            node1.Neighbors.Add(node2);
            node2.Neighbors.Add(node1);
        }

        public List<Node> BreadthFirst(Node startNode)
        {
            List<Node> result = new List<Node>();
            HashSet<Node> visited = new HashSet<Node>();
            Queue<Node> queue = new Queue<Node>();

            if (startNode != null)
            {
                queue.Enqueue(startNode);
                visited.Add(startNode);
            }

            while (queue.Count > 0)
            {
                Node currentNode = queue.Dequeue();
                result.Add(currentNode);

                foreach (Node neighbor in currentNode.Neighbors)
                {
                    if (!visited.Contains(neighbor))
                    {
                        queue.Enqueue(neighbor);
                        visited.Add(neighbor);
                    }
                }
            }

            return result;
        }

        public void DisplayCollection(List<Node> collection)
        {
            Console.WriteLine("Breadth-first traversal result:");
            Console.WriteLine(string.Join(" -> ", collection.Select(node => node.Value)));
        }
    }
}
