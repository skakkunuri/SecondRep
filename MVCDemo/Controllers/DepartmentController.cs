using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class DepartmentController : Controller
    {
        // GET: Department
        public ActionResult Index()
        {
            return View();
        }
    }
}