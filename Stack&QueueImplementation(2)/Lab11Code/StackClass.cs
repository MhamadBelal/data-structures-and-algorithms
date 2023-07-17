using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11Code
{
    public class StackClass<T>
    {
            private List<T> items;

            public StackClass()
            {
                items = new List<T>();
            }

            public void Push(T item)
            {
                items.Add(item);
            }

            public T Pop()
            {
                if (IsEmpty())
                    throw new InvalidOperationException("Stack is empty");

                T item = items[items.Count - 1];
                items.RemoveAt(items.Count - 1);
                return item;
            }

            public T Peek()
            {
                if (IsEmpty())
                    throw new InvalidOperationException("Stack is empty");

                return items[items.Count - 1];
            }

            public bool IsEmpty()
            {
                return items.Count == 0;
            }
        }

        public class PseudoQueue<T>
        {
            private StackClass<T> stack1;
            private StackClass<T> stack2;

            public PseudoQueue()
            {
                stack1 = new StackClass<T>();
                stack2 = new StackClass<T>();
            }

            public void Enqueue(T value)
            {
                while (!stack1.IsEmpty())
                {
                    stack2.Push(stack1.Pop());
                }

                stack1.Push(value);

                while (!stack2.IsEmpty())
                {
                    stack1.Push(stack2.Pop());
                }
            }

            public T Dequeue()
            {
                if (stack1.IsEmpty())
                    throw new InvalidOperationException("Queue is empty");

                return stack1.Pop();
            }
        }
}
