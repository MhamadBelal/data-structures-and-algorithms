using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tree_fizz_buzzCode
{
    public class FizzBuzzTree
    {
        public KaryTreeNode FizzBuzzTreeTransform(KaryTreeNode root)
        {
            if (root == null)
                return null;

            Queue<KaryTreeNode> queue = new Queue<KaryTreeNode>();

            KaryTreeNode newRoot = new KaryTreeNode(FizzBuzz(root.Value));
            queue.Enqueue(root);
            queue.Enqueue(newRoot);

            while (queue.Count > 0)
            {
                KaryTreeNode currentOriginal = queue.Dequeue();
                KaryTreeNode currentModified = queue.Dequeue();

                foreach (var child in currentOriginal.Children)
                {
                    var newChild = new KaryTreeNode(FizzBuzz(child.Value));
                    currentModified.Children.Add(newChild);
                    queue.Enqueue(child);
                    queue.Enqueue(newChild);
                }
            }

            return newRoot;
        }

        private string FizzBuzz(string value)
        {
            if (int.TryParse(value, out int numValue))
            {
                if (numValue % 3 == 0 && numValue % 5 == 0)
                    return "FizzBuzz";
                else if (numValue % 3 == 0)
                    return "Fizz";
                else if (numValue % 5 == 0)
                    return "Buzz";
                else
                    return numValue.ToString();
            }
            else
            {
                // If the value is already a string (e.g., "Fizz", "Buzz"), return it as it is.
                return value;
            }
        }

    }
}
