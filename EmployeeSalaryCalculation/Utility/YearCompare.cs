namespace EmployeeSalaryCalculation.Utility
{
    public enum CompareYear
    {
        Year=4,
    }
    public enum LeapYearBonus
    {
        Bonus = 10000,
        ExtraBonus = 2000
    }
    public enum NonLeapYearBonus
    {
        Bonus = 8000,
        ExtraBonus = 1000
    }
    public enum LessThanFourAndLeapYear
    {
        Bonus = 5000,
        ExtraBonus = 1000
    }
    public enum LessThanFourAndNotLeapYear
    {
        Bonus = 3000,
        ExtraBonus = 500
    }
}
