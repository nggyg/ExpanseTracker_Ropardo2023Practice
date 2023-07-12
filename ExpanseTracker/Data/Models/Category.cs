namespace ExpanseTracker.Data.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Expense> Expenses { get; set; }=new List<Expense>();
        public Category(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public Category()
        {
        }
    }
}
