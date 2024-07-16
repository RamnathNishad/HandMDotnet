using System.Collections;


namespace CollectionsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //non-generics
            ArrayList arrLst = new ArrayList();

            arrLst.Add(100);
            arrLst.Add("Hello");
            arrLst.Add(200);
            arrLst.Add(300);
            arrLst.Add(400);

            //index-based access or foreach loop
            Console.WriteLine("Index-based traversing");
            for (int i = 0; i < arrLst.Count; i++)
            {
                Console.WriteLine(arrLst[i]);
            }

            arrLst.RemoveAt(1);

            Console.WriteLine("foreach loop traversing");
            foreach (object obj in arrLst)
            {
                if (obj is int)
                {
                    int intVal = (int)obj;
                    Console.WriteLine(intVal);
                }
                else if (obj is string)
                {
                    string strVal = (string)obj;
                    Console.WriteLine(strVal);
                }
            }
        }
    }
}
