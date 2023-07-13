using ExpanseTracker.Services;

namespace ExpanseTracker.Data.Models
{
    public class Expense
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public bool Planned { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public void assignContetCategory(ExpanseTrackerContext context,int id)
        {
            CategoryService CS=new(context);
            CategoryId = id;
            Category = CS.getCategory(id);
        }
        public Expense() { }
        
        public Expense(int id, string title, DateTime date, double amount, bool planned)
        {
            Id = id;
            Title = title;
            Date = date;
            Amount = amount;
            Planned = planned;
        }
        
        public override string ToString()
        {
            return Id+" "+Title+" "+Date.ToString()+" " + Amount + " " + Planned + " " + CategoryId;
        }
        public bool isEmpty()
        {
            if(Id==0 && String.IsNullOrEmpty(Title)) 
                return true;
            return false;
        }
    }
}
