using System.Collections.Generic;

namespace StackDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stk = new Stack<int>();
            stk.Push(10);
            stk.Push(20);
            stk.Push(30);
            stk.Push(40);
            stk.Push(50);

            Console.WriteLine("Pop:" + stk.Pop());
            Console.WriteLine("Pop:" + stk.Pop());
            Console.WriteLine("Peek:" + stk.Peek()); //just next item info, doesn't remove
            Console.WriteLine("Pop:" + stk.Pop());
            Console.WriteLine("Pop:" + stk.Pop());
            Console.WriteLine("Pop:" + stk.Pop());

            //cannot add item in the middle
        }
    }
}
