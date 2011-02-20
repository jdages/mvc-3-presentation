using System;
using System.Collections.Generic;

namespace Mvc._3.Web.Models
{
    public class EmployeeModel
    {
        public string Name { get; set; }
        public DateTime HireDate { get; set; }

        public static IEnumerable<EmployeeModel> GenerateSampleEmployees()
        {
            return new List<EmployeeModel>
                       {
                           new EmployeeModel
                               {
                                   Name = "Peyton Manning",
                                   HireDate = new DateTime(1960, 1, 1)
                               },
                           new EmployeeModel
                               {
                                   Name = "Bob Sanders",
                                   HireDate = new DateTime(1970, 1, 1)
                               },
                           new EmployeeModel
                               {
                                   Name = "Jeff Saturday",
                                   HireDate = new DateTime(1980, 1, 1)
                               },
                       };
        }
    }
}