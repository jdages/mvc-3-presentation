using System.Web.Mvc;
using System.Web.UI.WebControls;
using Mvc3.Core.Entities;
using Mvc3.Core.Services;
using Mvc3.Web.Models.Employee;

namespace Mvc3.Web.Controllers
{
    public class EmployeeController : Controller
    {
        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Create(Employee employee)
        {
            return View();
        }
    }
}