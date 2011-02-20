using System.Web.Mvc;
using System.Web.UI.WebControls;
using Mvc3.Core.Services;
using Mvc3.Web.Models.Employee;

namespace Mvc3.Web.Controllers
{
    public class EmployeeController : Controller
    {
        private IEmployeeService employeeService;

        public EmployeeController(IEmployeeService employeeService )
        {
            this.employeeService = employeeService;
        }

        [HttpGet]
        public ViewResult LongestServing()
        {
            var model = GetEmployeeModel();
            return View(model);
        }

        [NonAction]
        private EmployeeViewModel GetEmployeeModel()
        {
            var employee = employeeService.GetLongestServingEmployee();
            return new EmployeeViewModel
                       {
                           HireDate = employee.HireDate,
                           Name = employee.Name
                       };
        }
    }
}