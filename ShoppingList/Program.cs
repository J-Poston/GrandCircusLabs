namespace ShoppingList
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> shoppingList = new List<string>(); ;

            bool continueShopping = true;
            bool validMenuChoice = false;
            string menuChoice = "";

            while(continueShopping == true)
            {
                DisplayMenuItems(GetMenuItems());
                validMenuChoice = GetMenuChoice(out menuChoice, GetMenuItems());
                if(validMenuChoice == true)
                {
                    shoppingList.Add(menuChoice);
                    Console.WriteLine($"Adding {menuChoice} for "
                        + $"{GetMenuItems().Where(x => x.Key == menuChoice).FirstOrDefault().Value} to cart.");
                }
                if(validMenuChoice == false)
                {
                    Console.WriteLine("Sorry, we don't sell that item.");
                }
                continueShopping = AskIfWantToContinueShopping();
            }
            DisplayShoppingList(shoppingList);
        }

        static bool GetMenuChoice(out string menuChoice, Dictionary<string, decimal> MenuItems)
        {
            bool validChoice = false;
            Console.Write("What item would you like to order?");
            menuChoice = Console.ReadLine();

            if (MenuItems.Keys.Contains(menuChoice))
            {
                validChoice = true;
            }
            return validChoice;
        }

        static bool AskIfWantToContinueShopping()
        {
            string continueShoppingStr = "";
            bool continueShopping = false;
            bool validResponse = false;

            while(validResponse == false)
            {
                Console.Write("Please enter Y or N  ");
                continueShoppingStr = Console.ReadLine();
                if(continueShoppingStr.ToLower() == "y")
                {
                    validResponse = true;
                    continueShopping = true;
                }
                else if(continueShoppingStr.ToLower() == "n")
                {
                    validResponse = true;
                    continueShopping = false;
                }
                else
                {
                    validResponse = false;
                }
            }
            return continueShopping;
        }

        static void DisplayMenuItems(Dictionary<string, decimal> items)
        {
            Console.WriteLine("Item".PadRight(12,' ') + "Price");
            Console.WriteLine("".PadRight(20,'='));

            foreach (KeyValuePair<string, decimal> item in items)
            {
                Console.WriteLine($"{item.Key.PadRight(12,' ')} {item.Value.ToString().PadRight(5,' ')}");
            }
            Console.WriteLine("".PadRight(20, '='));
        }

        static Dictionary<string, decimal> GetMenuItems()
        {
            Dictionary<string, decimal> MenuItems = new Dictionary<string, decimal>()
            {
                { "apple", 0.99M },
                { "pear", 0.99M },
                { "orange", 0.99M },
                { "banana", 1.99M },
                { "grapes", 2.99M },
                { "kiwi", 1.99M },
                { "watermelon", 2.99M },
                { "pineapple", 3.99M },
            };
            return MenuItems;
        }

        static void DisplayShoppingList(IEnumerable<string> shoppingList)
        {
            Console.WriteLine("Thank you for shopping with us!");
            Console.WriteLine("Here's your receipt");

            Dictionary<string, decimal> list = new Dictionary<string, decimal>();

            foreach (string item in shoppingList)
            {
                KeyValuePair<string, decimal> kvp = GetMenuItems().Where(x => x.Key == item).FirstOrDefault();
                list.Add(kvp.Key, kvp.Value);
            }
            foreach(KeyValuePair<string, decimal> item in list)
            {
                Console.WriteLine($"{item.Key} {item.Value}");
            }
        }
        

    }
}