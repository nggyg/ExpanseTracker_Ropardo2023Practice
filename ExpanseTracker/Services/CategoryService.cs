using ExpanseTracker.Data;
using ExpanseTracker.Data.Models;

namespace ExpanseTracker.Services
{
    public class CategoryService
    {
        private readonly ExpanseTrackerContext _context;

        public CategoryService(ExpanseTrackerContext context)
        {
            _context = context;
        }
        public List<Category> getCategories()
        {
            return _context.Categories.ToList();
        }
    }
}
