namespace EmployeeSalaryCalculation.Utility
{
    public class Pagination
    {
        public int CurrentPage { get; set; } = 1;
        public int PageSize { get; set; } = 5;
        public int Count { get; set; }
        public int TotalPages => (int)Math.Ceiling(decimal.Divide(Count, PageSize));
        public bool ShowPrevious => CurrentPage > 1;
        public bool ShowNext => CurrentPage < TotalPages;
        public bool ShowFirst => CurrentPage != 1;
        public bool ShowLast => CurrentPage != TotalPages;
        public string Action { get; set; } = default!;
    }
}
