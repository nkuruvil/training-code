using System;
using System.Collections.Generic;
using PizzaStore.Domain.Models;

namespace PizzaStore.Client
{
    class Program
    {
        static void Main()
        {
            Welcome();
        }

        static void Welcome()
        {
            System.Console.WriteLine("Welcome to PizzaWorld");
            System.Console.WriteLine("Best Pizza Around");
            System.Console.WriteLine();

            //array
            //1-d
            string[] cart1 = {"","",""}; //initial values
            string[] cart2 = new string[3]; // default values
            string[] cart3 = new []{"","",""}; // initial values - custom datatypes or earlier C# version

            // list
            List<string> cart4 = new List<string>(){"", "", "",}; // initial values
            List<string> cart5 = new List<string>(); // default values

            List<Pizza> cart6 = new List<Pizza>();

            //Menu2(cart6);
            //Menu(cart2);
            var startup = new PizzaStore.Client.Startup();
            var user = new User();
            var store = new Store();

            //var order = startup.CreateOrder(user, store);

            try
            {
                Menu3(startup.CreateOrder(user, store));
                
            } catch (Exception ex) {
                System.Console.WriteLine(ex.Message);
            }

        }

    static void Menu3(Order cart){
        if (cart is null)
        {
            throw new ArgumentNullException(nameof(cart));
        }

        int numPizzas = 0;
        bool exit = false;
        var startup = new PizzaStore.Client.Startup();

        string[] pizzaNames = {"Cheese", "Pepperoni", "Sausage", "Vegetarian", "Supreme", "Custom"};

        do
        {

            // if
                    System.Console.WriteLine("Select 1 for Cheese Pizza");
                    System.Console.WriteLine("Select 2 for Pepperoni Pizza");
                    System.Console.WriteLine("Select 3 for Sausage Pizza");
                    System.Console.WriteLine("Select 4 for Vegetarian Pizza");
                    System.Console.WriteLine("Select 5 for Supreme Pizza");
                    System.Console.WriteLine("Select 6 for Custom Pizza");
                    System.Console.WriteLine("Select 7 to see cart");
                    System.Console.WriteLine("Select 8 for Exit Pizza");
                    System.Console.WriteLine("Select 9 to read pizza file");
                    System.Console.WriteLine();

                    int select = 0; 
                    int.TryParse(Console.ReadLine(), out select);

                    switch(select)
                    {
                        case 1:
                            //var p = startup.CreatePizza("L","Stuffed", new List<string>{"Cheese"});
                            //cart.Add(p);
                            cart.CreatePizza("L","Stuffed", new List<string>{"Cheese"});
                            System.Console.WriteLine("Added Cheese Pizza");
                            break;
                        case 2:
                            cart.CreatePizza("L","Stuffed", new List<string>{"Pepperoni"});
                            System.Console.WriteLine("Added Pepperoni Pizza");
                            break;
                        case 3:
                            cart.CreatePizza("L","Stuffed", new List<string>{"Sausage"});
                            System.Console.WriteLine("Added Sausage Pizza");
                            break;
                        case 4:
                            cart.CreatePizza("L","Stuffed", new List<string>{"Tomato", "Olive","Green Peppers","Onion"});
                            System.Console.WriteLine("Added Vegetarian Pizza");
                            break;
                        case 5:
                            cart.CreatePizza("L","Stuffed", new List<string>{"Pepperoni","Sausage","Green Peppers","Onions"});
                            System.Console.WriteLine("Added Supreme Pizza");
                            break;
                        case 6:
                            cart.CreatePizza("L","Stuffed", new List<string>{"Custom"});
                            System.Console.WriteLine("Added Custom Pizza");
                            break;
                        case 7:
                            DisplayCart3(cart);
                            break;
                        case 8:
                            var fmw = new FileManager();
                            fmw.Write(cart);
                            exit = true;
                            break;
                        case 9:
                            var fmr = new FileManager();
                            DisplayCart3(fmr.Read());
                            break;
                    }
                    System.Console.WriteLine("");
                if (select < 7){
                    numPizzas++;
                }

        }while(!exit);
        System.Console.WriteLine($"Thank you for ordering {numPizzas} pizzas");
        DisplayCart3(cart);
    }

    /*static void Menu2(List<Pizza> cart)
    {
        if (cart is null)
        {
            throw new ArgumentNullException(nameof(cart));
        }

        int numPizzas = 0;
        bool exit = false;
        var startup = new PizzaStore.Client.Startup();

        do
        {

            // if
                    System.Console.WriteLine("Select 1 for Cheese Pizza");
                    System.Console.WriteLine("Select 2 for Pepperoni Pizza");
                    System.Console.WriteLine("Select 3 for Sausage Pizza");
                    System.Console.WriteLine("Select 4 for Vegetarian Pizza");
                    System.Console.WriteLine("Select 5 for Supreme Pizza");
                    System.Console.WriteLine("Select 6 for Custom Pizza");
                    System.Console.WriteLine("Select 7 to see cart");
                    System.Console.WriteLine("Select 8 for Exit Pizza");
                    System.Console.WriteLine();

                    int select = 0; 
                    int.TryParse(Console.ReadLine(), out select);

                    switch(select)
                    {
                        case 1:
                            var p = startup.CreatePizza("L","Stuffed", new List<string>{"Cheese"});
                            cart.Add(p);
                            System.Console.WriteLine("Added Cheese Pizza");
                            break;
                        case 2:
                            cart.Add(startup.CreatePizza("L","Stuffed", new List<string>{"Pepperoni"}));
                            System.Console.WriteLine("Added Pepperoni Pizza");
                            break;
                        case 3:
                            System.Console.WriteLine("Added Sausage Pizza");
                            cart.Add(startup.CreatePizza("L","Stuffed", new List<string>{"Sausage"}));
                            break;
                        case 4:
                            System.Console.WriteLine("Added Vegetarian Pizza");
                            cart.Add(startup.CreatePizza("L","Stuffed", new List<string>{"Tomato", "Olive","Green Peppers","Onion"}));
                            break;
                        case 5:
                            System.Console.WriteLine("Added Supreme Pizza");
                            cart.Add(startup.CreatePizza("L","Stuffed", new List<string>{"Pepperoni","Sausage","Green Peppers","Onions"}));
                            break;
                        case 6:
                            System.Console.WriteLine("Added Custom Pizza");
                            cart.Add(startup.CreatePizza("L","Stuffed", new List<string>{"Custom"}));
                            break;
                        case 7:
                            DisplayCart3(cart);
                            break;
                        case 8:
                            
                            exit = true;
                            break;
                    }
                System.Console.WriteLine("");
                if (select < 7){
                    numPizzas++;
                }

        }while(!exit);
        System.Console.WriteLine($"Thank you for ordering {numPizzas} pizzas");
        DisplayCart3(cart);

    }


    static void Menu(string[] cart)
        {
            int numPizzas = 0;
            bool exit = false;

            do
            {

                // if

                if(numPizzas < cart.Length){
                    System.Console.WriteLine("Select 1 for Cheese Pizza");
                    System.Console.WriteLine("Select 2 for Pepperoni Pizza");
                    System.Console.WriteLine("Select 3 for Sausage Pizza");
                    System.Console.WriteLine("Select 4 for Vegetarian Pizza");
                    System.Console.WriteLine("Select 5 for Supreme Pizza");
                    System.Console.WriteLine("Select 6 for Custom Pizza");
                    System.Console.WriteLine("Select 7 to see cart");
                    System.Console.WriteLine("Select 8 for Exit Pizza");
                    System.Console.WriteLine();

                    int select = 0; 
                    int.TryParse(Console.ReadLine(), out select);

                    switch(select)
                    {
                        case 1:
                            cart[numPizzas] = "Cheese";
                            System.Console.WriteLine("Added Cheese Pizza");
                            break;
                        case 2:
                            cart[numPizzas] = "Pepperoni";
                            System.Console.WriteLine("Added Pepperoni Pizza");
                            break;
                        case 3:
                            System.Console.WriteLine("Added Saisage Pizza");
                            cart[numPizzas] = "Sausage";
                            break;
                        case 4:
                            System.Console.WriteLine("Added Vegetarian Pizza");
                            cart[numPizzas] = "Vegetarian";
                            break;
                        case 5:
                            System.Console.WriteLine("Added Supreme Pizza");
                            cart[numPizzas] = "Supreme";
                            break;
                        case 6:
                            System.Console.WriteLine("Added Custom Pizza");
                            cart[numPizzas] = "Custom";
                            break;
                        case 7:
                            DisplayCart(cart);
                            break;
                        case 8:
                            
                            exit = true;
                            break;
                    }
                    if (select < 7){
                        numPizzas++;
                    }
                }else{
                    exit = true;
                }
                

            }while(!exit);
            System.Console.WriteLine($"Thank you for ordering {numPizzas} pizzas");
            DisplayCart(cart);

        }
    */    
        
    static void DisplayCart3(Order cart){
        foreach(var pizza in cart.Pizzas){
            System.Console.WriteLine(pizza);
        }
    }
    static void DisplayCart2(List<string> cart){
        foreach(var pizza in cart){
            System.Console.WriteLine(pizza);
        }
    }
    static void DisplayCart(string[] cart){
        foreach(var pizza in cart){
            System.Console.WriteLine(pizza);
        }
    }


    }
}
