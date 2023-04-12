using System;

namespace SnakeAndLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int position = 0;
            int winningPosition = 100;
            const int snake = 1;
            const int ladder = 2;
            const int noPlay = 3;
            Random r = new Random();

            while (position < winningPosition)
            {
                //roll the die and check for the options using RANDOM
                int dieNo = r.Next(1, 7);
                int options = r.Next(1, 4);

                switch (options)
                {
                    case noPlay:
                        Console.WriteLine("No Play! You stay in the same position");
                        break;
                    case ladder:
                        //to get the exact 100
                        int newPosition = position + dieNo;
                        if (newPosition <= winningPosition)
                        {
                            position = newPosition;
                            Console.WriteLine("Ladder! You move ahead by {0} positions", dieNo);
                        }
                        else
                        {
                            Console.WriteLine("Ladder! You need {0} to win. Stay where you are.", winningPosition - position);
                        }
                        break;
                    case snake:
                        Console.WriteLine("Snake! You move behind by {0} positions", dieNo);
                        position -= dieNo;
                        break;
                }
                //check if player's position is within valid range
                if (position < 0)
                {
                    position = 0;
                }
                Console.WriteLine("Your current position is {0}", position);
            }
            Console.WriteLine("Congrats!! You have reached the winning position of {0}", winningPosition);
        }
    }
}
