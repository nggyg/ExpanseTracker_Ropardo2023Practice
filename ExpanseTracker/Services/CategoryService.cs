using ExpanseTracker.Data;
using ExpanseTracker.Data.Models;

namespace ExpanseTracker.Services
{
    public class CategoryService
    {
        public readonly ExpanseTrackerContext _context;

        public CategoryService(ExpanseTrackerContext context)
        {
            _context = context;
        }
        public List<Category> getCategories()
        {
            return _context.Categories.ToList();
        }
        public void addCategory(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
        }
        public void removeCategory(Category category)
        {
            _context.Categories.Remove(category);
            _context.SaveChanges();
        }
        public Category getCategory(int id)
        {
            return _context.Categories.Find(id);
        }
    }
}
