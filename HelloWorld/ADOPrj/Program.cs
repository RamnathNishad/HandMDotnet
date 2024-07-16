namespace ADOPrj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //AdoConnected dal=new AdoConnected();
            AdoDisconnected dal=new AdoDisconnected();
            int choice;
            do
            {
                Console.WriteLine("1.Add employee");
                Console.WriteLine("2.Delete employee");
                Console.WriteLine("3.Update employee");
                Console.WriteLine("4.Display employees");
                Console.WriteLine("0.Exit");
                Console.Write("Enter choice:");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        //take user input for record
                        Employee emp = new Employee();
                        Console.Write("Enter ecode:");
                        emp.Ecode = int.Parse(Console.ReadLine());
                        Console.Write("Enter ename:");
                        emp.Ename = Console.ReadLine();
                        Console.Write("Enter salary:");
                        emp.Salary = int.Parse(Console.ReadLine());
                        Console.Write("Enter deptid:");
                        emp.Deptid = int.Parse(Console.ReadLine());

                        //insert the record
                        dal.AddEmployee(emp);
                        Console.WriteLine("Record inserted");
                        break;
                    case 2:
                        //delete 
                        Console.Write("Enter ecode for deletion:");
                        int ec=int.Parse(Console.ReadLine());
                        int count =dal.DeleteEmployee(ec);
                        if(count>0)
                        {
                            Console.WriteLine("Record deleted");
                        }
                        else
                        {
                            Console.WriteLine("Ecode does not exist");
                        }
                        break;
                    case 3:
                        //take user input for updating record
                        Employee employee = new Employee();
                        Console.Write("Enter ecode for update:");
                        employee.Ecode=int.Parse(Console.ReadLine());
                        Console.Write("Enter enamee:");
                        employee.Ename = Console.ReadLine();
                        Console.Write("Enter salary:");
                        employee.Salary = int.Parse(Console.ReadLine());
                        Console.Write("Enter deptid:");
                        employee.Deptid = int.Parse(Console.ReadLine());
                        //update 
                        int n=dal.UpdateEmployee(employee);
                        if(n>0)
                        {
                            Console.WriteLine("Record updated");
                        }
                        else
                        {
                            Console.WriteLine("Record does not exist");
                        }
                        break;
                    case 4:
                        //display all emps
                        List<Employee> lstEmps = dal.GetEmps();
                        foreach (Employee e in lstEmps)
                        {
                            Console.WriteLine($"{e.Ecode}\t{e.Ename}\t{e.Salary}\t{e.Deptid}");
                        }
                        break;
                    case 0:
                        //exit 
                        break;
                    default:
                        Console.WriteLine("invalid choice");
                        break;
                }
            }while(choice!=0);
        }
    }
}
