using tree_fizz_buzzCode;

namespace tree_fizz_buzzTests
{
    public class UnitTest1
    {
        private KaryTreeNode CreateSampleTree()
        {
            var rootNode = new KaryTreeNode("15");
            var node1 = new KaryTreeNode("6");
            var node2 = new KaryTreeNode("10");
            var node3 = new KaryTreeNode("3");
            var node4 = new KaryTreeNode("9");
            var node5 = new KaryTreeNode("5");
            var node6 = new KaryTreeNode("5");

            rootNode.Children.Add(node1);
            rootNode.Children.Add(node2);
            rootNode.Children.Add(node3);

            node1.Children.Add(node4);
            node2.Children.Add(node5);
            node3.Children.Add(node6);

            return rootNode;
        }

        [Fact]
        public void FizzBuzzTreeTransform_ShouldReturnNull_WhenInputTreeIsNull()
        {
            // Arrange
            var fizzBuzzTree = new FizzBuzzTree();

            // Act
            var result = fizzBuzzTree.FizzBuzzTreeTransform(null);

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public void FizzBuzzTreeTransform_ShouldTransformTree_WhenInputTreeIsValid()
        {
            // Arrange
            var fizzBuzzTree = new FizzBuzzTree();
            var inputTree = CreateSampleTree();

            // Act
            var result = fizzBuzzTree.FizzBuzzTreeTransform(inputTree);

            // Assert
            Assert.NotNull(result);
            Assert.Equal("FizzBuzz", result.Value);
            Assert.Equal(3, result.Children.Count);
            Assert.Equal("Fizz", result.Children[0].Value);
            Assert.Equal("Buzz", result.Children[1].Value);
            Assert.Equal("Fizz", result.Children[2].Value);
            Assert.Equal(1, result.Children[0].Children.Count);
            Assert.Equal(1, result.Children[1].Children.Count);
            Assert.Equal("Fizz", result.Children[0].Children[0].Value);
            Assert.Equal("Buzz", result.Children[1].Children[0].Value);
        }

        [Fact]
        public void FizzBuzzTreeTransform_ShouldHandleStringValues_WhenInputTreeContainsStringValues()
        {
            // Arrange
            var fizzBuzzTree = new FizzBuzzTree();
            var rootNode = new KaryTreeNode("Fizz");
            var node1 = new KaryTreeNode("3");
            var node2 = new KaryTreeNode("Buzz");

            rootNode.Children.Add(node1);
            rootNode.Children.Add(node2);

            // Act
            var result = fizzBuzzTree.FizzBuzzTreeTransform(rootNode);

            // Assert
            Assert.NotNull(result);
            Assert.Equal("Fizz", result.Value);
            Assert.Equal(2, result.Children.Count);
            Assert.Equal("Fizz", result.Children[0].Value);
            Assert.Equal("Buzz", result.Children[1].Value);
        }
    }
}