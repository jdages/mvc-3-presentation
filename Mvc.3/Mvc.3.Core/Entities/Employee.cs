using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Mvc3.Core.Entities
{
    public class Employee
    {
        [CantStartWithA]
        public string Name { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime StartDate { get; set; }


    }

    public class CantStartWithA : ValidationAttribute, IClientValidatable
    {
        
        public override bool IsValid(object value)
        {
            return true;
        }

        public IEnumerable<ModelClientValidationRule> GetClientValidationRules(ModelMetadata metadata, ControllerContext context)
        {
            var rule = new ModelClientValidationRule();
            rule.ErrorMessage = "Field can't start with a";
            rule.ValidationType = "startwitha";
            rule.ValidationParameters.Add("bonus", "HireDate");
            yield return rule;
        }
    }

    
}



