using System;
using System.Collections.Generic;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            LinkedList myLinkedList = new LinkedList();

            // Insert nodes
            myLinkedList.Insert(3);
            myLinkedList.Insert(5);
            myLinkedList.Insert(2);

            // Check if a value exists in the linked list
            Console.WriteLine(myLinkedList.Includes(2)); // True
            Console.WriteLine(myLinkedList.Includes(4)); // False

            // Print the linked list
            Console.WriteLine(myLinkedList.LinkedListToString());
        }
    }


    public class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }

        public Node(int value)
        {
            Value = value;
            Next = null;
        }
    }


    public class LinkedList
    {
        public Node head;

        public LinkedList()
        {
            head = null;
        }

        public void Insert(int value)
        {
            Node newNode = new Node(value);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                newNode.Next = head;
                head = newNode;
            }
        }

        public bool Includes(int value)
        {
            Node current = head;
            while (current != null)
            {
                if (current.Value == value)
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public string LinkedListToString()
        {
            List<string> nodeStrings = new List<string>();
            Node current = head;

            while (current != null)
            {
                nodeStrings.Add($"{{ {current.Value} }}");
                current = current.Next;
            }

            nodeStrings.Reverse();  // Reverse the order of the nodes
            nodeStrings.Add("NULL");

            return string.Join(" -> ", nodeStrings);
        }
    }
}