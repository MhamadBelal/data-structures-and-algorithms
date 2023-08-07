namespace tree_fizz_buzzCode
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Creating a sample k-ary tree
            var rootNode = new KaryTreeNode("15");
            var node1 = new KaryTreeNode("6");
            var node2 = new KaryTreeNode("10");
            var node3 = new KaryTreeNode("3");
            var node4 = new KaryTreeNode("9");
            var node5 = new KaryTreeNode("5");
            var node6 = new KaryTreeNode("7");

            rootNode.Children.Add(node1);
            rootNode.Children.Add(node2);
            rootNode.Children.Add(node3);

            node1.Children.Add(node4);
            node2.Children.Add(node5);
            node3.Children.Add(node6);

            // Creating FizzBuzzTree instance
            var fizzBuzzTree = new FizzBuzzTree();

            // Transforming the k-ary tree using FizzBuzzTreeTransform method
            var modifiedTree = fizzBuzzTree.FizzBuzzTreeTransform(rootNode);

            // Printing the modified tree
            Console.WriteLine("Modified K-ary tree:");
            PrintTree(modifiedTree);
        }

        static void PrintTree(KaryTreeNode root, string prefix = "")
        {
            if (root != null)
            {
                Console.WriteLine(prefix + root.Value);
                foreach (var child in root.Children)
                {
                    PrintTree(child, prefix + "   ");
                }
            }
        }
    }
}