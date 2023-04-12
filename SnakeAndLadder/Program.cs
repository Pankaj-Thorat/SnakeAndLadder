using System;

namespace SnakeAndLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] positions = { 0, 0 };
            int winningPosition = 100;
            const int snake = 1;
            const int ladder = 2;
            const int noPlay = 3;
            Random r = new Random();
            int currentPlayer = 0;
            bool gotExtraChance = false;

            while (true)
            {
                //roll the die and check for the options using RANDOM
                int dieNo = r.Next(1, 7);
                int options = r.Next(1, 4);
                switch (options)
                {
                    case noPlay:
                        Console.WriteLine("No Play! Player {0} stays in the same position", currentPlayer + 1);
                        break;
                    case ladder:
                        //to get the exact 100
                        int newPosition = positions[currentPlayer] + dieNo;
                        if (newPosition <= winningPosition)
                        {
                            positions[currentPlayer] = newPosition;
                            Console.WriteLine("Ladder! Player {0} moves ahead by {1} positions", currentPlayer + 1, dieNo);
                            gotExtraChance = true;
                        }
                        else
                        {
                            Console.WriteLine("Ladder! Player {0} needs {1} to win. Stay where you are.", currentPlayer + 1, winningPosition - positions[currentPlayer]);
                        }
                        break;
                    case snake:
                        Console.WriteLine("Snake! Player {0} moves behind by {1} positions", currentPlayer + 1, dieNo);
                        positions[currentPlayer] -= dieNo;
                        gotExtraChance = false;
                        break;
                }
                //check if player's position is within valid range
                if (positions[currentPlayer] < 0)
                {
                    positions[currentPlayer] = 0;
                }
                Console.WriteLine("Player {0}'s current position is {1}", currentPlayer + 1, positions[currentPlayer]);
                //check if player has reached the winning position
                if (positions[currentPlayer] == winningPosition)
                {
                    Console.WriteLine("Congrats!! Player {0} has reached the winning position of {1}", currentPlayer + 1, winningPosition);
                    break;
                }
                //switch to the next player if the current player did not get an extra chance
                if (!gotExtraChance)
                {
                    currentPlayer = (currentPlayer + 1) % 2;
                }
            }
            //report the winner
            if (positions[0] == winningPosition)
            {
                Console.WriteLine("Player 1 has won the game!");
            }
            else if (positions[1] == winningPosition)
            {
                Console.WriteLine("Player 2 has won the game!");
            }
        }
    }
}
