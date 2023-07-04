using Xunit;

public class LinkedListTests
{
    [Fact]
    public void KthFromEnd_KGreaterThanListLength_ThrowsException()
    {
        // Arrange
        LinkedList ll = new LinkedList();
        ll.Append(1);
        ll.Append(3);
        ll.Append(8);
        ll.Append(2);

        // Act & Assert
        Assert.Throws<Exception>(() => ll.KthFromEnd(5));
    }

    [Fact]
    public void KthFromEnd_KEqualsListLength_ThrowsException()
    {
        // Arrange
        LinkedList ll = new LinkedList();
        ll.Append(1);
        ll.Append(3);
        ll.Append(8);
        ll.Append(2);

        // Act & Assert
        Assert.Throws<Exception>(() => ll.KthFromEnd(4));
    }

    [Fact]
    public void KthFromEnd_KNotPositiveInteger_ThrowsException()
    {
        // Arrange
        LinkedList ll = new LinkedList();
        ll.Append(1);
        ll.Append(3);
        ll.Append(8);
        ll.Append(2);

        // Act & Assert
        Assert.Throws<Exception>(() => ll.KthFromEnd(-2));
    }

    [Fact]
    public void KthFromEnd_ListSizeOne_ReturnsValue()
    {
        // Arrange
        LinkedList ll = new LinkedList();
        ll.Append(1);

        // Act
        int result = ll.KthFromEnd(0);

        // Assert
        Assert.Equal(1, result);
    }

    [Fact]
    public void KthFromEnd_KInMiddle_ReturnsValue()
    {
        // Arrange
        LinkedList ll = new LinkedList();
        ll.Append(1);
        ll.Append(3);
        ll.Append(8);
        ll.Append(2);

        // Act
        int result = ll.KthFromEnd(2);

        // Assert
        Assert.Equal(3, result);
    }
}