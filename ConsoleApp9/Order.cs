using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public class Order
    {
        public int OrderID { get; set; }
        public List<Pizza> OrderedPizzas { get; set; } = new List<Pizza>();

        public void AddPizzaToOrder(Pizza pizza) {
            OrderedPizzas.Add(pizza);
        }

        public double CalculateTotal() {
            double total = 0;
            foreach (var pizza in OrderedPizzas) {
                total += pizza.Price;
            }
            return total;
        }

        public void PrintOrder() {
            foreach (var pizza in OrderedPizzas) {
                Console.WriteLine($"Ordered Pizza: {pizza.NameOfPizza}, Price: {pizza.Price}");
            }
            Console.WriteLine($"Total Price: {CalculateTotal()}");
        }
    }
}