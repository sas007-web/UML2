namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args) {
            MenuCatalog menuCatalog = new MenuCatalog();
            int choice;

            do {
                choice = MenuChoice(new List<string>
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
                        AddNewPizza(menuCatalog);
                        break;
                    case 2:
                        DeletePizza(menuCatalog);
                        break;
                    case 3:
                        UpdatePizza(menuCatalog);
                        break;
                    case 4:
                        SearchPizza(menuCatalog);
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

        static int MenuChoice(List<string> menuItems) {
            Console.WriteLine("\nPlease choose an option:");
            foreach (string item in menuItems) {
                Console.WriteLine(item);
            }

            Console.Write("\nEnter your choice: ");
            int choice;
            if (int.TryParse(Console.ReadLine(), out choice)) {
                return choice;
            }
            else {
                Console.WriteLine("Invalid input. Please enter a number.");
                return -1;
            }
        }

        static void AddNewPizza(MenuCatalog menuCatalog) {
            Console.Write("Enter pizza number: ");
            int pizzaNum = int.Parse(Console.ReadLine());
            Console.Write("Enter pizza name: ");
            string nameOfPizza = Console.ReadLine();
            Console.Write("Enter pizza price: ");
            double price = double.Parse(Console.ReadLine());

            Pizza newPizza = new Pizza(pizzaNum, nameOfPizza, price);
            menuCatalog.AddPizza(newPizza);
            Console.WriteLine("Pizza added successfully.");
        }

        static void DeletePizza(MenuCatalog menuCatalog) {
            Console.Write("Enter pizza number to delete: ");
            int pizzaNum = int.Parse(Console.ReadLine());
            menuCatalog.DeletePizza(pizzaNum);
            Console.WriteLine("Pizza deleted successfully.");
        }

        static void UpdatePizza(MenuCatalog menuCatalog) {
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

        static void SearchPizza(MenuCatalog menuCatalog) {
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
}
