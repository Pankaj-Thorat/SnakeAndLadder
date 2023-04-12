using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SnakeAndLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int position = 0;
            const int snake = 1;
            const int ladder = 2;
            const int noPlay = 3;
            Random r = new Random();
            //roll the die
            int dieNo = r.Next(1, 7);
            //check for the options using RANDOM
            int options = r.Next(1, 4);
            switch (options)
            {
                case noPlay:
                    Console.WriteLine("No Play! you stay the same position");
                    break;
                case ladder:
                    Console.WriteLine("Ladder! you move ahead by {0} positions", dieNo);
                    position = position + dieNo;
                    break;
                case snake:
                    Console.WriteLine("Snake! you move behind by {0} positions", dieNo);
                    position = position - dieNo;
                    break;
            }
            Console.WriteLine("Your current position is {0}",position);
        }
    }
}


