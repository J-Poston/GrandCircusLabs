namespace StudentDatabase
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] names = new string[3] {"John","Mark","Paul"};
            string[] hometowns = new string[3] {"Detroit","New York","Cyprus"};
            string[] favoriteFoods = new string[3] {"Cheeseburgers","Pad Thai","Pita Bread"};
            int studentNumber = 0;
            string category = "";

            bool searchStudents = true;

            while(searchStudents == true)
            {
                PrintStudentMenu(names);
                studentNumber = GetStudentMenuChoice(names);

                PrintCategoryMenu();
                category = GetCategoryMenuChoice();

                PrintStudentInfo(names, hometowns, favoriteFoods, studentNumber, category);

                searchStudents = AskToSearchStudents();
            }   

        }

        static void PrintStudentMenu(string[] names)
        {
            Console.WriteLine("Choose a student to view their info.");
            Console.WriteLine("------------------------------------");

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"{i + 1} {names[i]}");
            }            
        }

        static int GetStudentMenuChoice(string[] names)
        {
            int studentNumber = 0;
            bool validInt = false;
            int tryCount = 0;

            while(validInt == false)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                if(tryCount == 0)
                {
                    Console.Write("Please enter a student number: ");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That student number doesn't exist.");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Please enter a student number: ");
                }
                Console.ForegroundColor = ConsoleColor.Gray;
                validInt = int.TryParse(Console.ReadLine(), out studentNumber);
                
                if(studentNumber < 1 || studentNumber > names.Length)
                {
                    validInt = false;
                }
                if(validInt == false)
                {
                    tryCount++;
                }
            }
            return studentNumber;
        }

        static void PrintCategoryMenu()
        {
            Console.WriteLine("Choose a category to view student info: ");
            Console.WriteLine("----------------------------------------");

            Console.WriteLine("Hometown");
            Console.WriteLine("Favorite Food");
        }

        static string GetCategoryMenuChoice()
        {
            string category = "";
            bool validCategory = false;
            int tryCount = 0;
            
            while(validCategory == false)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                if(tryCount == 0)
                {
                    Console.Write("Please enter a category name: ");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("That category doesn't exist.");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Please enter a category name: ");
                }
                
                Console.ForegroundColor = ConsoleColor.Gray;
                category = Console.ReadLine();
                if (category.ToLower() == "hometown" || category.ToLower() == "favorite food")
                {
                    validCategory = true;
                }
                else
                {
                    tryCount++;
                }
            }
            return category;
        }

        static void PrintStudentInfo(string[] names, string[] hometowns, string[] favoriteFoods, int studentNumber, string category)
        {

            Console.ForegroundColor = ConsoleColor.Magenta;
            
            if (category.ToLower() == "hometown")
            {
                Console.WriteLine($"Hometown for {names[studentNumber -1]}: {hometowns[studentNumber -1]}");
            }
            else if (category.ToLower() == "favorite food")
            {
                Console.WriteLine($"Favorite Food for {names[studentNumber - 1]}: {favoriteFoods[studentNumber - 1]}");
            }

            Console.ForegroundColor = ConsoleColor.Gray;
        }

        static bool AskToSearchStudents()
        {
            bool searchStudents = false;
            bool validBool = false;
            int tryCount = 0;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Do you want to search for another student?");

            while (validBool == false)
            {                
                if (tryCount == 0)
                {                    
                    Console.Write("Please enter true or false: ");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Please enter true or false: ");
                }
                Console.ForegroundColor = ConsoleColor.Gray;
                validBool = bool.TryParse(Console.ReadLine(), out searchStudents);
                if(validBool == false) { tryCount++; }
            }
            return searchStudents;
        }

    }
}