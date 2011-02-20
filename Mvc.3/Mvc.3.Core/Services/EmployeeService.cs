using System;
using System.Linq;
using Mvc3.Core.Entities;

namespace Mvc3.Core.Services
{
    public interface IEmployeeService
    {
        Employee GetLongestServingEmployee();
    }

    public class EmployeeService : IEmployeeService
    {
        public Employee GetLongestServingEmployee()
        {
            return Employee
                .GenerateSampleEmployees()
                .OrderByDescending(a => a.HireDate)
                .First();
        }
    }
}