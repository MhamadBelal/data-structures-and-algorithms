namespace Graph
{
    public class UnitTest1
    {
        [Fact]
        public void CanAddVertexToGraph()
        {
            var graph = new GraphCode.Graph();
            var vertexA = graph.AddVertex("A");

            Assert.NotNull(vertexA);
            Assert.Equal("A", vertexA.Value);
        }

        [Fact]
        public void CanAddEdgeToGraph()
        {
            var graph = new GraphCode.Graph();
            var vertexA = graph.AddVertex("A");
            var vertexB = graph.AddVertex("B");

            graph.AddEdge(vertexA, vertexB, 2);

            Assert.Contains(vertexB, vertexA.Edges.Keys);
            Assert.Contains(vertexA, vertexB.Edges.Keys);
        }

        [Fact]
        public void CanRetrieveAllVerticesFromGraph()
        {
            var graph = new GraphCode.Graph();
            graph.AddVertex("A");
            graph.AddVertex("B");
            graph.AddVertex("C");

            var vertices = graph.GetVertices();

            Assert.Contains("A", vertices);
            Assert.Contains("B", vertices);
            Assert.Contains("C", vertices);
        }

        [Fact]
        public void CanRetrieveNeighborsFromGraph()
        {
            var graph = new GraphCode.Graph();
            var vertexA = graph.AddVertex("A");
            var vertexB = graph.AddVertex("B");
            var vertexC = graph.AddVertex("C");
            graph.AddEdge(vertexA, vertexB, 2);
            graph.AddEdge(vertexB, vertexC, 3);

            var neighborsA = graph.GetNeighbors("A");
            var neighborsB = graph.GetNeighbors("B");

            Assert.Contains(new Tuple<string, int>("B", 2), neighborsA);
            Assert.Contains(new Tuple<string, int>("A", 2), neighborsB);
            Assert.Contains(new Tuple<string, int>("C", 3), neighborsB);
        }

        [Fact]
        public void CanRetrieveSizeOfGraph()
        {
            var graph = new GraphCode.Graph();
            graph.AddVertex("A");
            graph.AddVertex("B");
            graph.AddVertex("C");

            var size = graph.Size();

            Assert.Equal(3, size);
        }

        [Fact]
        public void CanReturnGraphWithOneVertexAndEdge()
        {
            var graph = new GraphCode.Graph();
            var vertexA = graph.AddVertex("A");
            graph.AddEdge(vertexA, vertexA, 1);

            var vertices = graph.GetVertices();
            var neighborsA = graph.GetNeighbors("A");
            var size = graph.Size();

            Assert.Single(vertices);
            Assert.Contains(new Tuple<string, int>("A", 1), neighborsA);
            Assert.Equal(1, size);
        }
    }
}