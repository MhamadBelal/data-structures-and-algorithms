namespace LinkedListCodeImplementation
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create the first linked list
            LinkedList list1 = new LinkedList();
            list1.Add(1);
            list1.Add(3);
            list1.Add(2);

            // Create the second linked list
            LinkedList list2 = new LinkedList();
            list2.Add(5);
            list2.Add(9);
            list2.Add(4);

            // Zip the two lists together
            LinkedList zippedList = LinkedList.ZipLists(list1, list2);

            // Print the zipped list
            Console.WriteLine("Zipped List:");
            zippedList.Print();

            Console.ReadKey();
        }
    }

    public class Node
    {
        public int Data;
        public Node Next;

        public Node(int data)
        {
            Data = data;
            Next = null;
        }
    }

    public class LinkedList
    {
        public Node Head;

        public LinkedList()
        {
            Head = null;
        }

        public void Add(int data)
        {
            Node newNode = new Node(data);

            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                Node current = Head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }

        public static LinkedList ZipLists(LinkedList list1, LinkedList list2)
        {
            if (list1.Head == null)
            {
                return list2;
            }
            else if (list2.Head == null)
            {
                return list1;
            }

            Node current1 = list1.Head;
            Node current2 = list2.Head;
            Node next1, next2;

            while (current1 != null && current2 != null)
            {
                next1 = current1.Next;
                next2 = current2.Next;

                current2.Next = next1;
                current1.Next = current2;

                current1 = next1;
                current2 = next2;
            }

            if (current2 != null)
            {
                current1 = list1.Head;
                while (current1.Next != null)
                {
                    current1 = current1.Next;
                }
                current1.Next = current2;
            }

            return list1;
        }


        public void Print()
        {
            Node current = Head;

            while (current != null)
            {
                Console.Write($"{current.Data} -> ");
                current = current.Next;
            }

            Console.WriteLine("null");
        }
    }
}