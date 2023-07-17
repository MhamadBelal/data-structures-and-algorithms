namespace Lab11Code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PseudoQueue<int> pseudoQueue = new PseudoQueue<int>();

            pseudoQueue.Enqueue(10);
            pseudoQueue.Enqueue(15);
            pseudoQueue.Enqueue(20);

            Console.WriteLine("Internal State after enqueue:");
            Console.WriteLine(pseudoQueue.Dequeue()); // Output: 10
            Console.WriteLine(pseudoQueue.Dequeue()); // Output: 15

            pseudoQueue.Enqueue(5);

            Console.WriteLine("Internal State after enqueue and dequeue:");
            Console.WriteLine(pseudoQueue.Dequeue()); // Output: 20
            Console.WriteLine(pseudoQueue.Dequeue()); // Output: 5

            // Trying to dequeue from an empty queue
            try
            {
                pseudoQueue.Dequeue();
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message); // Output: Queue is empty
            }
        }
    }
}