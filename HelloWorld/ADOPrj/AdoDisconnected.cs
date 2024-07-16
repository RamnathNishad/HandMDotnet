using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient; //for SqlConnection,SqlCommand,SqlDataAdapter
using System.Data; //for DataSet

namespace ADOPrj
{
    public class AdoDisconnected
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        public AdoDisconnected()
        {
            //configure connection
            con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SampleDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;");
            //configure command for taking records for manipulation
            cmd = new SqlCommand("select * from employees", con);
            //configure DataAdapter
            da = new SqlDataAdapter(cmd);
            //fill the DataSet using DataAdapter
            ds=new DataSet();
            da.Fill(ds, "employees");
            //add primary key constraint
            ds.Tables[0].Constraints.Add("pk", ds.Tables[0].Columns[0], true);
        }
        public List<Employee> GetEmps()
        {
            List<Employee> lstEmps=new List<Employee>();
            //Traverse the records from DataSet
            foreach(DataRow row in ds.Tables[0].Rows)
            {
                //take each row and add to the collection
                Employee employee = new Employee
                {
                    Ecode = (int)row[0],
                    Ename = row[1].ToString(),
                    Salary = (int)row[2],
                    Deptid=(int)row[3]
                };
                //add the record to the List
                lstEmps.Add(employee);
            }
            //return the result
            return lstEmps;
        }
        public void AddEmployee(Employee emp)
        {
            //create a new record in the DataSet Table
            DataRow dr = ds.Tables[0].NewRow();
            //specify the values of this row's columns
            dr[0] = emp.Ecode;
            dr[1]=emp.Ename;
            dr[2]=emp.Salary;
            dr[3]=emp.Deptid;
            //Add this new row with the DataSet Table's Rows 
            ds.Tables[0].Rows.Add(dr);
            //configure DataAdapter for Insert operation
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            //save changes to backend using DataAdapter from DataSet
            da.Update(ds, "employees");
        }
        public int DeleteEmployee(int ecode)
        {
            //find the row in DataSet Rows collection
            DataRow dr = ds.Tables[0].Rows.Find(ecode);
            if (dr != null)
            {
                //delete the row found
                dr.Delete();
                //save changes in DB using DataAdapter
                //configure DataAdapter for delete
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                da.Update(ds, "employees");
                return 1;
            }
            return 0;
        }
        public int UpdateEmployee(Employee emp)
        {
            //find the record in DataSet table rows 
            DataRow dr = ds.Tables[0].Rows.Find(emp.Ecode);
            if (dr != null)
            {
                //update the record values
                dr[1] = emp.Ename;
                dr[2] = emp.Salary;
                dr[3]=emp.Deptid;
                //save changes to DB using DataAdapter
                //configure DataAdapter for Update
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                da.Update(ds, "employees");
                return 1;
            }
            return 0; 
        }
    }
}






