namespace InheritanceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TWO-WHEELERS FEATURES");
            TwoWheeler discover = new TwoWheeler();
            discover.Brake();
            discover.Horn();
            discover.Stand();

            Console.WriteLine("\nFOUR-WHEELERS FEATURES");
            FourWheeler maruti=new FourWheeler();
            maruti.Brake();
            maruti.Horn();
            maruti.Ac();
            maruti.Music();

        }
    }

    class Vehicle
    {
        public void Brake()
        {
            Console.WriteLine("Brake feature");
        }
        public void Horn()
        {
            Console.WriteLine("Horn feature");
        }
    }

    class TwoWheeler  : Vehicle
    {
        public void Stand()
        {
            Console.WriteLine("Stand feature");
        }
    }
    class FourWheeler : Vehicle
    {
        public void Ac()
        {
            Console.WriteLine("AC feature");
        }
        public void Music()
        {
            Console.WriteLine("Music feature");
        }
    }
}
