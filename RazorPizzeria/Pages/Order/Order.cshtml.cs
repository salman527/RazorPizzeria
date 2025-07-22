using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Data;
using RazorPizzeria.Models;

namespace RazorPizzeria.Pages.Order
{
    public class OrderModel : PageModel
    {
        public List<PizzaOrder> PizzaOrders = new List<PizzaOrder>();
        private readonly ApplicationDbContext _context;
        public OrderModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            PizzaOrders = _context.PizzaOrders.ToList();
        }
    }
}
