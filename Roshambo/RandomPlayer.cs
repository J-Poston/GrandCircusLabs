using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roshambo
{
    public class RandomPlayer : Player
    {
        public override string Name { get; set; }
        public override Roshambo GenerateRoshambo()
        {
            string[] values = Enum.GetNames(typeof(Roshambo));
            Random r = new Random();
            int value = r.Next(0, values.Length - 1);
            
            Roshambo roshambo = (Roshambo)value;
            return roshambo;
        }
    }
}
