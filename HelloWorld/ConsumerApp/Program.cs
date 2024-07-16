using MyLib;
using GlobalLib;

namespace ConsumerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sample sample = new Sample();
            Console.WriteLine(sample.GetMsg());

            GlobalAssemblyCls cls=new GlobalAssemblyCls();
            Console.WriteLine(cls.GetData());
        }
    }
}
