using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace EmployeeSalaryCalculation.Data
{
    [Index(nameof(Id))]
    public class Employee
    {
        [Key]
        [Display(Name="ID")]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public double Salary { get; set; }
        [Display(Name = "Salary With Bonus")]
        public double SalaryWithBonus { get; set; }
        [Display(Name = "Join Date")]
        public DateTime JoinDate { get; set; }
        public bool IsBonusAdded { get; set; } = false;
        public int ReportingPersonId { get; set; }  
        public DateTime CreateDate { get; set; }=DateTime.Now;
        public DateTime UpdateDate { get; set; }= DateTime.Now;

    }
}
