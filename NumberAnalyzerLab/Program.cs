namespace NumberAnalyzerLab
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string userStr;
            int userInt;
            bool isOdd;
            bool isEven;
            bool isInRange = false;
            bool repeat = false;
            string rangeMsg = "";

            do
            {
                do
                {
                    Console.WriteLine("Please provide a whole number between 1 and 100.");
                    userStr = Console.ReadLine();
                    userInt = Convert.ToInt32(userStr);
                    if(userInt >= 1 && userInt <= 100) 
                    {
                        isInRange = true; 
                    }
                } 
                while (isInRange == false);

                if (userInt % 2 == 0)
                {
                    isEven = true;
                    isOdd = false;
                }

                else
                {
                    isEven = false;
                    isOdd = true;
                }

                if (isOdd)
                {
                    if (userInt < 60)
                    {
                        rangeMsg = "Odd and less than 60.";
                    }

                    if (userInt > 60)
                    {
                        rangeMsg = "Odd and greater than 60.";
                    }

                }
                if (isEven)
                {
                    if (userInt <= 24)
                    {
                        rangeMsg = "Even and less than 25.";
                    }

                    else if (userInt <= 60)
                    {
                        rangeMsg = "Even and between 26 and 60 inclusive.";
                    }

                    else
                    {
                        rangeMsg = "Even and greater than 60";
                    }
                }

                Console.WriteLine($"{userInt}: {rangeMsg}");
                Console.WriteLine("Repeat? Enter \"true\" or \"false\".");
                userStr = Console.ReadLine();
                repeat = Convert.ToBoolean(userStr);

            }
            while(repeat);

        }
    }
}