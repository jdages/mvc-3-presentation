using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Mvc3.Core.Entities
{
    public class Employee 
    {
        public string Name { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime StartDate { get; set; }
    }

    public class MustStartWithA : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var stringValue = (string) value;
            return stringValue.StartsWith("A") || stringValue.StartsWith("a");
        }

    }
    
}



