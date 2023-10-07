using Graph_Breadth_FirstCode;

namespace Graph_Breadth_FirstTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestBreadthFirstTraversalStartingFromNodeA()
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

            List<Node> result = graph.BreadthFirst(nodeA);

            Assert.Equal(6, result.Count); // There should be 6 nodes in the result.
            Assert.Equal("Pandora", result[0].Value); // First node should be Pandora.
            Assert.Equal("Arendelle", result[1].Value); // Second node should be Arendelle.
            Assert.Equal("Metroville", result[2].Value); // Third node should be Metroville.
            Assert.Equal("Monstroplolis", result[3].Value); // Fourth node should be Monstroplolis.
            Assert.Equal("Narnia", result[4].Value); // Fifth node should be Narnia.
            Assert.Equal("Naboo", result[5].Value); // Sixth node should be Naboo.
        }

        [Fact]
        public void TestEmptyGraph()
        {
            Graph graph = new Graph();
            Node nodeA = new Node("Pandora");

            List<Node> result = graph.BreadthFirst(nodeA);

            Assert.Single(result); // There should be only one node in the result, which is the start node.
            Assert.Equal("Pandora", result[0].Value);
        }

        [Fact]
        public void TestGraphWithSingleNode()
        {
            Graph graph = new Graph();
            Node nodeA = new Node("Pandora");

            graph.AddNode("Pandora");

            List<Node> result = graph.BreadthFirst(nodeA);

            Assert.Single(result); // There should be only one node in the result, which is the start node.
            Assert.Equal("Pandora", result[0].Value);
        }

        [Fact]
        public void TestDisconnectedGraph()
        {
            Graph graph = new Graph();
            Node nodeA = new Node("Pandora");
            Node nodeB = new Node("Arendelle");

            graph.AddNode("Pandora");
            graph.AddNode("Arendelle");

            List<Node> result = graph.BreadthFirst(nodeA);

            Assert.Single(result); // There should be only one node in the result, which is the start node.
            Assert.Equal("Pandora", result[0].Value);
        }
    }
}