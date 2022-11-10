namespace Roshambo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool playAgain = true;
            bool validRoshambo = true;
            string opponent = "";

            HumanPlayer humanPlayer;
            RoshamboResults results;

            while (playAgain == true)
            {
                humanPlayer = new HumanPlayer();
                opponent = ChooseOpponent();

                if(opponent.ToLower() == "rockplayer")
                {
                    RockPlayer rockPlayer = new RockPlayer();
                    Roshambo humanRoshambo = humanPlayer.GenerateRoshambo();
                    Roshambo rockRoshambo = rockPlayer.GenerateRoshambo();
                    results = new RoshamboResults(humanRoshambo, rockRoshambo);
                    results.DisplayResults();
                }

                else if(opponent.ToLower() == "randomplayer")
                {
                    RandomPlayer randomPlayer = new RandomPlayer();
                    Roshambo humanRoshambo = humanPlayer.GenerateRoshambo();
                    Roshambo randomRoshambo = randomPlayer.GenerateRoshambo();
                    results = new RoshamboResults(humanRoshambo, randomRoshambo);
                    results.DisplayResults();
                }
                
                playAgain = AskIfWantToPlayAgain();
            }
        }
        static bool AskIfWantToPlayAgain()
        {
            bool playAgain = false;
            bool validBool = false;
            while(validBool == false)
            {
                Console.WriteLine("Play again?");
                Console.WriteLine("Please enter true or false");
                validBool = bool.TryParse(Console.ReadLine().ToLower(), out playAgain);
            }
            return playAgain;
        }

        static string ChooseOpponent()
        {
            string opponent = "";
            bool validOpponent = false;
            int tryCount = 0;

            while (validOpponent == false)
            {
                if (tryCount != 0)
                {
                    Console.WriteLine("That is not a valid opponent.");
                }
                Console.WriteLine("Choose your opponent.");
                Console.WriteLine("Enter RockPlayer or RandomPlayer");
                opponent = Console.ReadLine();
                if(opponent.ToLower() == "rockplayer")
                {
                    validOpponent = true;
                    Console.WriteLine("Good choice...");
                }
                else if(opponent.ToLower() == "randomplayer") 
                {
                    validOpponent = true;
                }
                else
                {
                    validOpponent = false;
                    tryCount += 1;
                }
            }
            return opponent;
        }
    }
}