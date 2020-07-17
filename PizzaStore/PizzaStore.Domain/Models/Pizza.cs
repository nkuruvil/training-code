using System.Collections.Generic;
using PizzaStore.Domain.Models;
using System.Text;

namespace PizzaStore.Domain.Models
{
    public class Pizza
    {
        // State
        //field
        private readonly string ImageUrl = ""; // Once intiated, can't be changed 
        private const double Diameter = 0; //All pizza will have same diamter
        private static string _name = "pizza"; //Belong to class
        private List<string> _toppings = new List<string>();

        //properties (mixture of fields/getters and setters)
        public string Crust { get; }
        public string Size { get; }
        public List<string> Toppin8gs{
            get
            {
                return _toppings;
            }
        }


        // BEHAVIORS
        //methods
        public void AddToppings(string topping)
        {
            _toppings.Add(topping);
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
            foreach(string t in _toppings){
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
            _toppings.AddRange(toppings);
        }

        public Pizza()
        {
            Size = "";
            Crust = "";
            //intentionally empty
        }

        //finalize or static
    }
}