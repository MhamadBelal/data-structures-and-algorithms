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