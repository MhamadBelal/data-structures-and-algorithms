using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeCode
{
    public class Node<T>
    {
        public T Value { get; set; }
        public Node<T> left { get; set; }
        public Node<T> right { get; set; }
        public Node(T value)
        {
            Value = value;
            left = null;
            right = null;
            
        }
    }
}
