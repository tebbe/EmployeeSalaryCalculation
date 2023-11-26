using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EmployeeSalaryCalculation.Data;
using EmployeeSalaryCalculation.Utility;

namespace EmployeeSalaryCalculation.Areas.Salary.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Employee> Employee { get;set; } = default!;

        [BindProperty(SupportsGet = true)]
        public Pagination Pagination { get; set; } = default!;
        public async Task OnGetAsync(int id = 0)
        {
            int skip = (Pagination.CurrentPage - 1) * Pagination.PageSize;
           
            if (_context.Employees != null)
            {
                if (id > 0)
                {
                  var employee= await _context.Employees.FirstOrDefaultAsync(m=>m.Id==id);
                    if(employee != null) {
                        Employee = await _context.Employees
                                      .Where(em => em.ReportingPersonId == employee.ReportingPersonId || em.Id== employee.ReportingPersonId)
                                      .OrderByDescending(em => em.Id).ToArrayAsync();
                    }

                    GetTotal(Employee.Count);
                }
                else
                {
                    Employee = await _context.Employees.Skip(skip)
                      .Take(Pagination.PageSize).ToListAsync();
                    GetTotal();
                }
               // CalculateBonus(Employee);
            }
        }

        private void CalculateBonus(IList<Employee> employee)
        {
            foreach (var item in employee)
            {
                if (IsLearYear(item.JoinDate.Year))
                {

                }
                else
                {

                };
            }
        }

        private bool IsLearYear(int year)
        {
            if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0)) return true;
            else return false;
            
        }

        private void CalculateBonusInLeapYear(IList<Employee> employee)
        {
            
        }
        private void CalculateBonusWithoutLeapYear(IList<Employee> employee)
        {
            
        }
        private void GetTotal(int count=0)
        {
            if (count > 0)
                Pagination.Count = count;
            else
                Pagination.Count = _context.Employees.Count();
        }
    }
}
