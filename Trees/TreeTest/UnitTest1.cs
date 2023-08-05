using TreeCode;

namespace TreeTest
{
    public class UnitTest1
    {
        [Fact]
        public void CanInstantiateEmptyTree()
        {
            // Arrange
            BinarySearchTree<int> bst = new BinarySearchTree<int>();

            // Act
            int[] preOrderTraversalResult = bst.PreorderTraversal();

            // Assert
            Assert.Empty(preOrderTraversalResult);
        }

        [Fact]
        public void CanInstantiateTreeWithSingleRootNode()
        {
            // Arrange
            BinarySearchTree<int> bst = new BinarySearchTree<int>();
            bst.Add(5);

            // Act
            int[] preOrderTraversalResult = bst.PreorderTraversal();

            // Assert
            Assert.Equal(new int[] { 5 }, preOrderTraversalResult);
        }

        [Fact]
        public void CanAddLeftAndRightChildToNodeInBinarySearchTree()
        {
            // Arrange
            BinarySearchTree<int> bst = new BinarySearchTree<int>();
            bst.Add(5);
            bst.Add(3);
            bst.Add(7);

            // Act
            int[] preOrderTraversalResult = bst.PreorderTraversal();

            // Assert
            Assert.Equal(new int[] { 5, 3, 7 }, preOrderTraversalResult);
        }

        [Fact]
        public void CanReturnCollectionFromPreorderTraversal()
        {
            // Arrange
            BinarySearchTree<int> bst = new BinarySearchTree<int>();
            bst.Add(5);
            bst.Add(3);
            bst.Add(7);
            bst.Add(2);
            bst.Add(4);

            // Act
            int[] preOrderTraversalResult = bst.PreorderTraversal();

            // Assert
            Assert.Equal(new int[] { 5, 3, 2, 4, 7 }, preOrderTraversalResult);
        }

        [Fact]
        public void CanReturnCollectionFromInorderTraversal()
        {
            // Arrange
            BinarySearchTree<int> bst = new BinarySearchTree<int>();
            bst.Add(5);
            bst.Add(3);
            bst.Add(7);
            bst.Add(2);
            bst.Add(4);

            // Act
            int[] inOrderTraversalResult = bst.InorderTraversal();

            // Assert
            Assert.Equal(new int[] { 2, 3, 4, 5, 7 }, inOrderTraversalResult);
        }

        [Fact]
        public void CanReturnCollectionFromPostorderTraversal()
        {
            // Arrange
            BinarySearchTree<int> bst = new BinarySearchTree<int>();
            bst.Add(5);
            bst.Add(3);
            bst.Add(7);
            bst.Add(2);
            bst.Add(4);

            // Act
            int[] postOrderTraversalResult = bst.PostorderTraversal();

            // Assert
            Assert.Equal(new int[] { 2, 4, 3, 7, 5 }, postOrderTraversalResult);
        }

        [Fact]
        public void ContainsMethodReturnsTrueForExistingValue()
        {
            // Arrange
            BinarySearchTree<int> bst = new BinarySearchTree<int>();
            bst.Add(5);
            bst.Add(3);
            bst.Add(7);

            // Act
            bool containsValue = bst.Contains(3);

            // Assert
            Assert.True(containsValue);
        }

        [Fact]
        public void ContainsMethodReturnsFalseForNonExistingValue()
        {
            // Arrange
            BinarySearchTree<int> bst = new BinarySearchTree<int>();
            bst.Add(5);
            bst.Add(3);
            bst.Add(7);

            // Act
            bool containsValue = bst.Contains(6);

            // Assert
            Assert.False(containsValue);
        }
    }
}