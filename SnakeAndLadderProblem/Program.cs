using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Snake And Ladder Problem");
            //Object creation of SnakeLadder class
            SnakeLadder snakeLadder = new SnakeLadder();
            snakeLadder.Game();
            Console.ReadLine();
        }
    }
}
