using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeIntersectionCode
{
    public class BinaryTree
    {
        public TreeNode Root;

        public BinaryTree()
        {
            Root = null;
        }

        // Helper method to perform an in-order traversal and populate a HashSet with values.
        private void TraverseTree(TreeNode node, HashSet<int> valuesSet)
        {
            if (node == null)
                return;

            TraverseTree(node.Left, valuesSet);
            valuesSet.Add(node.Value);
            TraverseTree(node.Right, valuesSet);
        }

        public List<int> TreeIntersection(BinaryTree tree1, BinaryTree tree2)
        {
            HashSet<int> valuesSet1 = new HashSet<int>();
            HashSet<int> valuesSet2 = new HashSet<int>();

            TraverseTree(tree1.Root, valuesSet1);
            TraverseTree(tree2.Root, valuesSet2);

            valuesSet1.IntersectWith(valuesSet2);

            List<int> intersectionList = new List<int>(valuesSet1);
            return intersectionList;
        }
    }
}
