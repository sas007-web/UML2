
namespace ConsoleApp9
{
    public class UserInputHandler
    {
        
        public int MenuChoice(List<string> menuItems) {
            Console.WriteLine("Please choose an option:");
            for (int i = 0; i < menuItems.Count; i++) {
                Console.WriteLine($"{i + 1}. {menuItems[i]}");
            }

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice)) {
                return choice;
            }
            else {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                return -1;
            }
        }

        public Pizza GetPizzaDetails() {
            Console.Write("Enter pizza number: ");
            int pizzaNum = int.Parse(Console.ReadLine());
            Console.Write("Enter pizza name: ");
            string nameOfPizza = Console.ReadLine();
            Console.Write("Enter pizza price: ");
            double price = double.Parse(Console.ReadLine());

            return new Pizza(pizzaNum, nameOfPizza, price);
        }
    }
}
