using System.Collections.Generic;
using PizzaStore.Domain.Models;


namespace PizzaStore.Client
{
    public class Startup
    {
        public Order CreateOrder(User user, Store store)
        {
            try
            {

                var order = new Order();

                user.Orders.Add(order);
                store.Orders.Add(order);

                return order;
            } 
            catch 
            {
                throw new System.Exception("Technical Difficulties. Please try again later.");
            }
            finally
            {
                //Use to clean up resources
                
            }
        }
    }
}