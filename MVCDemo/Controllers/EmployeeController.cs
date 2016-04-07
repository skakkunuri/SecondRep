using System.Linq;
using System.Web.Mvc;
using EmployeeDataAccess;

namespace MVCDemo.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult ListEmployees()
        {
            EmployeeDBEntities empDet = new EmployeeDBEntities();
            ViewBag.emps = empDet.Employees.ToList();

            return View(ViewBag.emps);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(FormCollection fcCollection)
        {
            foreach (var key in  fcCollection.AllKeys)
            {
                Response.Write("Key = " + key);
                Response.Write("Value = " + fcCollection[key]);
            }
            return View();
        }
    }
}