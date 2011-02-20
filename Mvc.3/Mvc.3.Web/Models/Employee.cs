using System;
using System.Collections.Generic;

namespace Mvc._3.Web.Models
{
    public class Employee
    {
        public string Name { get; set; }
        public DateTime HireDate { get; set; }

        public static IEnumerable<Employee> GenerateSampleEmployees()
        {
            return new List<Employee>
                       {
                           new Employee
                               {
                                   Name = "Peyton Manning",
                                   HireDate = new DateTime(1960, 1, 1)
                               },
                           new Employee
                               {
                                   Name = "Bob Sanders",
                                   HireDate = new DateTime(1970, 1, 1)
                               },
                           new Employee
                               {
                                   Name = "Jeff Saturday",
                                   HireDate = new DateTime(1980, 1, 1)
                               },
                       };
        }
    }
}