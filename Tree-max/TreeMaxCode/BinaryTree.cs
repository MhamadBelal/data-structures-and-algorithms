using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeMaxCode
{
    public class BinaryTree
    {
        public Node Root;
        public BinaryTree()
        {
            Root = null;
        }


        public int FindMaxValue()
        {
            if (Root == null)
            {
                throw new InvalidOperationException("Binary tree is empty.");
            }

            int maxValue = int.MinValue;

            void DFS(Node node)
            {
                if (node == null)
                {
                    return;
                }

                // Update the maxValue if the current node's value is greater
                if (node.Value > maxValue)
                {
                    maxValue = node.Value;
                }

                DFS(node.Left);
                DFS(node.Right);
            }

            DFS(Root);

            return maxValue;
        }
    }
}
