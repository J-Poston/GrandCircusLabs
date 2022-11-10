using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roshambo
{
    public class RoshamboResults
    {
        public Roshambo PlayerOneRoshambo { get; set; }
        public Roshambo PlayerTwoRoshambo { get; set; }
        public string PlayerOneResult { get; set; }
        public string PlayerTwoResult { get; set; }

        public RoshamboResults(Roshambo playerOneRoshambo, Roshambo playerTwoRoshambo)
        {
            PlayerOneRoshambo = playerOneRoshambo;
            PlayerTwoRoshambo = playerTwoRoshambo;
            if(PlayerOneRoshambo == PlayerTwoRoshambo)
            {
                PlayerOneResult = "Tie";
                PlayerTwoResult = "Tie";
            }
            else if(PlayerOneRoshambo == Roshambo.rock && PlayerTwoRoshambo == Roshambo.paper)
            {
                PlayerOneResult = "Lose";
                PlayerTwoResult = "Win";
            }
            else if(PlayerOneRoshambo == Roshambo.rock && PlayerTwoRoshambo == Roshambo.scissors)
            {
                PlayerOneResult = "Win";
                PlayerTwoResult = "Lose";
            }

            else if (PlayerOneRoshambo == Roshambo.paper && PlayerTwoRoshambo == Roshambo.rock)
            {
                PlayerOneResult = "Win";
                PlayerTwoResult = "Lose";
            }
            else if (PlayerOneRoshambo == Roshambo.paper && PlayerTwoRoshambo == Roshambo.scissors)
            {
                PlayerOneResult = "Lose";
                PlayerTwoResult = "Win";
            }

            else if (PlayerOneRoshambo == Roshambo.scissors && PlayerTwoRoshambo == Roshambo.rock)
            {
                PlayerOneResult = "Lose";
                PlayerTwoResult = "Win";
            }
            else if (PlayerOneRoshambo == Roshambo.scissors && PlayerTwoRoshambo == Roshambo.paper)
            {
                PlayerOneResult = "Win";
                PlayerTwoResult = "Lose";
            }
        }

        public void DisplayResults()
        {
            Console.WriteLine();
            Console.WriteLine("Roshambo Match Results");
            Console.WriteLine("".PadRight(25,'='));
            Console.WriteLine($"Player One  |  Player Two");
            Console.WriteLine($"{PlayerOneRoshambo.ToString().PadRight(10,' ')}  |  {PlayerTwoRoshambo}");
            Console.WriteLine($"{PlayerOneResult.ToString().PadRight(10, ' ')}  |  {PlayerTwoResult}");
            Console.WriteLine();
        }
    }
}
