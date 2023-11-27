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
                        var child = await _context.Employees
                                      .Where(em => em.ReportingPersonId == employee.ReportingPersonId || em.Id == employee.ReportingPersonId)
                                      .OrderBy(em => em.ReportingPersonId).Select(em=>new Employee
                                      {
                                          Id = em.Id,
                                          Name = em.Name,
                                          Position = em.Position,
                                          Salary = em.Salary,
                                          SalaryWithBonus = em.SalaryWithBonus,
                                          JoinDate = em.JoinDate,
                                          ReportingPersonId=em.ReportingPersonId,
                                          IsBonusAdded = em.IsBonusAdded
                                      }).ToListAsync();

                        var parent = await _context.Employees
                                    .Where(em => em.ReportingPersonId == 0)
                                    .OrderBy(em => em.ReportingPersonId)
                                    .Select(em => new Employee
                                    {
                                        Id = em.Id,
                                        Name = em.Name,
                                        Position = em.Position,
                                        Salary = em.Salary,
                                        SalaryWithBonus = em.SalaryWithBonus,
                                        JoinDate = em.JoinDate,
                                        ReportingPersonId=em.ReportingPersonId,
                                        IsBonusAdded = em.IsBonusAdded
                                    }).ToListAsync();


                    
                        var combine = parent.Union(child).OrderBy(m => m.Id);

                        Employee = combine.ToList();
                        employee = null;
                        parent.Clear();
                        child.Clear();
                    }

                    // GetTotal(Employee.Count);
                    CalculateBonus(Employee);
                }
                else
                {
                    Employee = await _context.Employees.Skip(skip)
                      .Take(Pagination.PageSize).ToListAsync();
                     GetTotal();

                }
               
            }
        }
        private void GetTotal(int count = 0)
        {
            if (count > 0)
                Pagination.Count = count;
            else
                Pagination.Count = _context.Employees.Count();
        }
        private void CalculateBonus(IList<Employee> employee)
        {
            DateTime today= DateTime.Now;
            bool isLeapYear = IsLearYear(today.Year);//check leap year
            Employee root = employee.FirstOrDefault(m => m.ReportingPersonId ==0);
            int yearDiff = YearsDifference(root.JoinDate, today);
            foreach (var item in employee)
            {
                Employee imediateManage = employee.FirstOrDefault(m => m.Id == item.ReportingPersonId);
                
               
                if (isLeapYear)
                {
                    CalculateBonusInLeapYear(item,imediateManage, yearDiff);
                }
                else
                {
                    CalculateBonusWithoutLeapYear(item,imediateManage, yearDiff);
                };
            }
        }
        private int YearsDifference(DateTime start, DateTime end)
        {
            return (end.Year - start.Year - 1) +
                (((end.Month > start.Month) ||
                ((end.Month == start.Month) && (end.Day >= start.Day))) ? 1 : 0);
        }
        private bool IsLearYear(int year)
        {
            if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0)) return true;
            else return false;
            
        }

        private void CalculateBonusInLeapYear(Employee employee, Employee imediateManage, int yearDiff)
        {
            employee.SalaryWithBonus = employee.Salary;
            if (yearDiff >= (int)CompareYear.Year && employee.IsBonusAdded)
            {
                employee.SalaryWithBonus += (double)LeapYearBonus.Bonus;
                if(imediateManage != null && employee.JoinDate> imediateManage.JoinDate) employee.SalaryWithBonus+= (double)LeapYearBonus.ExtraBonus;
            }
            else
            {
                employee.SalaryWithBonus += (double)LessThanFourAndLeapYear.Bonus;
                if (imediateManage != null && employee.JoinDate > imediateManage.JoinDate) employee.SalaryWithBonus += (double)LessThanFourAndLeapYear.ExtraBonus;
            }
        }
        private void CalculateBonusWithoutLeapYear(Employee employee, Employee imediateManage, int yearDiff)
        {
            employee.SalaryWithBonus = employee.Salary;
            if (yearDiff >= (int)CompareYear.Year && employee.IsBonusAdded)
            {
                employee.SalaryWithBonus += (double)NonLeapYearBonus.Bonus;
                if (imediateManage != null && employee.JoinDate <= imediateManage.JoinDate) employee.SalaryWithBonus += (double)NonLeapYearBonus.ExtraBonus;
            }
            else
            {
                employee.SalaryWithBonus += (double)LessThanFourAndNotLeapYear.Bonus;
                if (imediateManage != null && employee.JoinDate <= imediateManage.JoinDate) employee.SalaryWithBonus += (double)LessThanFourAndNotLeapYear.ExtraBonus;
            }
        }
        
    }
}
