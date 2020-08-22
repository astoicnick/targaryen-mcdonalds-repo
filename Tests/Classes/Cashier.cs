using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Classes
{
    class Cashier
    {
        private string _orderedItemKey;
        public string OrderedItemKey
        {
            get { return _orderedItemKey; }
            //public void SetOrderedItem() 
            //{
            //}
            set 
            {
                // Check if it's a number
                if (int.TryParse(value, out int num))
                {
                    Menu menu = new Menu();
                    // Check if it's a real menu item
                    if (menu.MenuItems.TryGetValue(num, out string menuItemValue))
                    {
                        _orderedItemKey = value;
                    }
                }
            }
        }
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
            string theOrderedItem = OrderedItemKey;
            int userMenuItem = Convert.ToInt32(OrderedItemKey);
            return userMenuItem;
        }
        public void SayThanksAndGoodbye()
        {
            Console.WriteLine("Thank you and have a great day!");
        }
    }
}
