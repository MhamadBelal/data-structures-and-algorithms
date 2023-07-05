using System.Text;

namespace LinkedListCodeImplementation
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList myLinkedList = new LinkedList();
            myLinkedList.Append(1);
            myLinkedList.Append(3);
            myLinkedList.Append(2);
            myLinkedList.Append(2);
            string listString1 = myLinkedList.Display();
            Console.WriteLine(listString1);

            myLinkedList.Append(5);
            string listString2 = myLinkedList.Display();
            Console.WriteLine(listString2);
            myLinkedList.Display();

            myLinkedList.InsertBefore(3, 5);
            string listString3 = myLinkedList.Display();
            Console.WriteLine(listString3);
            myLinkedList.Display();

            myLinkedList.InsertBefore(1, 5);
            string listString4 = myLinkedList.Display();
            Console.WriteLine(listString4);
            myLinkedList.Display();

            myLinkedList.InsertBefore(2, 5);
            string listString5 = myLinkedList.Display();
            Console.WriteLine(listString5);
            myLinkedList.Display();

            try
            {
                myLinkedList.InsertBefore(4, 5);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            myLinkedList.InsertAfter(3, 5);
            string listString6 = myLinkedList.Display();
            Console.WriteLine(listString6);
            myLinkedList.Display();

            myLinkedList.InsertAfter(2, 5);
            string listString7 = myLinkedList.Display();
            Console.WriteLine(listString7);
            myLinkedList.Display();

            try
            {
                myLinkedList.InsertAfter(4, 5);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
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
        private Node head;

        public LinkedList()
        {
            head = null;
        }

        public void Append(int newValue)
        {
            Node newNode = new Node(newValue);

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }

        public void InsertBefore(int value, int newValue)
        {
            Node newNode = new Node(newValue);

            if (head == null)
            {
                throw new Exception("Cannot insert before. List is empty.");
            }
            else if (head.Value == value)
            {
                newNode.Next = head;
                head = newNode;
            }
            else
            {
                Node current = head;
                while (current.Next != null && current.Next.Value != value)
                {
                    current = current.Next;
                }
                if (current.Next == null)
                {
                    throw new Exception($"Node with value {value} not found.");
                }
                newNode.Next = current.Next;
                current.Next = newNode;
            }
        }

        public void InsertAfter(int value, int newValue)
        {
            Node newNode = new Node(newValue);

            if (head == null)
            {
                throw new Exception("Cannot insert after. List is empty.");
            }
            Node current = head;
            while (current != null && current.Value != value)
            {
                current = current.Next;
            }
            if (current == null)
            {
                throw new Exception($"Node with value {value} not found.");
            }
            newNode.Next = current.Next;
            current.Next = newNode;
        }

        public string Display()
        {
            StringBuilder sb = new StringBuilder();
            Node current = head;
            while (current != null)
            {
                sb.Append(current.Value).Append(" -> ");
                current = current.Next;
            }
            sb.Append("X");
            return sb.ToString();
        }
    }
}