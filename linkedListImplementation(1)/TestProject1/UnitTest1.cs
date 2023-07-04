using HelloWorld;
using System.Collections.Generic;
using Xunit;

namespace LinkedListTests
{
    public class LinkedListTests
    {
        [Fact]
        public void CanInstantiateEmptyLinkedList()
        {
            // Arrange
            LinkedList myLinkedList = new LinkedList();

            // Act & Assert
            Assert.Equal("NULL", myLinkedList.LinkedListToString());
        }

        [Fact]
        public void CanInsertIntoLinkedList()
        {
            // Arrange
            LinkedList myLinkedList = new LinkedList();

            // Act
            myLinkedList.Insert(5);

            // Assert
            Assert.True(myLinkedList.Includes(5));
        }

        [Fact]
        public void HeadPointsToFirstNode()
        {
            // Arrange
            LinkedList myLinkedList = new LinkedList();

            // Act
            myLinkedList.Insert(10);
            myLinkedList.Insert(20);
            myLinkedList.Insert(30);

            // Assert
            Assert.Equal(30, myLinkedList.head.Value);
        }

        [Fact]
        public void CanInsertMultipleNodes()
        {
            // Arrange
            LinkedList myLinkedList = new LinkedList();

            // Act
            myLinkedList.Insert(1);
            myLinkedList.Insert(2);
            myLinkedList.Insert(3);

            // Assert
            Assert.True(myLinkedList.Includes(1));
            Assert.True(myLinkedList.Includes(2));
            Assert.True(myLinkedList.Includes(3));
        }

        [Fact]
        public void ValueExistsInLinkedList()
        {
            // Arrange
           LinkedList myLinkedList = new LinkedList();
            myLinkedList.Insert(5);
            myLinkedList.Insert(10);
            myLinkedList.Insert(15);

            // Act
            bool result = myLinkedList.Includes(10);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void ValueDoesNotExistInLinkedList()
        {
            // Arrange
            LinkedList myLinkedList = new LinkedList();
            myLinkedList.Insert(5);
            myLinkedList.Insert(10);
            myLinkedList.Insert(15);

            // Act
            bool result = myLinkedList.Includes(20);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void GetAllValuesInLinkedList()
        {
            // Arrange
            LinkedList myLinkedList = new LinkedList();
            myLinkedList.Insert(1);
            myLinkedList.Insert(2);
            myLinkedList.Insert(3);

            // Act
            string result = myLinkedList.LinkedListToString();

            // Assert
            Assert.Equal("{ 1 } -> { 2 } -> { 3 } -> NULL", result);
        }
    }
}