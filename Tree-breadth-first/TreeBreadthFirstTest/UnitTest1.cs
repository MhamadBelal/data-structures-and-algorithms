using TreeBreadthFirstCode;

namespace TreeBreadthFirstTest
{
    public class UnitTest1
    {
        private TreeNode CreateTree()
        {
            TreeNode root = new TreeNode(1)
            {
                Left = new TreeNode(2)
                {
                    Left = new TreeNode(4),
                    Right = new TreeNode(5)
                },
                Right = new TreeNode(3)
                {
                    Left = new TreeNode(6),
                    Right = new TreeNode(7)
                }
            };

            return root;
        }

        [Fact]
        public void TestEmptyTree()
        {
            TreeNode root = null;
            List<int> expected = new List<int>();
            List<int> actual = TreeTraversal.BreadthFirst(root);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestSingleRootNode()
        {
            TreeNode root = new TreeNode(1);
            List<int> expected = new List<int> { 1 };
            List<int> actual = TreeTraversal.BreadthFirst(root);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMultipleNodes()
        {
            TreeNode root = CreateTree();
            List<int> expected = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
            List<int> actual = TreeTraversal.BreadthFirst(root);
            Assert.Equal(expected, actual);
        }
    }
}