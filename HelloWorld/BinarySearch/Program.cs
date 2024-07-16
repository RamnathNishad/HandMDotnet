namespace BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 20, 30, 40, 50, 60, 70, 80 };
            Console.WriteLine("Enter value to search:");
            int item=int.Parse(Console.ReadLine());

            //binary search

            int l = 1, r = numbers.Length-1,m;
            bool found = false;

            while (l <= r)
            {
                m = (l + r) / 2;
                if (numbers[m] > item)
                {
                    r = m - 1;
                }
                else if (numbers[m] < item)
                {
                    l = m + 1;
                }
                else
                {
                    Console.WriteLine("Found at index:" + m);
                    found = true;
                    break;
                }
            }
            if(!found)
            {
                Console.WriteLine("Item not found");
            }
        }
    }
}
