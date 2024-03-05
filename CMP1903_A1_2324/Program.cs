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
            // Console.WriteLine(test1.testingDie());  // returns true if die working correctly // no longer needed as die tested in game testing
            test1.TestingGame(); // runs the method wich tests multiple elements for the game class

            //Game franksGame = new Game(); // Game object no longer needed as testing class with the method testingGame creates its own game object to run

            //franksGame.Roller(); // removed this code to allow user to leave program when typing 'no' once
            // Console.ReadLine(); was used before the main loop within game.cs was implemented 
        }
    }
}
