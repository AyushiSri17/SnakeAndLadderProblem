using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderProblem
{
    public class SnakeLadder
    {
        public void Game()
        {
            //UC1-Start Position
            int start = 0;
            Console.WriteLine("Start Position:" + start);

            //Rolling a die
            Random random = new Random();
            int roll = random.Next(1, 7);
            Console.WriteLine("Die output is: "+roll);
        }
    }
}
