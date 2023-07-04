using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        LinkedList ll = new LinkedList();
        ll.Append(1);
        ll.Append(3);
        ll.Append(8);
        ll.Append(2);

        try
        {
            int result1 = ll.KthFromEnd(0); // Output: 2
            Console.WriteLine(result1);
            int result2 = ll.KthFromEnd(2); // Output: 3
            Console.WriteLine(result2);
            Console.WriteLine(ll.KthFromEnd(4)); // Throw Exception
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
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

    public void Append(int value)
    {
        Node newNode = new Node(value);
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

    public int KthFromEnd(int k)
    {
        if(k<0)
        {
            throw new Exception("Invalid Index");
        }
        if (head == null)
        {
            throw new Exception("LinkedList is empty.");
        }

        Node slow = head;
        Node fast = head;

        // Move the fast pointer k steps ahead of the slow pointer
        for (int i = 0; i < k; i++)
        {
            if (fast == null)
            {
                throw new Exception("k is greater than or equal to the size of the LinkedList.");
            }
            fast = fast.Next;
        }

        // Check if fast reached the end (k is equal to the size of the LinkedList)
        if (fast == null)
        {
            throw new Exception("k is equal to the size of the LinkedList.");
        }

        // Move both pointers until the fast pointer reaches the end
        while (fast.Next != null)
        {
            slow = slow.Next;
            fast = fast.Next;
        }

        return slow.Value;
    }
}