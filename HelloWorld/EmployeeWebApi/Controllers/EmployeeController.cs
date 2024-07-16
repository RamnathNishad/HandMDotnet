using EmployeeWebApi.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmployeeWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        readonly EmpDbContext dbCtx;
        public EmployeeController(EmpDbContext dbCtx)
        {
            this.dbCtx = dbCtx;
        }

        // GET: api/<EmployeeController>
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return dbCtx.employees.ToList();
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public Employee Get(int id)
        {
            return dbCtx.employees.Find(id);
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public void Post([FromBody] Employee emp)
        {
            dbCtx.employees.Add(emp);
            dbCtx.SaveChanges();
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Employee emp)
        {
            //find the record and update
            Employee record = dbCtx.employees.Find(emp.Ecode);
            if(record!=null)
            {
                record.Ename = emp.Ename;
                record.Salary = emp.Salary;
                record.Deptid = emp.Deptid;
                dbCtx.SaveChanges();
            }
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            //find the record and delete it
            Employee employee = dbCtx.employees.Find(id);
            if (employee != null)
            {
                dbCtx.employees.Remove(employee);
                dbCtx.SaveChanges();
            }
        }
    }
}
