using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.Classes;

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
}
