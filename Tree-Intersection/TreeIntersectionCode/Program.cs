namespace TreeIntersectionCode
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create two sample binary trees
            BinaryTree tree1 = new BinaryTree();
            tree1.Root = new TreeNode(150);
            tree1.Root.Left = new TreeNode(100);
            tree1.Root.Right = new TreeNode(250);
            tree1.Root.Left.Left = new TreeNode(75);
            tree1.Root.Left.Right = new TreeNode(160);
            tree1.Root.Right.Left = new TreeNode(200);
            tree1.Root.Right.Right = new TreeNode(350);

            BinaryTree tree2 = new BinaryTree();
            tree2.Root = new TreeNode(42);
            tree2.Root.Left = new TreeNode(100);
            tree2.Root.Right = new TreeNode(600);
            tree2.Root.Left.Left = new TreeNode(15);
            tree2.Root.Left.Right = new TreeNode(160);
            tree2.Root.Right.Left = new TreeNode(200);
            tree2.Root.Right.Right = new TreeNode(350);

            // Find the intersection of the two trees
            BinaryTree binaryTree = new BinaryTree();
            List<int> intersection = binaryTree.TreeIntersection(tree1, tree2);

            // Print the intersection values
            Console.WriteLine("Intersection of tree1 and tree2: ");
            foreach (int value in intersection)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();

            Console.ReadKey();

        }
    }
}