using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Testing test1 = new Testing(); // creating a testing object
            //Console.WriteLine(test1.testingDie());  // returns true if die working correctly
            Console.WriteLine(test1.testingGame()); // returns true if sum returned correctly and is not above 18

            //Game franksGame = new Game();
            //franksGame.Roller(); // removed this code to allow user to leave program when typing 'no' once

            // Console.ReadLine(); was used before the main loop within game.cs was implemented 
            /*
             * 
             * Create a Game object and call its methods.
             * Create a Testing object to verify the output and operation of the other classes.
             */
        }
    }
}
