namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Node n=null;
            n=InsertFront(n, 10);
            n=InsertFront(n, 20);
            n=InsertFront(n, 30);
            //Traverse(n);
            n = InsertEnd(n, 40);
            n = InsertEnd(n, 50);
            //Traverse(n);

            Sample s1 = new Sample();
            s1.data = 100;

            Sample s2 =(Sample) s1.Clone();
            s2.data = 200;

            Console.WriteLine(s1.data+" "+s2.data);

        }
        static Node InsertFront(Node n,int d)
        {
            //Node temp = n;
            Node new_node = new Node(d);
            new_node.next = n;
            n = new_node;
            return n;
        }
        static Node InsertEnd(Node n, int d)
        {
            Node new_node = new Node(d);
            Node temp = n;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            temp.next = new_node;
            return n;
        }
        static void Traverse(Node n)
        {
            Node temp = n;
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }
        //internal void Push(int value)
        //{
        //    Node newNode = new Node(value);

        //    if (top == null)
        //    {
        //        newNode.next = null;
        //    }
        //    else
        //    {
        //        newNode.next = top;
        //    }

        //    top = newNode;
        //    Console.WriteLine("{0} pushed to stack", value);
        //}
    }

    class Node
    {
        internal int data;
        internal Node next;
        public Node(int data)
        {
            this.data = data;
            this.next = null;
        }
    }

    class Demo
    {
        private static Demo instance;
        private Demo() { }
        public static Demo GetInstance()
        {
            if(instance == null)
                instance = new Demo();
            return instance;
        }
    }

    class Sample : ICloneable
    {
        public int data {  get; set; }
        public object Clone()
        {            
            return new Sample();
        }
    }
}
