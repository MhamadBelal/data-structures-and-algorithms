using TreeIntersectionCode;

namespace TreeIntersectionTest
{
    public class UnitTest1
    {
        [Fact]
        public void TreeIntersection_ReturnsIntersection_WhenIntersectionExists()
        {
            // Arrange
            BinaryTree tree1 = new BinaryTree();
            tree1.Root = new TreeNode(150);
            tree1.Root.Left = new TreeNode(100);
            tree1.Root.Right = new TreeNode(250);

            BinaryTree tree2 = new BinaryTree();
            tree2.Root = new TreeNode(42);
            tree2.Root.Left = new TreeNode(100);
            tree2.Root.Right = new TreeNode(600);

            // Act
            BinaryTree binaryTree = new BinaryTree();
            var intersection = binaryTree.TreeIntersection(tree1, tree2);

            // Assert
            Assert.Collection(intersection,
                item => Assert.Equal(100, item)
            );
        }

        [Fact]
        public void TreeIntersection_ReturnsEmptyList_WhenNoIntersectionExists()
        {
            // Arrange
            BinaryTree tree1 = new BinaryTree();
            tree1.Root = new TreeNode(150);
            tree1.Root.Left = new TreeNode(100);
            tree1.Root.Right = new TreeNode(250);

            BinaryTree tree2 = new BinaryTree();
            tree2.Root = new TreeNode(42);
            tree2.Root.Left = new TreeNode(30);
            tree2.Root.Right = new TreeNode(600);

            // Act
            BinaryTree binaryTree = new BinaryTree();
            var intersection = binaryTree.TreeIntersection(tree1, tree2);

            // Assert
            Assert.Empty(intersection);
        }

        [Fact]
        public void TreeIntersection_ReturnsEmptyList_WhenBothTreesAreEmpty()
        {
            // Arrange
            BinaryTree tree1 = new BinaryTree();
            BinaryTree tree2 = new BinaryTree();

            // Act
            BinaryTree binaryTree = new BinaryTree();
            var intersection = binaryTree.TreeIntersection(tree1, tree2);

            // Assert
            Assert.Empty(intersection);
        }

        [Fact]
        public void TreeIntersection_ReturnsEmptyList_WhenOneTreeIsEmpty()
        {
            // Arrange
            BinaryTree tree1 = new BinaryTree();
            tree1.Root = new TreeNode(150);
            tree1.Root.Left = new TreeNode(100);
            tree1.Root.Right = new TreeNode(250);

            BinaryTree tree2 = new BinaryTree();

            // Act
            BinaryTree binaryTree = new BinaryTree();
            var intersection = binaryTree.TreeIntersection(tree1, tree2);

            // Assert
            Assert.Empty(intersection);
        }
    }
}