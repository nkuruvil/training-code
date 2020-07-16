using System.Collections.Generic;
using System.Text;

namespace PizzaStore.Domain.Models
{
    public class Pizza
    {
        // State
        //field
        string ImageUrl = "";
        double Diameter = 0;
        public string Size = "";
        public List<string> Toppings = new List<string>();
        public string Crust = "";

        //properties (mixture of fields/getters and setters)
        public string SizeP 
        { 
            get;
        }


        // BEHAVIORS
        //methods
        public void AddToppings(string topping)
        {
            Toppings.Add(topping);
        }

        public override string ToString(){

            //string concatentation: ummutable
            /*
                topping1
                topping1 + topping2
                topping1 + topping2 + topping3
            */

            //Stringbuilder mutable
            /*
                topping1 + topping2 + topping3
            */
            var sb = new StringBuilder();
            //string toppingsList = "{";
            foreach(string t in Toppings){
                sb.Append(t + ", ");
            }
            //toppingsList = toppingsList.Substring(0, toppingsList.Length-2);
            //toppingsList += "}";
            string pizzaString = $"Size={Size}; Crust={Crust}; Toppings={sb}";
            return pizzaString;
        }

        //constructors
        public Pizza(string size, string crust, List<string> toppings)
        {
            Size = size;
            Crust = crust;
            Toppings.AddRange(toppings);
        }

        //finalize or static
    }
}