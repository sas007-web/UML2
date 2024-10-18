using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public class Pizza
    {
        public int PizzaNum { get; set; }
        public string NameOfPizza { get; set; }
        public double Price { get; set; }
        public List<Topping> Toppings { get; set; } = new List<Topping>();

        public Pizza(int pizzaNum, string nameOfPizza, double price) {
            PizzaNum = pizzaNum;
            NameOfPizza = nameOfPizza;
            Price = price;
        }

        public void AddTopping(Topping topping) {
            Toppings.Add(topping);
        }

        public void RemoveTopping(Topping topping) {
            Toppings.Remove(topping);
        }

        public void PrintToppings() {
            foreach (var topping in Toppings) {
                Console.WriteLine($"Topping: {topping.NameOfTop} - Price: {topping.Price}");
            }
        }
       
    }

  
 }