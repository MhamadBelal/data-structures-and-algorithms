using Challenge10Program;

namespace Challenge10Test
{
    public class StackTest
    {
        [Fact]
        public void Push_SingleValue_SuccessfullyPushed()
        {
            // Arrange
            StackClass<int> stack = new StackClass<int>();

            // Act
            stack.Push(5);

            // Assert
            Assert.Equal(5, stack.Peek());
        }

        [Fact]
        public void Push_MultipleValues_SuccessfullyPushed()
        {
            // Arrange
            StackClass<int> stack = new StackClass<int>();

            // Act
            stack.Push(5);
            stack.Push(10);
            stack.Push(15);

            // Assert
            Assert.Equal(15, stack.Peek());
        }

        [Fact]
        public void Pop_SuccessfulPop()
        {
            // Arrange
            StackClass<int> stack = new StackClass<int>();
            stack.Push(5);
            stack.Push(10);
            stack.Push(15);

            // Act
            int poppedValue = stack.Pop();

            // Assert
            Assert.Equal(15, poppedValue);
            Assert.Equal(10, stack.Peek());
        }

        [Fact]
        public void Pop_EmptyStack_ThrowsException()
        {
            // Arrange
            StackClass<int> stack = new StackClass<int>();

            // Act and Assert
            Assert.Throws<InvalidOperationException>(() => stack.Pop());
        }

        [Fact]
        public void Peek_SuccessfulPeek()
        {
            // Arrange
            StackClass<int> stack = new StackClass<int>();
            stack.Push(5);
            stack.Push(10);
            stack.Push(15);

            // Act
            int peekedValue = stack.Peek();

            // Assert
            Assert.Equal(15, peekedValue);
        }

        [Fact]
        public void Peek_EmptyStack_ThrowsException()
        {
            // Arrange
            StackClass<int> stack = new StackClass<int>();

            // Act and Assert
            Assert.Throws<InvalidOperationException>(() => stack.Peek());
        }

        [Fact]
        public void IsEmpty_EmptyStack_ReturnsTrue()
        {
            // Arrange
            StackClass<int> stack = new StackClass<int>();

            // Act and Assert
            Assert.True(stack.IsEmpty());
        }

        [Fact]
        public void IsEmpty_NonEmptyStack_ReturnsFalse()
        {
            // Arrange
            StackClass<int> stack = new StackClass<int>();
            stack.Push(5);

            // Act and Assert
            Assert.False(stack.IsEmpty());
        }
    }
}