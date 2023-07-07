namespace ExpanseTracker.Data
{
    public class Category
    {
        private int id { get; set; }
        private string name { get; set; }
        public Category(string name)
        {
            this.name = name;
        }
    }
}
