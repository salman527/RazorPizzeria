using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Models;

namespace RazorPizzeria.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> fakePizzaDB = new List<PizzasModel>()
        {
         new PizzasModel(){ImageTitle="BrandPizza",PizzaName="BrandPizza",BasePrice=2, TomatoSauce=true,Cheese=true,FinalPrice=4},
         new PizzasModel(){ImageTitle="BrandPizza",PizzaName="BrandPizza",BasePrice=2, TomatoSauce=true,Cheese=true,FinalPrice=4},
         new PizzasModel(){ImageTitle="BrandPizza",PizzaName="BrandPizza",BasePrice=2, TomatoSauce=true,Cheese=true,FinalPrice=4},
         new PizzasModel(){ImageTitle="BrandPizza",PizzaName="BrandPizza",BasePrice=2, TomatoSauce=true,Cheese=true,FinalPrice=4},
         new PizzasModel(){ImageTitle="BrandPizza",PizzaName="BrandPizza",BasePrice=2, TomatoSauce=true,Cheese=true,FinalPrice=4},
        };
       
        //public string? imagetitle { get; set; }
        //public string? pizzaname { get; set; }
        //public float baseprice { get; set; }
        //public bool tomatosauce { get; set; }
        //public bool cheese { get; set; }
        //public bool peproni { get; set; }
        //public bool mushroom { get; set; }
        //public bool tuna { get; set; }
        //public bool pineapple { get; set; }
        //public bool ham { get; set; }
        //public bool beef { get; set; }
        //public float finalprice { get; set; }
        public void OnGet()
        {
        }
    }
}
