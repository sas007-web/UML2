using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public class MenuCatalog
    {
        private List<Pizza> pizzas = new List<Pizza>();

        public void AddPizza(Pizza pizza) {
            pizzas.Add(pizza);
        }

        public void DeletePizza(int pizzaNum) {
            pizzas.RemoveAll(p => p.PizzaNum == pizzaNum);
        }

        public List<Pizza> GetPizzas() {
            return pizzas;
        }

        public void UpdatePizza(int pizzaNum, string newName, double newPrice, List<Pizza> pizzas) {
            Pizza pizza = pizzas.Find(p => p.PizzaNum == pizzaNum);
            if (pizza != null) {
                pizza.NameOfPizza = newName;
                pizza.Price = newPrice;
            }
        }

        public Pizza? SearchPizza(int pizzaNum) {
            return pizzas.Find(p => p.PizzaNum == pizzaNum); 
        }


        public void PrintMenu() {
            foreach (var pizza in pizzas) {
                Console.WriteLine($"Pizza: {pizza.NameOfPizza}, Price: {pizza.Price}");
                pizza.PrintToppings();
            }
        }
    }
}
