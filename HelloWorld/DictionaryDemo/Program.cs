using System.Collections.Generic;

namespace DictionaryDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> books = new Dictionary<int, string>();
            books.Add(1, "C# for Beginners");
            books.Add(2, "ASP.NET Programming");
            books.Add(3, "Ms Sql Server");

            Console.WriteLine("Book id:1====>" + "Book name:" + books[1]);
            Console.WriteLine("Book id:2====>" + "Book name:" + books[2]);
            Console.WriteLine("Book id:3====>" + "Book name:" + books[3]);

            Console.WriteLine("\nTraversing using keys");
            foreach (int k in books.Keys)
            {
                Console.WriteLine("Book id:" + k + "===>Book name:" + books[k]);
            }

            Console.WriteLine("\nTraversing using values");
            foreach (string v in books.Values)
            {
                Console.WriteLine("Book name:" + v);
            }

            Console.WriteLine("\nTraversing using IEnumerator<KeyValuePair>");
            IEnumerator<KeyValuePair<int, string>> iter = books.GetEnumerator();
            while (iter.MoveNext())
            {
                int key=iter.Current.Key;
                string value=iter.Current.Value;

                Console.WriteLine($"Book id:{key}\tBook name:{value}");
            }
            
            //Note: Duplicate key is not allowed
        }
    }
}
