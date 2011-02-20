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

        public ViewResult LongestServing()
        {
            var employee = employeeService.GetLongestServingEmployee();
            var model = new EmployeeViewModel
            {
                HireDate = employee.HireDate,
                Name = employee.Name
            };
            return View(model);
        }
    }
}