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
            int playerPosition = 0;
            int start = 0;
            Console.WriteLine("Start Position:" + start);

            while (playerPosition < 100)
            {
                //Rolling a die
                Random random = new Random();
                int roll = random.Next(1, 7);
                Console.WriteLine("Die output is: " + roll);

                //Check For Position         
                const int Ladder = 1;
                const int Snake = 2;
                //const int No_Play = 3;
                Console.WriteLine("1:ladder\t 2: snake\t 3: noplay");
                int option = random.Next(1, 4);
                Console.WriteLine("Choosed option is: " + option);
                if(playerPosition>=0)
                { 
                    switch(option)
                    {
                        case Ladder:                
                            playerPosition = playerPosition + roll;
                            Console.WriteLine("With ladder player moves {0} steps ahead and now on {1} position ", roll, playerPosition);
                            break;
                        case Snake:                
                            playerPosition = playerPosition - roll;
                            Console.WriteLine("With snake player moves {0} steps back and now is on {1} position ", roll, playerPosition);
                            break;
                        default:               
                            Console.WriteLine("no play player stays on its position only no movement " + playerPosition);
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("though player goes into negative position then player needs to play from start position again");
                    playerPosition = start;
                }
            }
        }
    }
}
