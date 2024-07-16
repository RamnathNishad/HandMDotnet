namespace SOLIDDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AreaCalculator calc=new AreaCalculator();
            Shape sh1 = new Circle();
            calc.CalculateArea(sh1);

            sh1 = new Square();
            calc.CalculateArea(sh1);

            sh1 = new Rectangle();
            calc.CalculateArea(sh1);

            //SingleTonDemo o = new SingleTonDemo();

            SingleTonDemo obj = SingleTonDemo.CreateInstance();
            Console.WriteLine(obj.GetData());

            SingleTonDemo obj2= SingleTonDemo.CreateInstance();
            Console.WriteLine(obj2.GetData());


            Toy t1 = new Toy();
            t1.Data = 100;
            Toy t2 = (Toy)t1.Clone();

            t2.Data = 200;
            Console.WriteLine("T1 data:"+ t1.Data);
            Console.WriteLine("T2 data:" + t2.Data);


        }
    }


    //class AreaCalculator
    //{
    //    public double Height { get; set; }
    //    public double Width { get; set; }

    //    public void Area(int shapeType)
    //    {
    //        double area;
    //        switch (shapeType)
    //        {
    //            case 1: //square
    //                area = Height * Width;
    //                Console.WriteLine("Area of square:" + area);
    //                break;
    //            case 2: //rectangle
    //                area = Height * Width;
    //                Console.WriteLine("Area of rectangle:" + area);
    //                break;
    //        }
    //    }
}

abstract class Shape
{
    public abstract double Area();
}

class Circle : Shape
{
    public override double Area()
    {
        double raduis = 10;
        return Math.PI * raduis*raduis;
    }
}
class Square : Shape
{
    public override double Area()
    {
        double side=10;
        return side*side;
    }
}

class Rectangle : Shape
{
    public override double Area()
    {
        double height=100, width=50;
        return height*width;
    }
}
class AreaCalculator
{
    public void CalculateArea(Shape sh)
    {
        Console.WriteLine(sh.Area());
    }

}



interface IVehicle
{
    void SetMaxSpeed();    
}


class Vehicle : IVehicle
{
    int maxSpeed;
    public void SetMaxSpeed()
    {
        maxSpeed = 100;
    }
}
class Car : IVehicle
{
    int maxSpeed;
    public void SetMaxSpeed()
    {
        maxSpeed = 200;
    }
}


//class Vehicle
//{
//    protected int maxSpeed;
//    public void SetMaxSpeed()
//    { 
//        maxSpeed = 100; 
//    }
//}

//class Car : Vehicle
//{
//    public void SetMaxSpeed()
//    {
//        maxSpeed = 200;
//    }
//}

class LoggerCreator
{
    public ILogger CreateLogger(int type)
    {
        ILogger logger=LoggerFactory.CreateLogger(type);
        return logger;
    }
}

class LoggerFactory
{
    public static ILogger CreateLogger(int type)
    {
        switch(type)
        {
            case 1:
                return new TextLogger();
                break;
            case 2:
                return new XmlLogger();
                break;
            default:
                return null;
                break;
        }
    }
}

class Logger
{
    readonly ILogger logger;
    public Logger(ILogger logger)
    {
        logger.LogData("some info");
    }

    //public void LogData(string msg)
    //{
    //    //log into text logger
    //    TextLogger logger= new TextLogger();

    //}

}

interface ILogger
{
    void LogData(string msg);
}
class TextLogger : ILogger
{
    public void LogData(string msg)
    {
        throw new NotImplementedException();
    }
}
class XmlLogger : ILogger
{
    public void LogData(string msg)
    {
        throw new NotImplementedException();
    }
}
class EventLogger : ILogger
{
    public void LogData(string msg)
    {
        throw new NotImplementedException();
    }
}

class SingleTonDemo
{
    int data = 100;
    static SingleTonDemo instance;
    private SingleTonDemo() { }
    public static SingleTonDemo CreateInstance()
    {        
        if(instance==null)
        {
            instance=new SingleTonDemo();
        }
        return instance;
    }
    public int GetData()
    {
        return data;
    }
}

//Prototype design pattern:- It is used for making a copy of an object instead
//of creating a new object everytime when needed.
//It helps in avoiding the utilization of resources and efforts used to create 
//a new object evrytime.

//we do using cloning of the existing instance

class Toy : ICloneable
{
    public int Data { get; set; }

    public object Clone()
    {
        Toy toy = new Toy();
        return toy;
    }
}



//2. Structural Design patterns:- it works on the design pattern on how the 
//object is composed.

//Adapter pattern:- If u want to communicate between two incompatible types,
//we use this pattern using an adapter interface

//Object A implements  ----Adapter interface(objectB f1)---- Object B(f1)

//Flyweight pattern:-  it works on caching the object with common features 
//which may be needed at multiple places. 

//object---f1,f2,f3  (Char with some font,style,color):- whenever it is needed
//again with the same state of the object, it can be used from the cache location

//Facade pattern:- if there is a complex interface , using facade pattern 
//we can have a simplied interface to communicte object.

//class A------interface(complex)------simple facade interface
//e.g. OS low level complex interface is used using a facade simple interface
//by shell command prompt.

//MVC pattern:- mostly used for Web application in which responsibilities are
//divided into 3 components Model-View-Controller to have better modularity, 
//decoupled application and enhanced testibility.
//Model:- Application entities or data are defined along with their business logic
//View:- user interface to input and output
//Controller:- It accepts the request and return the View by combining with
//Model.

//Front Controller:- Access of resource(Views) in MVC pattern is decided by
// the front controller e.g. routing and navigation using urls


//Proxy pattern:- The target object is communicated using a proxy interface and
//client feels that it is directly using the target object.

//normally used in services communication using proxy of the services.


//Decorator:- If multiple similar functionalities are needed for more than one
////type of object, then instead of redefining again and again in all types,
// we can create a decorator type in the main type only once.

//class Decorator
//F1
//F2
//F3

//type : Decorator

//classA : type
// Task1
// Task2
// Task3


//classB : type
// Task1
// Task2
// Task3






























