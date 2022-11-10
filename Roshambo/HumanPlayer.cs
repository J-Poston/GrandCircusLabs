using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roshambo
{
    public class HumanPlayer : Player
    {
        public HumanPlayer()
        {
            Console.Write("Please enter your name: ");
            Name = Console.ReadLine();
            Console.WriteLine($"Welcome {Name}!");
        }
        public override string Name { get; set; }
        public override Roshambo GenerateRoshambo()
        {
            bool validEnum = false;
            Roshambo roshambo = new Roshambo();
            while(validEnum == false)
            {
                Console.WriteLine("Rock, Paper or Scissors?");
                validEnum = Roshambo.TryParse(Console.ReadLine().ToLower(), out roshambo);
                switch (roshambo)
                {
                    case Roshambo.rock:
                        validEnum = true;
                        break;
                    case Roshambo.paper:
                        validEnum = true;
                        break;
                    case Roshambo.scissors:
                        validEnum = true;
                        break;
                    default:
                        validEnum = false;
                        break;
                }
            }
            return roshambo;
        }
    }
}
