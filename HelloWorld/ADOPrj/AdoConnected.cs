using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOPrj
{
    public class AdoConnected
    {
        SqlConnection con;
        SqlCommand cmd;
        public AdoConnected()
        {
            //con = new SqlConnection("Server=localhost;Database=SampleDB;User Id=sa;password=dockerStrongPwd123");
            con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SampleDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;");
        }
        public List<Employee> GetEmps()
        {
            List<Employee> lstEmps=new List<Employee>();

            //configure the command for SELECT
            cmd = new SqlCommand("select * from employees",con);
            //open the connection
            con.Open();
            //execute the command
            SqlDataReader sdr = cmd.ExecuteReader();
            //navigate the records one by one
            while (sdr.Read())
            {
                Employee emp = new Employee
                {
                    Ecode = sdr.GetInt32(0),
                    Ename = sdr.GetString(1),
                    Salary=sdr.GetInt32(2),
                    Deptid=sdr.GetInt32(3)
                };
                //add it to the collection
                lstEmps.Add(emp);
            }
            //close the connection
            con.Close();
            //return the result
            return lstEmps;
        }

        public void AddEmployee(Employee emp)
        {
            //configure the command for INSERT statement
            cmd = new SqlCommand("insert into employees values(@ec,@en,@sal,@did)",con);
            //specify the parameters values
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@ec", emp.Ecode);
            cmd.Parameters.AddWithValue("@en", emp.Ename);
            cmd.Parameters.AddWithValue("@sal", emp.Salary);
            cmd.Parameters.AddWithValue("@did", emp.Deptid);
            //open the connection
            con.Open();
            //execute the command
            cmd.ExecuteNonQuery();
            //close the connection
            con.Close();
        }

        public int DeleteEmployee(int ecode)
        {
            //configure the command for delete;
            cmd = new SqlCommand("delete from employees where ecode=@ec", con);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@ec", ecode);
            //open connection
            con.Open();
            //execute the command
            int count =cmd.ExecuteNonQuery();
            //close the connection
            con.Close();
            //return records affected
            return count;
        }

        public int UpdateEmployee(Employee emp)
        {
            //configure command for UPDATE 
            cmd = new SqlCommand("update employees set ename=@en,salary=@sal,deptid=@did where ecode=@ec", con);
            //specify the parameters values
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@ec", emp.Ecode);
            cmd.Parameters.AddWithValue("@en", emp.Ename);
            cmd.Parameters.AddWithValue("@sal", emp.Salary);
            cmd.Parameters.AddWithValue("@did", emp.Deptid);
            //open the connection
            con.Open();
            //execute the command
            int count=cmd.ExecuteNonQuery();
            //close the connection
            con.Close();
            //return records affected
            return count;
        }
    }
}
