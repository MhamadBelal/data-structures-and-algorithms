using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeCode
{
    public class BinarySearchTree<T>:BinaryTree<T>
    {
        public void Add(T value)
        {
            root = AddRecursive(root, value);
        }

        private Node<T> AddRecursive(Node<T> current, T value)
        {
            if (current == null)
            {
                return new Node<T>(value);
            }

            if (Comparer<T>.Default.Compare(value, current.Value) < 0)
            {
                current.left = AddRecursive(current.left, value);
            }
            else if (Comparer<T>.Default.Compare(value, current.Value) > 0)
            {
                current.right = AddRecursive(current.right, value);
            }

            return current;
        }

        public bool Contains(T value)
        {
            return ContainsRecursive(root, value);
        }

        private bool ContainsRecursive(Node<T> current, T value)
        {
            if (current == null)
            {
                return false;
            }

            int comparison = Comparer<T>.Default.Compare(value, current.Value);

            if (comparison == 0)
            {
                return true;
            }
            else if (comparison < 0)
            {
                return ContainsRecursive(current.left, value);
            }
            else
            {
                return ContainsRecursive(current.right, value);
            }
        }
    }
}
