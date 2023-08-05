using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeBreadthFirstCode
{
    public class TreeTraversal
    {
        public static List<int> BreadthFirst(TreeNode tree)
        {
            if (tree == null)
                return new List<int>();

            List<int> result = new List<int>();
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(tree);

            while (queue.Count > 0)
            {
                TreeNode node = queue.Dequeue();
                result.Add(node.Value);

                if (node.Left != null)
                    queue.Enqueue(node.Left);

                if (node.Right != null)
                    queue.Enqueue(node.Right);
            }

            return result;
        }
    }
}
