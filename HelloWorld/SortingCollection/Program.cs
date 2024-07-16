using SortingCollection;
using System.Collections;

namespace SortingCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee { Ecode = 103, Ename = "Ravi", Salary = 3333, Deptid = 203 });
            employees.Add(new Employee { Ecode = 101, Ename = "Rahul", Salary = 1111, Deptid = 201 });
            employees.Add(new Employee { Ecode = 102, Ename = "Ramesh", Salary = 2222, Deptid = 202 });
            employees.Add(new Employee { Ecode = 104, Ename = "John", Salary = 4444, Deptid = 204 });
            employees.Add(new Employee { Ecode = 105, Ename = "Tom", Salary = 5555, Deptid = 205 });

            //sorting
            //employees.Sort();

            foreach (Employee e in employees)
            {
                Console.WriteLine($"{e.Ecode}\t{e.Ename}\t{e.Salary}\t{e.Deptid}");
            }
        }
    }
}


