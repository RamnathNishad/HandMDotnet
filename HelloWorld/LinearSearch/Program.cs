namespace LinearSearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 5, 11, 7, 6, 9, 4, 3, 2 };
            
            Console.Write("Enter value to search:");
            int item=int.Parse(Console.ReadLine());

            //find the item using linear search
            bool found=false;
            for (int i=0;i<numbers.Length;i++)
            {
                if (numbers[i] == item)
                {
                    Console.WriteLine("Found at index:" + i);
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine("Item not found");
            }
        }
    }
}
