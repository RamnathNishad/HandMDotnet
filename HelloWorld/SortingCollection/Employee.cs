using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingCollection
{
    internal class Employee //: IComparable<Employee>
    {
        public int Ecode {  get; set; }
        public string Ename {  get; set; }
        public int Salary { get; set; }
        public int Deptid { get; set; }

        public int CompareTo(Employee? other)
        {
            if(this.Ecode>other.Ecode)
            {
                return -1;
            }
            else if(this.Ecode<other.Ecode)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
