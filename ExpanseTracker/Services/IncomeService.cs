using ExpanseTracker.Data;
using ExpanseTracker.Data.Models;

namespace ExpanseTracker.Services
{
    public class IncomeService
    {
        public readonly ExpanseTrackerContext _context;
        public IncomeService(ExpanseTrackerContext context)
        {
            _context = context;
        }
        public List<Income> getIncomes()
        {
            return _context.Incomes.ToList();
        }
        public void addIncome(Income income)
        {
            _context.Incomes.Add(income);
            _context.SaveChanges();
        }
        public void removeIncome(Income income)
        {
            _context.Incomes.Remove(income);
            _context.SaveChanges();
        }
        public void updateIncome(Income income)
        {
            _context.Incomes.Remove(income);
            _context.SaveChanges();
            _context.Incomes.Add(income);
            _context.SaveChanges();
        }
        public Income getIncome(int id)
        {
            return _context.Incomes.Find(id);
        }
    }
}
