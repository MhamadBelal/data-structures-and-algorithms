using System.Collections.Generic;
using LinkedListCodeImplementation;

namespace LinkedListTestImplementation
{
    public class UnitTest1
    {
        [Fact]
        public void Append_SingleNode_SuccessfullyAddsNodeToEndOfList()
        {
            // Arrange
            LinkedList linkedList = new LinkedList();

            // Act
            linkedList.Append(1);

            // Assert
            Assert.Equal("1 -> X", linkedList.Display());
        }

        [Fact]
        public void Append_MultipleNodes_SuccessfullyAddsNodesToEndOfList()
        {
            // Arrange
            LinkedList linkedList = new LinkedList();

            // Act
            linkedList.Append(1);
            linkedList.Append(3);
            linkedList.Append(2);

            // Assert
            Assert.Equal("1 -> 3 -> 2 -> X", linkedList.Display());
        }

        [Fact]
        public void InsertBefore_MiddleNode_SuccessfullyInsertsNodeBeforeMiddleNode()
        {
            // Arrange
            LinkedList linkedList = new LinkedList();
            linkedList.Append(1);
            linkedList.Append(3);
            linkedList.Append(2);

            // Act
            linkedList.InsertBefore(3, 5);

            // Assert
            Assert.Equal("1 -> 5 -> 3 -> 2 -> X", linkedList.Display());
        }

        [Fact]
        public void InsertBefore_FirstNode_SuccessfullyInsertsNodeBeforeFirstNode()
        {
            // Arrange
            LinkedList linkedList = new LinkedList();
            linkedList.Append(1);
            linkedList.Append(3);
            linkedList.Append(2);

            // Act
            linkedList.InsertBefore(1, 5);

            // Assert
            Assert.Equal("5 -> 1 -> 3 -> 2 -> X", linkedList.Display());
        }

        [Fact]
        public void InsertAfter_MiddleNode_SuccessfullyInsertsNodeAfterMiddleNode()
        {
            // Arrange
            LinkedList linkedList = new LinkedList();
            linkedList.Append(1);
            linkedList.Append(3);
            linkedList.Append(2);

            // Act
            linkedList.InsertAfter(3, 5);

            // Assert
            Assert.Equal("1 -> 3 -> 5 -> 2 -> X", linkedList.Display());
        }

        [Fact]
        public void InsertAfter_LastNode_SuccessfullyInsertsNodeAfterLastNode()
        {
            // Arrange
            LinkedList linkedList = new LinkedList();
            linkedList.Append(1);
            linkedList.Append(3);
            linkedList.Append(2);

            // Act
            linkedList.InsertAfter(2, 5);

            // Assert
            Assert.Equal("1 -> 3 -> 2 -> 5 -> X", linkedList.Display());
        }
    }
}