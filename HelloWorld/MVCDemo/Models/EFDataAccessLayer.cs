namespace MVCDemo.Models
{
    public interface IEFDataAccess
    {
        List<Employee> GetEmps();
        void AddEmployee(Employee emp);
        void DeleteEmployee(int id);
        void UpdateEmployee(Employee emp);
    }

    public class EFDataAccessLayer : IEFDataAccess
    {
        EmpDbContext dbCtx;
        public EFDataAccessLayer(EmpDbContext dbCtx)
        {
            this.dbCtx=dbCtx;
        }
        public List<Employee> GetEmps()
        {
            return dbCtx.employees.ToList();
        }
        public void AddEmployee(Employee emp)
        {
            dbCtx.employees.Add(emp);
            dbCtx.SaveChanges();
        }
        public void DeleteEmployee(int id)
        {
            //find the record 
            Employee emp = dbCtx.employees.Find(id);
            //delete the record
            dbCtx.employees.Remove(emp);
            dbCtx.SaveChanges();
        }
        public void UpdateEmployee(Employee emp)
        {
            //find the record 
            Employee employee = dbCtx.employees.Find(emp.Ecode);
            //update the record
            employee.Ename= emp.Ename;
            employee.Salary= emp.Salary;
            employee.Deptid= emp.Deptid;
            dbCtx.SaveChanges();
        }
    }
}
