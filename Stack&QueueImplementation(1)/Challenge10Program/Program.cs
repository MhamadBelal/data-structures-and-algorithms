namespace Challenge10Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            StackClass<int> stack = new StackClass<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine(stack.Peek());  // Output: 3

            Console.WriteLine(stack.Pop());   // Output: 3
            Console.WriteLine(stack.Pop());   // Output: 2
            Console.WriteLine(stack.Pop());   // Output: 1

            Console.WriteLine(stack.IsEmpty());  // Output: True



            QueueClass<string> queue = new QueueClass<string>();
            queue.Enqueue("Apple");
            queue.Enqueue("Banana");
            queue.Enqueue("Cherry");

            Console.WriteLine(queue.Peek());   // Output: Apple

            Console.WriteLine(queue.Dequeue());   // Output: Apple
            Console.WriteLine(queue.Dequeue());   // Output: Banana
            Console.WriteLine(queue.Dequeue());   // Output: Cherry

            Console.WriteLine(queue.IsEmpty());  // Output: True
        }
    }
}