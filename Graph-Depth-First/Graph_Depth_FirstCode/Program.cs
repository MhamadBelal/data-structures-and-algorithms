namespace Graph_Depth_FirstCode
{
    public class Program
    {
        static void Main(string[] args)
        {
            Graph graph = new Graph();

            graph.AddVertex("A");
            graph.AddVertex("B");
            graph.AddVertex("C");
            graph.AddVertex("D");
            graph.AddVertex("E");
            graph.AddVertex("F");
            graph.AddVertex("G");
            graph.AddVertex("H");

            graph.AddEdge("A", "B");
            graph.AddEdge("A", "D");
            graph.AddEdge("B", "C");
            graph.AddEdge("B", "D");
            graph.AddEdge("C", "G");
            graph.AddEdge("D", "E");
            graph.AddEdge("D", "H");
            graph.AddEdge("D", "F");
            graph.AddEdge("F", "H");

            List<string> traversalResult = graph.DepthFirst("A");

            Console.WriteLine("Depth-First Traversal Result: " + string.Join(", ", traversalResult));


            Console.ReadKey();
        }
    }
}