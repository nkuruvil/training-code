using System.Collections.Generic;
using PizzaStore.Domain.Models;

namespace PizzaStore.Client
{
    internal class Startup
    {
        public Pizza CreatePizza(string size, string crust, List<string> toppings)
        {
            var pizza = new Pizza(size, crust, toppings);

            return pizza;
        }
    }
}