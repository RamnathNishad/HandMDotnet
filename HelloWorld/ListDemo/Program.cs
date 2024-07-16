using System.Collections.Generic;

namespace ListDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> lstNums = new List<int>();
            lstNums.Add(300);
            lstNums.Add(200);
            lstNums.Add(100);
            lstNums.Add(400);
            lstNums.Add(500);

            lstNums.Sort();

            Console.WriteLine("Traversing using for index loop");
            for (int i = 0; i < lstNums.Count; i++)
            {
                Console.WriteLine(lstNums[i]);
            }

            Console.WriteLine("\nTraversing using foreach");
            foreach (int n in lstNums)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("\nTraverse using IEnumerator<>");
            IEnumerator<int> ien= lstNums.GetEnumerator();
            while (ien.MoveNext())
            {
                Console.WriteLine(ien.Current);
            }            
        }
    }
}
