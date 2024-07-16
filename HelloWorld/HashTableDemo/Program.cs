using System.Collections;
namespace HashTableDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hashtable:- key/value pair collection

            Hashtable ht = new Hashtable();
            ht.Add("username", "administrator");
            ht.Add("password", "admin123");
            ht.Add("server", "localhost");

            //access using key
            Console.WriteLine("User name:" + ht["username"]);
            Console.WriteLine("Password :" + ht["password"]);
            Console.WriteLine("Server   :" + ht["server"]);

            //Note: no duplicate keys are allowed

            Console.WriteLine("\nTraversing all the keys");
            foreach (string key in ht.Keys)
            {
                Console.WriteLine(key +":" + ht[key]);
            }

            Console.WriteLine("\nTraversing all values");
            foreach (string value in ht.Values)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine("\nTraversing using IEnumerator interface");
            IEnumerator ien=ht.Keys.GetEnumerator();
            while (ien.MoveNext())
            {
                string key = (string)ien.Current;
                Console.WriteLine(key+":" + ht[key]);
            }
        }
    }
}
