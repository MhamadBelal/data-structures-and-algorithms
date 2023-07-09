# Extending Linked list Implementation

Zip two linked lists

## Whiteboard Process 

![ZipList function LinkedList](./Assets/Challenge08(1).PNG)
![ZipList function LinkedList](./Assets/Challenge08(2).PNG)

---

## Approach & Efficiency

**Approach:**

1. The function first checks if either `list1` or `list2` is empty. If list1 is empty, it returns `list2`, and if `list2` is empty, it returns `list1`. This handles the edge cases where one or both lists are empty.
2. The function then initializes two pointers, `current1` and `current2`, to point to the heads of `list1` and `list2` respectively.
3. It uses two temporary pointers, `next1` and `next2`, to store the next nodes of `current1` and `current2` respectively.
4. The function iterates through the nodes of both lists alternately:
   * It updates the `Next` pointers to link the nodes together.
   * It moves the `current1` and `current2` pointers to their next nodes.
5. After the iteration, if `current2` is not null, it means that `list2` has more nodes. The function appends the remaining nodes of `list2 `to the end of `list1`.
6. Finally, the function returns `list1`, which is the zipped list.

**Efficiency:**

* Time Complexity: The code iterates through the nodes of both lists once, performing constant-time operations on each node. Therefore, the time complexity of the code is O(n), where n is the total number of nodes in the longer of the two input linked lists.
* Space Complexity: The code uses a constant amount of additional space. It does not create any new data structures or use extra memory that grows with the size of the input. Therefore, the space complexity is O(1).


Overall, the code has a time complexity of O(n) and a space complexity of O(1), where n is the total number of nodes in the longer list.

---

## Solution

Code:

```shell
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
```

The Result after running the code:

```shell
Zipped List:
1 -> 5 -> 3 -> 9 -> 2 -> 4 -> null
```

---

## Test Cases

Unit Testing: 

```shell
using LinkedListCodeImplementation;

namespace LinkedListTestImplementation
{
    public class UnitTest1
    {
        [Fact]
        public void ZipLists_EmptyList_ReturnsOtherList()
        {
            // Arrange
            LinkedList list1 = new LinkedList();
            LinkedList list2 = new LinkedList();
            list2.Add(1);
            list2.Add(2);
            list2.Add(3);

            // Act
            LinkedList result = LinkedList.ZipLists(list1, list2);

            // Assert
            Assert.Same(list2, result);
        }

        [Fact]
        public void ZipLists_OneEmptyList_ReturnsNonEmptyList()
        {
            // Arrange
            LinkedList list1 = new LinkedList();
            list1.Add(1);
            list1.Add(2);
            LinkedList list2 = new LinkedList();

            // Act
            LinkedList result = LinkedList.ZipLists(list1, list2);

            // Assert
            Assert.Same(list1, result);
        }

        [Fact]
        public void ZipLists_EqualLengthLists_ReturnsZippedList()
        {
            // Arrange
            LinkedList list1 = new LinkedList();
            list1.Add(1);
            list1.Add(3);
            list1.Add(5);
            LinkedList list2 = new LinkedList();
            list2.Add(2);
            list2.Add(4);
            list2.Add(6);

            // Act
            LinkedList result = LinkedList.ZipLists(list1, list2);

            // Assert
            Assert.Equal(1, result.Head.Data);
            Assert.Equal(2, result.Head.Next.Data);
            Assert.Equal(3, result.Head.Next.Next.Data);
            Assert.Equal(4, result.Head.Next.Next.Next.Data);
            Assert.Equal(5, result.Head.Next.Next.Next.Next.Data);
            Assert.Equal(6, result.Head.Next.Next.Next.Next.Next.Data);
            Assert.Null(result.Head.Next.Next.Next.Next.Next.Next);
        }

        [Fact]
        public void ZipLists_UnequalLengthLists_ReturnsZippedListWithRemainingNodes()
        {
            // Arrange
            LinkedList list1 = new LinkedList();
            list1.Add(1);
            list1.Add(3);
            list1.Add(5);
            list1.Add(7);
            LinkedList list2 = new LinkedList();
            list2.Add(2);
            list2.Add(4);
            list2.Add(6);

            // Act
            LinkedList result = LinkedList.ZipLists(list1, list2);

            // Assert
            Assert.Equal(1, result.Head.Data);
            Assert.Equal(2, result.Head.Next.Data);
            Assert.Equal(3, result.Head.Next.Next.Data);
            Assert.Equal(4, result.Head.Next.Next.Next.Data);
            Assert.Equal(5, result.Head.Next.Next.Next.Next.Data);
            Assert.Equal(6, result.Head.Next.Next.Next.Next.Next.Data);
            Assert.Equal(7, result.Head.Next.Next.Next.Next.Next.Next.Data);
            Assert.Null(result.Head.Next.Next.Next.Next.Next.Next.Next);
        }
    }
}
```
