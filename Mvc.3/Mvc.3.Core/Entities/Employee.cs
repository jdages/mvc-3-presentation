using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Mvc3.Core.Entities
{
    public class Employee 
    {
        public string Name { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime StartDate { get; set; }
    }

}