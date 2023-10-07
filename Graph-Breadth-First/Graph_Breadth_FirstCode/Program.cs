namespace Graph_Breadth_FirstCode
{
    public class Program
    {
        static void Main(string[] args)
        {
            Graph graph = new Graph();
            Node nodeA = new Node("Pandora");
            Node nodeB = new Node("Arendelle");
            Node nodeC = new Node("Metroville");
            Node nodeD = new Node("Monstroplolis");
            Node nodeE = new Node("Narnia");
            Node nodeF = new Node("Naboo");

            graph.AddNode("Pandora");
            graph.AddNode("Arendelle");
            graph.AddNode("Metroville");
            graph.AddNode("Monstroplolis");
            graph.AddNode("Narnia");
            graph.AddNode("Naboo");

            graph.AddEdge(nodeA, nodeB);
            graph.AddEdge(nodeB, nodeC);
            graph.AddEdge(nodeB, nodeD);
            graph.AddEdge(nodeC, nodeE);
            graph.AddEdge(nodeC, nodeF);
            graph.AddEdge(nodeD, nodeE);
            graph.AddEdge(nodeD, nodeF);

            // Test 1: Breadth-first traversal starting from nodeA
            List<Node> result = graph.BreadthFirst(nodeA);
            graph.DisplayCollection(result); // Output: A -> B -> C -> D -> E -> F

            Console.ReadKey();
        }
    }
}