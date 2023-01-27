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
            int player_1_Position = 0;
            int player_2_Position = 0;
            int start = 0;
            Console.WriteLine("Start Position:" + start);
            int dieCount=0;
            //Here value of i will decide which player's turn is to play
            int i = 2;
            Random random = new Random();

            while (player_1_Position < 100 && player_2_Position<100)
            {
                //Rolling a die 
                int roll = random.Next(1, 7);
                Console.WriteLine("\nDie output is: " + roll);

                //Check For Position         
                const int Ladder = 1;
                const int Snake = 2;
                //const int No_Play = 3;
                Console.WriteLine("1:ladder\t 2: snake\t 3: noplay");
                int option = random.Next(1, 4);
                Console.WriteLine("Choosed option is: " + option);
                Console.WriteLine("i = " + i);

                if (i % 2 == 0)
                {
                    Console.WriteLine("Player 1 turn to play");
                    if (player_1_Position >= 0)
                    {
                        switch (option)
                        {
                            case Ladder:
                                player_1_Position = player_1_Position + roll;
                                Console.WriteLine("With ladder player moves {0} steps ahead and now on {1} position ", roll, player_1_Position);
                                i--;
                                Console.WriteLine("Its a Ladder player 1 will play again");
                                if (player_1_Position > 100)
                                {
                                    Console.WriteLine("Player needs to stay on its previous position only");
                                    player_1_Position = player_1_Position - roll;
                                    Console.WriteLine("Player is still on its previous position that is {0} position", player_1_Position);
                                }
                                else if (player_1_Position == 100)
                                {
                                    Console.WriteLine("Player 1 won");
                                }
                                break;
                            case Snake:
                                player_1_Position = player_1_Position - roll;
                                Console.WriteLine("With snake player moves {0} steps back and now is on {1} position ", roll, player_1_Position);
                                break;
                            default:
                                Console.WriteLine("no play player stays on its position only no movement " + player_1_Position);
                                break;
                        }
                    }
                    else if (player_1_Position < 0)
                    {
                        Console.WriteLine("though player goes into negative position then player needs to play from start position again");
                        player_1_Position = start;
                    }
                }
                else
                {
                    Console.WriteLine("Player 2 turn to play");
                    if (player_2_Position >= 0)
                    {
                        switch (option)
                        {
                            case Ladder:
                                player_2_Position = player_2_Position + roll;
                                Console.WriteLine("With ladder player moves {0} steps ahead and now on {1} position ", roll, player_2_Position);
                                i--;
                                Console.WriteLine("Its a Ladder player 2 will play again");
                                if (player_2_Position > 100)
                                {
                                    Console.WriteLine("Player needs to stay on its previous position only");
                                    player_2_Position = player_2_Position - roll;
                                    Console.WriteLine("Player is still on its previous position that is {0} position", player_2_Position);
                                }
                                else if (player_2_Position == 100)
                                {
                                    Console.WriteLine("Player 2 won");
                                }
                                break;
                            case Snake:
                                player_2_Position = player_2_Position - roll;
                                Console.WriteLine("With snake player moves {0} steps back and now is on {1} position ", roll, player_2_Position);
                                break;
                            default:
                                Console.WriteLine("no play player stays on its position only no movement " + player_2_Position);
                                break;
                        }
                    }
                    else if (player_2_Position < 0)
                    {
                        Console.WriteLine("though player goes into negative position then player needs to play from start position again");
                        player_2_Position = start;
                    }
                }
                i++;
                dieCount++;   
            }
            Console.WriteLine("\n Total number of times die rolled is: "+dieCount );
        }
    }
}
