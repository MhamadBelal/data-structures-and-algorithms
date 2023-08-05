using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeCode
{
    public class BinaryTree<T>
    {
        public Node<T> root;
        public BinaryTree()
        {
            root = null;
        }

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
            else
            {
                current.right = AddRecursive(current.right, value);
            }

            return current;
        }


        public T[] PreorderTraversal()
        {
            List<T> result = new List<T>();
            PreorderTraversalRecursive(root, result);
            return result.ToArray();
        }


        private void PreorderTraversalRecursive(Node<T> node, List<T> result)
        {
            if (node != null)
            {
                result.Add(node.Value);
                PreorderTraversalRecursive(node.left, result);
                PreorderTraversalRecursive(node.right, result);
            }
        }



        // Method for in-order traversal
        public T[] InorderTraversal()
        {
            List<T> result = new List<T>();
            InorderTraversalRecursive(root, result);
            return result.ToArray();
        }

        private void InorderTraversalRecursive(Node<T> node, List<T> result)
        {
            if (node != null)
            {
                InorderTraversalRecursive(node.left, result);
                result.Add(node.Value);
                InorderTraversalRecursive(node.right, result);
            }
        }

        // Method for post-order traversal
        public T[] PostorderTraversal()
        {
            List<T> result = new List<T>();
            PostorderTraversalRecursive(root, result);
            return result.ToArray();
        }

        private void PostorderTraversalRecursive(Node<T> node, List<T> result)
        {
            if (node != null)
            {
                PostorderTraversalRecursive(node.left, result);
                PostorderTraversalRecursive(node.right, result);
                result.Add(node.Value);
            }
        }
    }
}
