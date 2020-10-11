
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using TemaParcursTutorialASP.Models;
using HttpGetAttribute = System.Web.Http.HttpGetAttribute;
using HttpPostAttribute = System.Web.Mvc.HttpPostAttribute;

namespace TemaParcursTutorialASP.Controllers
{
    public class EmployeeController : Controller
    {
       readonly Employee employees;
        public EmployeeController()
        {
            employees = new Employee();
        }

        [HttpGet]
        public ActionResult Index()
        {

            List<Employee> employees1 = employees.GetAll();

            return View(employees1);
        }

        [HttpGet]
        public ActionResult View(int id)
        {
            var employee1 = employees.GetById(id);

            return View(employee1);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                employees.Add(employee);

                return RedirectToAction("Index");
            }

            return View(employees);
        }



        public ActionResult Edit(int Id)
        {
            var emp = Employee.employeeList.Where(s => s.EmployeeId == Id).FirstOrDefault();

            return View(emp);
        }

        [HttpPost]
        public ActionResult Edit(Employee Em)
        {
            var empl = Employee.employeeList.Where(e => e.EmployeeId == Em.EmployeeId).FirstOrDefault();


            Employee.employeeList.Remove(empl);
            Employee.employeeList.Add(Em);
            return RedirectToAction("Index");
        }
    }
}


