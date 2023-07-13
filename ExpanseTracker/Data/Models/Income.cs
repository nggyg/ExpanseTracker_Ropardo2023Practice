using System.Numerics;

namespace ExpanseTracker.Data.Models
{
    public class Income
    {
        
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public IncomeType Type { get; set; }
        public Income() { }
        public Income(int id, string title, DateTime date, double amount, IncomeType type)
        {
            Id = id;
            Title = title;
            Date = date;
            Amount = amount;
            Type = type;
        }
        public bool isEmpty()
        {
            if (Id == 0 && String.IsNullOrEmpty(Title))
                return true;
            return false;
        }
        public override string ToString()
        {
            return Id + " " + Title + " " + Date.ToString() + " " + Amount + " " + Type;
        }
    }
}
