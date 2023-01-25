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
            //Start Position
            int start = 0;
            Console.WriteLine("Start Position:" + start);

            //Rolling a die
            Random random = new Random();
            int roll = random.Next(1, 7);
            Console.WriteLine("Die output is: "+roll);

            //Check For Position
            int playerPosition = 0;
            int ladder = 1;
            int snake = 2;
            Console.WriteLine("1:ladder\t 2: snake\t 3: noplay");
            int option = random.Next(1, 4);
            Console.WriteLine("Choosed option is: " + option);
            if (option == ladder)
            {
                playerPosition = playerPosition + roll;
                Console.WriteLine("With ladder player moves {0} steps ahead and now on {1} position ",roll,playerPosition);
            }
            else if (option == snake)
            {
                playerPosition = playerPosition + roll;
                Console.WriteLine("With snake player moves {0} steps back and now is on {1} position ",roll,playerPosition);
            }
            else
            {
                Console.WriteLine("no play player stays on its position only no movement " + playerPosition);
            }
        }
    }
}
