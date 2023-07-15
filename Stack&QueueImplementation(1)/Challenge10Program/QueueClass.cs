using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge10Program
{
    public class QueueClass<T>
    {
        private class Node
        {
            public T Value { get; set; }
            public Node Next { get; set; }

            public Node(T value)
            {
                Value = value;
                Next = null;
            }
        }

        private Node front;
        private Node rear;

        public QueueClass()
        {
            front = null;
            rear = null;
        }

        public void Enqueue(T value)
        {
            Node newNode = new Node(value);
            if (IsEmpty())
            {
                front = newNode;
                rear = newNode;
            }
            else
            {
                rear.Next = newNode;
                rear = newNode;
            }
        }

        public T Dequeue()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty");
            }

            T value = front.Value;
            front = front.Next;

            if (front == null)
            {
                rear = null;
            }

            return value;
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty");
            }

            return front.Value;
        }

        public bool IsEmpty()
        {
            return front == null;
        }
    }
}
