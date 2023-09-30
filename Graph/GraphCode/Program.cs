namespace GraphCode
{
    public class Vertex
    {
        public string Value { get; }
        public Dictionary<Vertex, int> Edges { get; } = new Dictionary<Vertex, int>();

        public Vertex(string value)
        {
            Value = value;
        }
    }

    public class Graph
    {
        private readonly Dictionary<string, Vertex> vertices = new Dictionary<string, Vertex>();

        public Vertex AddVertex(string value)
        {
            if (!vertices.ContainsKey(value))
            {
                var vertex = new Vertex(value);
                vertices[value] = vertex;
                return vertex;
            }
            return null; // Vertex with the same value already exists.
        }

        public void AddEdge(Vertex vertex1, Vertex vertex2, int weight = 0)
        {
            if (vertices.ContainsValue(vertex1) && vertices.ContainsValue(vertex2))
            {
                vertex1.Edges[vertex2] = weight;
                vertex2.Edges[vertex1] = weight;
            }
        }

        public List<string> GetVertices()
        {
            return new List<string>(vertices.Keys);
        }

        public List<Tuple<string, int>> GetNeighbors(string vertexValue)
        {
            if (vertices.ContainsKey(vertexValue))
            {
                var vertex = vertices[vertexValue];
                var neighbors = new List<Tuple<string, int>>();
                foreach (var neighbor in vertex.Edges)
                {
                    neighbors.Add(new Tuple<string, int>(neighbor.Key.Value, neighbor.Value));
                }
                return neighbors;
            }
            return new List<Tuple<string, int>>();
        }

        public int Size()
        {
            return vertices.Count;
        }
    }

    class Program
    {
        static void Main()
        {
            var graph = new Graph();
            var vertexA = graph.AddVertex("A");
            var vertexB = graph.AddVertex("B");
            var vertexC = graph.AddVertex("C");

            graph.AddEdge(vertexA, vertexB, 2);
            graph.AddEdge(vertexB, vertexC, 3);
            graph.AddEdge(vertexA, vertexC, 1);

            Console.WriteLine("Vertices: " + string.Join(", ", graph.GetVertices()));
            Console.WriteLine("Neighbors of A: " + string.Join(", ", graph.GetNeighbors("A")));
            Console.WriteLine("Size: " + graph.Size());

            Console.ReadKey();
        }
    }
}