using Microsoft.EntityFrameworkCore;
using ExpanseTracker.Data.Models;


namespace ExpanseTracker.Data
{
    public class ExpanseTrackerContext: DbContext
    {
        public ExpanseTrackerContext(DbContextOptions<ExpanseTrackerContext> options) : base(options) { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Income> Incomes { get; set; }

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
            modelBuilder.Entity<Category>()
                .HasMany(e => e.Expenses)
                .WithOne(e => e.Category)
                .HasForeignKey(e=>e.CategoryId)
                .IsRequired();
            modelBuilder.Entity<Expense>().HasData(new Expense[]
            {
                new Expense(){Id=1,Title="Hawaii",Date=DateTimeOffset.Parse("2022-07-18").UtcDateTime,Amount=23000,Planned=true,CategoryId=2},
                new Expense(){Id=2,Title="Bubble Gum",Date=DateTimeOffset.Parse("2023-07-18").UtcDateTime,Amount=3.50,Planned=false,CategoryId=1},
                new Expense(){Id=3,Title="Sun glasses",Date=DateTimeOffset.Parse("2012-07-18").UtcDateTime,Amount=20,Planned=true,CategoryId=5},
                new Expense(){Id=4,Title="Calculator",Date=DateTimeOffset.Parse("2031-07-18").UtcDateTime,Amount=25,Planned=false,CategoryId=4},
            });
            modelBuilder.Entity<Income>().HasData(new Income[]
            {
                new Income(){Id=1,Title="Ropardo_January",Date=DateTimeOffset.Parse("2022-02-01").UtcDateTime,Amount=2500,Type=IncomeType.Salary},
                new Income(){Id=2,Title="Cash on the street",Date=DateTimeOffset.Parse("2022-09-21").UtcDateTime,Amount=0.4,Type=IncomeType.Lucky_Winnings},
                new Income(){Id=3,Title="Erasmus",Date=DateTimeOffset.Parse("2012-09-15").UtcDateTime,Amount=500,Type=IncomeType.Scholarship},
            });
        }
        public void add(Category category)
        {
            Categories.Add(category);
        }
    }
}
