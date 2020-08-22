using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Make the menu (get the menu)
            Menu ourMenu = new Menu();
            // Display the menu
            MenuDisplayCase displayCase = new MenuDisplayCase();
            displayCase.DisplayMenu();
            // Welcome user, ask for order
            Cashier cashier = new Cashier();
            cashier.Greeting();
            // Translate user input to menu item
            int userOrderItem = cashier.GetOrder();
            // Cook menu item
            Cook cook = new Cook();
            string cookedFoodMessage = cook.MakeFood(userOrderItem);
            // Return cooked food
            Console.WriteLine(cookedFoodMessage);
            cashier.SayThanksAndGoodbye();
            Console.ReadLine();
        }
    }
    class Cook
    {
        // If you need _____ to make food, ____ is one of your parameters
        public string MakeFood(int menuItemNumber)
        {
            Menu menu = new Menu();
            string menuItem = menu.MenuItems[menuItemNumber];
            return $"Your {menuItem} is ready!";
        }
    }
    class Cashier
    {
        public void Greeting()
        {
            Console.WriteLine("Welcome to McDonald's!");
        }
        public int GetOrder()
        {
            Console.WriteLine("What can I get you today?\n" +
                "Please type in the number for the item and press enter.");
            string userInput = Console.ReadLine();
            // From "1" to 1
            int userMenuItem = Convert.ToInt32(userInput);
            return userMenuItem;
        }
        public void SayThanksAndGoodbye()
        {
            Console.WriteLine("Thank you and have a great day!");
        }
    }
    class MenuDisplayCase
    {
        public MenuDisplayCase()
        {

        }
        public void DisplayMenu()
        {
            Menu menuToDisplay = new Menu();
            foreach (KeyValuePair<int,string> menuItem in menuToDisplay.MenuItems)
            {
                Console.WriteLine($"{menuItem.Key} - {menuItem.Value}");
            }
        }
    }
    class Menu
    {
        public Menu()
        {
            MenuItems = new Dictionary<int, string>()
            {
                {1, "Big Mac" },
                {2, "McDouble" },
                {3, "SEG McGriddle" },
                {4, "Chicken Nuggets" },
                {5, "Cookies" },
                {6, "Apple Pie" },
                {7, "Bagel" },
                {8, "Pancakes" }
            };
        }
        public Dictionary<int, string> MenuItems;
    }
}
