using Challenge10Program;

namespace Challenge10Test
{
    public class QueueTest
    {
        [Fact]
        public void Enqueue_SingleValue_SuccessfullyEnqueued()
        {
            // Arrange
            QueueClass<string> queue = new QueueClass<string>();

            // Act
            queue.Enqueue("Apple");

            // Assert
            Assert.Equal("Apple", queue.Peek());
        }

        [Fact]
        public void Enqueue_MultipleValues_SuccessfullyEnqueued()
        {
            // Arrange
            QueueClass<string> queue = new QueueClass<string>();

            // Act
            queue.Enqueue("Apple");
            queue.Enqueue("Banana");
            queue.Enqueue("Cherry");

            // Assert
            Assert.Equal("Apple", queue.Peek());
        }

        [Fact]
        public void Dequeue_SuccessfulDequeue()
        {
            // Arrange
            QueueClass<string> queue = new QueueClass<string>();
            queue.Enqueue("Apple");
            queue.Enqueue("Banana");
            queue.Enqueue("Cherry");

            // Act
            string dequeuedValue = queue.Dequeue();

            // Assert
            Assert.Equal("Apple", dequeuedValue);
            Assert.Equal("Banana", queue.Peek());
        }

        [Fact]
        public void Dequeue_EmptyQueue_ThrowsException()
        {
            // Arrange
            QueueClass<string> queue = new QueueClass<string>();

            // Act and Assert
            Assert.Throws<InvalidOperationException>(() => queue.Dequeue());
        }

        [Fact]
        public void Peek_SuccessfulPeek()
        {
            // Arrange
            QueueClass<string> queue = new QueueClass<string>();
            queue.Enqueue("Apple");
            queue.Enqueue("Banana");
            queue.Enqueue("Cherry");

            // Act
            string peekedValue = queue.Peek();

            // Assert
            Assert.Equal("Apple", peekedValue);
        }

        [Fact]
        public void Peek_EmptyQueue_ThrowsException()
        {
            // Arrange
            QueueClass<string> queue = new QueueClass<string>();

            // Act and Assert
            Assert.Throws<InvalidOperationException>(() => queue.Peek());
        }

        [Fact]
        public void IsEmpty_EmptyQueue_ReturnsTrue()
        {
            // Arrange
            QueueClass<string> queue = new QueueClass<string>();

            // Act and Assert
            Assert.True(queue.IsEmpty());
        }

        [Fact]
        public void IsEmpty_NonEmptyQueue_ReturnsFalse()
        {
            // Arrange
            QueueClass<string> queue = new QueueClass<string>();
            queue.Enqueue("Apple");

            // Act and Assert
            Assert.False(queue.IsEmpty());
        }
    }
}
