namespace TreeCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<int> binaryTree = new BinaryTree<int>();
            binaryTree.Add(5);
            binaryTree.Add(3);
            binaryTree.Add(7);
            binaryTree.Add(2);
            binaryTree.Add(4);

            int[] preOrderTraversalResult = binaryTree.PreorderTraversal();
            int[] inOrderTraversalResult = binaryTree.InorderTraversal();
            int[] postOrderTraversalResult = binaryTree.PostorderTraversal();

            Console.WriteLine("Pre-order traversal: " + string.Join(", ", preOrderTraversalResult));
            Console.WriteLine("In-order traversal: " + string.Join(", ", inOrderTraversalResult));
            Console.WriteLine("Post-order traversal: " + string.Join(", ", postOrderTraversalResult));

            Console.WriteLine();

            BinarySearchTree<int> bst = new BinarySearchTree<int>();
            bst.Add(5);
            bst.Add(3);
            bst.Add(7);
            bst.Add(2);
            bst.Add(4);

            bool containsValue = bst.Contains(7);
            Console.WriteLine("Contains 7? " + containsValue); // Output: Contains 7? True

            containsValue = bst.Contains(6);
            Console.WriteLine("Contains 6? " + containsValue); // Output: Contains 6? False

        }
    }
}