namespace TreeBreadthFirstCode
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create a simple binary tree
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

            // Call the function and get the result
            List<int> resultList = TreeTraversal.BreadthFirst(root);
            foreach (int value in resultList)
            {
                Console.Write(value + " "); // Output: 1 2 3 4 5 6 7
            }
        }
    }
}