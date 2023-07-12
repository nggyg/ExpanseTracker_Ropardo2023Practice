namespace ExpanseTracker.Data.Models
{
    public class Income
    {
        
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public IncomeType Type { get; set; }
    }
}
