using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Models;
namespace RazorPizzeria.Pages.Forms
{
    public class CustomPizzaModel : PageModel
    {
        [BindProperty]
        public PizzasModel pizza { get; set; }
        public float PizzaPrice { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            PizzaPrice = pizza.BasePrice;
            if (pizza.TomatoSauce) PizzaPrice += 1;
            if (pizza.Cheese) PizzaPrice += 1;
            if (pizza.Peproni) PizzaPrice += 1;
            if (pizza.TomatoSauce) PizzaPrice += 1;
            if (pizza.Mushroom) PizzaPrice += 1;
            if (pizza.Pineapple) PizzaPrice += 10;
            if (pizza.Ham) PizzaPrice += 1;
            if (pizza.Beef) PizzaPrice += 1;
            if (pizza.Tuna) PizzaPrice += 1;
            return RedirectToPage("/Checkout/Checkout", new { pizza.PizzaName, PizzaPrice });
        }
    }
}
