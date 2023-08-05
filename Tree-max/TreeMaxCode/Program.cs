namespace TreeMaxCode
{
    public class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();
            tree.Root = new Node(5);
            tree.Root.Left = new Node(3);
            tree.Root.Right = new Node(8);
            tree.Root.Left.Left = new Node(1);
            tree.Root.Left.Right = new Node(4);
            tree.Root.Right.Left = new Node(7);
            tree.Root.Right.Right = new Node(9);

            int max = tree.FindMaxValue();
            Console.WriteLine("Maximum value in the binary tree: " + max);  // Output: 9
        }
    }
}