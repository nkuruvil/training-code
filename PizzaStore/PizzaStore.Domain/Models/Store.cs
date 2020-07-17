using System.Collections.Generic;

namespace PizzaStore.Domain.Models
{
    public class Store
    {
        public List<User> Users { get; set;}
        public List<Order> Orders { get; set;}
        
        public Store()
        {
            Orders = new List<Order>();
        }
    }
}