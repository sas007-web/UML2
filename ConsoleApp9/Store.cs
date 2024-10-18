using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using ConsoleApp9;

public class Store
{
    static void Main(string[] args) {
        MenuCatalog menuCatalog = new MenuCatalog();
        UserInputHandler userInput = new UserInputHandler(); 
        int choice;

        
        menuCatalog.AddPizza(new Pizza(1, "Margherita", 8.99));
        menuCatalog.AddPizza(new Pizza(2, "Pepperoni", 10.99));

        do {
            choice = userInput.MenuChoice(new List<string>
            {
                "1. Add new pizza",
                "2. Delete pizza",
                "3. Update pizza",
                "4. Search pizza",
                "5. Display pizza menu",
                "6. Exit"
            });

            switch (choice) {
                case 1:
                    Pizza newPizza = userInput.GetPizzaDetails();
                    menuCatalog.AddPizza(newPizza);
                    Console.WriteLine("Pizza added successfully.");
                    break;
                case 2:
                    DeletePizza(menuCatalog, userInput);
                    break;
                case 3:
                    UpdatePizza(menuCatalog, userInput);
                    break;
                case 4:
                    SearchPizza(menuCatalog, userInput);
                    break;
                case 5:
                    menuCatalog.PrintMenu();
                    break;
                case 6:
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        } while (choice != 6);
    }

    
    static void DeletePizza(MenuCatalog menuCatalog, UserInputHandler userInput) {
        Console.Write("Enter pizza number to delete: ");
        int pizzaNum = int.Parse(Console.ReadLine());
        menuCatalog.DeletePizza(pizzaNum);
        Console.WriteLine("Pizza deleted successfully.");
    }


    static void UpdatePizza(MenuCatalog menuCatalog, UserInputHandler userInput) {
        Console.Write("Enter pizza number to update: ");
        int pizzaNum = int.Parse(Console.ReadLine());
        Console.Write("Enter new pizza name: ");
        string newName = Console.ReadLine();
        Console.Write("Enter new pizza price: ");
        double newPrice = double.Parse(Console.ReadLine());

        menuCatalog.UpdatePizza(pizzaNum, newName, newPrice,
        menuCatalog.GetPizzas());
        Console.WriteLine("Pizza updated successfully.");
    }


    static void SearchPizza(MenuCatalog menuCatalog, UserInputHandler userInput) {
        Console.Write("Enter pizza number to search: ");
        int pizzaNum = int.Parse(Console.ReadLine());
        Pizza pizza = menuCatalog.SearchPizza(pizzaNum);
        if (pizza != null) {
            Console.WriteLine($"Pizza Found: {pizza.NameOfPizza}, Price: {pizza.Price}");
            pizza.PrintToppings();
        }
        else {
            Console.WriteLine("Pizza not found.");
        }
    }
}
