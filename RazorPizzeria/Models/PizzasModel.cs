﻿using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPizzeria.Models
{
    public class PizzasModel
    {
        public string ImageTitle { get; set; }
        public string PizzaName { get; set; }
        public float BasePrice { get; set; }
        public bool TomatoSauce { get; set; }
        public bool Cheese { get; set; }
        public bool Peproni { get; set; }
        public bool Mushroom { get; set; }
        public bool Tuna { get; set; }
        public bool Pineapple { get; set; }
        public bool Ham { get; set; }
        public bool Beef { get; set; }
        public float FinalPrice { get; set; }
    }
}
