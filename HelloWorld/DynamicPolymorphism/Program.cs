namespace DynamicPolymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double length = 100, breadth = 100;
            
            //declare variable of base type
            IShape sh;
            //holds the instance of derived class square
            sh = new Square();
            sh.Area(length,breadth);

            //holds the instance of derived class Rectangle
            length = 50;breadth = 100;
            sh = new Rectangle();
            sh.Area(length,breadth);

        }
    }

    interface IShape
    {
        void Area(double length,double breadth);
    }

    class Square : IShape
    {
        public void Area(double length, double breadth)
        {
            double area=length*breadth;
            Console.WriteLine("Area of Square:" + area);
        }
    }
    class Rectangle : IShape
    {
        public void Area(double length, double breadth)
        {
            double area = length * breadth;
            Console.WriteLine("Area of Rectangle:" + area);
        }
    }
}
