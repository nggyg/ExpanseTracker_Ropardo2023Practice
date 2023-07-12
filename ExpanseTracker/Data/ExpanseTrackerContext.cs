using Microsoft.EntityFrameworkCore;
using ExpanseTracker.Data.Models;


namespace ExpanseTracker.Data
{
    public class ExpanseTrackerContext: DbContext
    {
        public ExpanseTrackerContext(DbContextOptions<ExpanseTrackerContext> options) : base(options) { }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(new Category[]
            {
                new Category(1,"Food"),
                new Category(2,"Travel"),
                new Category(3,"Entertainment"),
                new Category(4,"Education"),
                new Category(5,"Clothes"),
                new Category(6,"House"),
            });
        }
        public void add(Category category)
        {
            Categories.Add(category);
        }
    }
}
