using Mvc3.Core.Entities;
using Mvc3.Core.Services;

namespace Mvc3.Test
{
    public class When_fetching_the_longest_serving_employee
    {
        private Employee result;

        public void SetUp()
        {
            result = new EmployeeService().GetLongestServingEmployee();
        }

        public void Then_we_should_get_jeff()
        {
            //Assert.AreEqual("Jeff Saturday", result.Name);
        }
    }
}