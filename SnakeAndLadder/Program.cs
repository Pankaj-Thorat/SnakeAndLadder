using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class Program
    {
        //initialize from zero position
        public static int startPosition = 0;
        // generating random number between 1 to 6 using RANDOM method.
        public int rollingDie() 
        {
            Random r = new Random();
            int dieNo = r.Next(1,7);
            return dieNo;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("player started at position {0}", startPosition);
            int num = new Program().rollingDie();
            //display number generated using Random method.
            Console.WriteLine("die value after rolling the die is {0}",num );
        }
    }
}
