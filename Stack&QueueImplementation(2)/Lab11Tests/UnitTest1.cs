using Lab11Code;

namespace Lab11Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Enqueue_ShouldAddElementToQueue()
        {
            PseudoQueue<int> pseudoQueue = new PseudoQueue<int>();

            pseudoQueue.Enqueue(10);
            pseudoQueue.Enqueue(20);

            Assert.Equal(10, pseudoQueue.Dequeue());
            Assert.Equal(20, pseudoQueue.Dequeue());
        }

        [Fact]
        public void Dequeue_ShouldRemoveAndReturnFirstElementInQueue()
        {
            PseudoQueue<int> pseudoQueue = new PseudoQueue<int>();

            pseudoQueue.Enqueue(5);
            pseudoQueue.Enqueue(10);
            pseudoQueue.Enqueue(15);

            Assert.Equal(5, pseudoQueue.Dequeue());
            Assert.Equal(10, pseudoQueue.Dequeue());
            Assert.Equal(15, pseudoQueue.Dequeue());
        }

        [Fact]
        public void Dequeue_ShouldThrowException_WhenQueueIsEmpty()
        {
            PseudoQueue<int> pseudoQueue = new PseudoQueue<int>();

            Assert.Throws<InvalidOperationException>(() => pseudoQueue.Dequeue());
        }
    }
}