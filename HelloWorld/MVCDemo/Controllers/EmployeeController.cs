using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using MVCDemo.Models; //for Model classes

namespace MVCDemo.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: EmployeeController
        readonly IEFDataAccess dal;
        public EmployeeController(IEFDataAccess dal) //dep injection
        {
            this.dal = dal;
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Home()
        {
            //model object
            var lstEmps = dal.GetEmps();
            //return view with model instance
            return View(lstEmps);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Employee emp)
        {
            //insert the record using dal 
            dal.AddEmployee(emp);
            return RedirectToAction("Home");
        }

        public ActionResult Delete(int id)
        {
            dal.DeleteEmployee(id);
            return RedirectToAction("Home");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            //find the record by id and display in edit view for user to edit
            Employee emp = dal.GetEmps().Find(e=>e.Ecode==id);
            //send the model instance to view 
            return View(emp);
        }
        [HttpPost]
        public ActionResult Edit(Employee emp)
        {
            dal.UpdateEmployee(emp);
            return RedirectToAction("Home");
        }
    }
}
