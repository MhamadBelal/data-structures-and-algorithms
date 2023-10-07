using Graph_Depth_FirstCode;

namespace Graph_Depth_FirstTest
{
    public class UnitTest1
    {
        [Fact]
        public void AddVertex_ShouldAddVertexToGraph()
        {
            // Arrange
            Graph graph = new Graph();

            // Act
            graph.AddVertex("A");
            graph.AddVertex("B");

            // Assert
            Assert.Contains("A", graph.GetVertices());
            Assert.Contains("B", graph.GetVertices());
        }

        [Fact]
        public void AddEdge_ShouldAddEdgeBetweenVertices()
        {
            // Arrange
            Graph graph = new Graph();
            graph.AddVertex("A");
            graph.AddVertex("B");

            // Act
            graph.AddEdge("A", "B");

            // Assert
            Assert.Contains("B", graph.GetNeighbors("A"));
        }

        [Fact]
        public void AddEdge_ShouldThrowException_WhenEitherVertexDoesNotExist()
        {
            // Arrange
            Graph graph = new Graph();

            // Act & Assert
            Assert.Throws<ArgumentException>(() => graph.AddEdge("A", "B"));
        }

        [Fact]
        public void DepthFirst_ShouldTraverseGraphCorrectly()
        {
            // Arrange
            Graph graph = new Graph();
            graph.AddVertex("A");
            graph.AddVertex("B");
            graph.AddVertex("C");
            graph.AddVertex("D");
            graph.AddVertex("E");
            graph.AddEdge("A", "B");
            graph.AddEdge("A", "C");
            graph.AddEdge("B", "D");
            graph.AddEdge("C", "E");

            // Act
            List<string> traversalResult = graph.DepthFirst("A");

            // Assert
            Assert.Equal(new List<string> { "A", "B", "D", "C", "E" }, traversalResult);
        }
    }
}