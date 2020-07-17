using System.Collections.Generic;
using PizzaStore.Domain.Models;
using Xunit;

namespace PizzaStore.Testing.Tests
{
    public class OrderTest
    {
        [Theory]
        [InlineData("S", "C", "T")]
        [InlineData("M", "C2", "T2")]
        public void Test_CreatePizza(string s, string c, string t)
        {
            var sut = new Order();
            string size = s;
            string crust = c;
            List<string> toppings = new List<string>{t};

            sut.CreatePizza(size, crust, toppings);

            Assert.True(sut.Pizzas.Count == 1);

        }
    }
}