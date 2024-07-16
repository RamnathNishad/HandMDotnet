using System.Collections.Generic;

namespace QueueDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(100);
            queue.Enqueue(200);
            queue.Enqueue(300);
            queue.Enqueue(400);
            queue.Enqueue(500);

            Console.WriteLine("Dequeue:" + queue.Dequeue());
            Console.WriteLine("Dequeue:" + queue.Dequeue());
            Console.WriteLine("Peek:" + queue.Peek());
            Console.WriteLine("Dequeue:" + queue.Dequeue());
            Console.WriteLine("Dequeue:" + queue.Dequeue());
            Console.WriteLine("Dequeue:" + queue.Dequeue());

        }
    }
}
