using Microsoft.AspNetCore.Mvc.Rendering;

namespace EmployeeSalaryCalculation.Utility
{
    public class PageHelper
    {
        public static List<SelectListItem> GetPageSizeList()
        {
            var options = new List<SelectListItem>
            {
                new SelectListItem{ Value = "5", Text = "5"},
                new SelectListItem{ Value = "10", Text = "10"},
                new SelectListItem{ Value = "20", Text = "20"},
                new SelectListItem{ Value = "50", Text = "50"},
                new SelectListItem{ Value = "100", Text = "100"}
            };
            return options;
        }
    }
}
