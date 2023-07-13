using ExpanseTracker.Data;
using ExpanseTracker.Data.Models;
using Microsoft.AspNetCore.Components;

namespace ExpanseTracker.Services
{
    public class ExpenseService
    {
        
        public readonly ExpanseTrackerContext _context;
        public ExpenseService(ExpanseTrackerContext context)
        {
            _context = context;
        }
        public List<Expense> getExpenses()
        {
            return _context.Expenses.ToList();
        }
        public void addExpense(Expense expense)
        {
            _context.Expenses.Add(expense);
            _context.SaveChanges();
        }
        public void removeExpense(Expense expense)
        {
            _context.Expenses.Remove(expense);
            _context.SaveChanges();
        } 
        
    }
}
