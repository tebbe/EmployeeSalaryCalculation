using Microsoft.EntityFrameworkCore;

namespace EmployeeSalaryCalculation.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
                
        }
        public DbSet<Employee> Employees { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Employee>()
            .HasData(
                new Employee{Id = 1,Name= "Yehfes ", Position= "General Manager", Salary=50000.90, SalaryWithBonus =0,JoinDate=new DateTime( 2017, 03,01),IsBonusAdded=true,ReportingPersonId=0,CreateDate=DateTime.Now,UpdateDate=DateTime.Now},
                new Employee{Id = 2,Name= "John", Position= "General Manager", Salary=50000.90, SalaryWithBonus =0,JoinDate=new DateTime(2018, 01, 01),IsBonusAdded=true,ReportingPersonId=0,CreateDate=DateTime.Now,UpdateDate=DateTime.Now},
                new Employee{Id = 3,Name= "Ron", Position= "Manager", Salary = 40000.50, SalaryWithBonus =0,JoinDate=new DateTime(2017, 02, 01),IsBonusAdded=true,ReportingPersonId=1,CreateDate=DateTime.Now,UpdateDate=DateTime.Now},
                new Employee{Id = 4,Name= "Jaky",Position= "Manager", Salary = 40000.50, SalaryWithBonus =0,JoinDate=new DateTime(2018, 02, 01),IsBonusAdded=true,ReportingPersonId=2,CreateDate=DateTime.Now,UpdateDate=DateTime.Now},
                new Employee{Id = 5,Name= "Jack", Position= "Office Executive", Salary = 20000.50, SalaryWithBonus =0,JoinDate=new DateTime(2019, 02, 01),IsBonusAdded=true,ReportingPersonId=4,CreateDate=DateTime.Now,UpdateDate=DateTime.Now},
                new Employee{Id = 6,Name= "Jane", Position= "Office Executive", Salary = 20000.50, SalaryWithBonus=0,JoinDate=new DateTime(2017, 01, 01),IsBonusAdded=true,ReportingPersonId=3,CreateDate=DateTime.Now,UpdateDate=DateTime.Now},
                new Employee{Id =7,Name= "Hun", Position= "Office Executive", Salary = 20000.50, SalaryWithBonus=0,JoinDate=new DateTime(2019, 01, 01),IsBonusAdded=false,ReportingPersonId=4,CreateDate=DateTime.Now,UpdateDate=DateTime.Now},
                new Employee{Id =8,Name= "Amber",Position= "Office Executive", Salary = 20000.50, SalaryWithBonus=0,JoinDate=new DateTime(2019, 02, 01),IsBonusAdded=true,ReportingPersonId=3,CreateDate=DateTime.Now,UpdateDate=DateTime.Now},
                new Employee{Id = 9,Name= "Nick",Position= "Office Executive", Salary = 20000.50, SalaryWithBonus=0,JoinDate=new DateTime(2019, 02, 01),IsBonusAdded=true,ReportingPersonId=4,CreateDate=DateTime.Now,UpdateDate=DateTime.Now},
                new Employee{Id = 10,Name= "Laila",Position= "Office Executive", Salary = 20000.50, SalaryWithBonus=0,JoinDate=new DateTime(2018, 01, 01),IsBonusAdded=false,ReportingPersonId=4,CreateDate=DateTime.Now,UpdateDate=DateTime.Now},
                new Employee{Id = 11,Name="Adam",Position= "Office Executive", Salary = 20000.50, SalaryWithBonus=0,JoinDate=new DateTime(2019, 01, 01),IsBonusAdded=true,ReportingPersonId=3,CreateDate=DateTime.Now,UpdateDate=DateTime.Now},
                new Employee{Id = 12,Name= "Joss",Position= "Office Executive", Salary = 20000.50, SalaryWithBonus=0,JoinDate=new DateTime(2019, 02, 01),IsBonusAdded=true,ReportingPersonId=3,CreateDate=DateTime.Now,UpdateDate=DateTime.Now},
                new Employee{Id =13,Name= "Nissan",Position= "Office Executive", Salary = 20000.50, SalaryWithBonus=0,JoinDate=new DateTime(2019, 01, 01),IsBonusAdded=false,ReportingPersonId=4,CreateDate=DateTime.Now,UpdateDate=DateTime.Now},
                new Employee{Id = 14,Name= "Adriano",Position= "Office Executive", Salary = 20000.50, SalaryWithBonus=0,JoinDate=new DateTime(2019, 01, 01),IsBonusAdded=true,ReportingPersonId=4,CreateDate=DateTime.Now,UpdateDate=DateTime.Now}
               );
        }
    }
}
