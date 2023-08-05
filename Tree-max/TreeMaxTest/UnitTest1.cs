using TreeMaxCode;

namespace TreeMaxTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestFindMaxValue()
        {
            // Create the binary tree
            BinaryTree tree = new BinaryTree();
            tree.Root = new Node(5);
            tree.Root.Left = new Node(3);
            tree.Root.Right = new Node(8);
            tree.Root.Left.Left = new Node(1);
            tree.Root.Left.Right = new Node(4);
            tree.Root.Right.Left = new Node(7);
            tree.Root.Right.Right = new Node(9);

            // Test with a non-empty binary tree
            int max = tree.FindMaxValue();
            Assert.Equal(9, max);

            // Test with a binary tree with negative values
            tree.Root.Value = -5;
            tree.Root.Left.Value = -3;
            tree.Root.Right.Value = -8;
            tree.Root.Left.Left.Value = -1;
            tree.Root.Left.Right.Value = -4;
            tree.Root.Right.Left.Value = -7;
            tree.Root.Right.Right.Value = -9;
            max = tree.FindMaxValue();
            Assert.Equal(-1, max);

            // Test with a binary tree containing only one node
            tree.Root = new Node(42);
            max = tree.FindMaxValue();
            Assert.Equal(42, max);

            // Test with an empty binary tree (expect an exception)
            tree.Root = null;
            Assert.Throws<InvalidOperationException>(() => tree.FindMaxValue());
        }
    }
}