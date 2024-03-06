using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Testing { // testing the game and die class
        
        /// <summary>
        /// this method TestingGame tests the Game class and that its returned values such as the sum are calculated correctly and within expected logical range
        /// </summary>
        public void TestingGame(){ //changed to void as no longer needed to pass value
            Game testGame = new Game(); // creating new game object
            // die objects created within this new game object and tested through their returned values 
            List<int> returnList = new List<int>(); // creating a list to hold returned values from game()
            returnList = testGame.Roller(); // calling method
            float averageValue = returnList[3] / 3;

            // comparing expected output using debug.Assert to make comparisons
            Debug.Assert((returnList[3] < 18), "Sum of die values too large (above 18)");// returns error if sum of 3 die rolls above 18 
            Debug.Assert((returnList[3] > 3), "Sum of die values too small (below 3)");// returns error if sum of 3 die rolls below 3
            Debug.Assert(((returnList[0] + returnList[1] + returnList[2]) == returnList[3]), "Sum of die value does not equal actual sum of die");// returns error if passed sum is not equal to addition of the three die
            for (int i = 0; i <= 2; i++) // a for loop to check die rolled within the game loop
            {
                Debug.Assert(((returnList[i] < 7 && returnList[i] > 0)), "a Die rolled outisde expected range"); // checks the 3 returned die, produces error if not between 1 and 6
            }
            Console.WriteLine("Testing game class and methods complete");
        }
        /// <summary>
        /// this method TestingDie tests the Die class and that its own method Roll correctly returns a expected int value from 1 to 6 
        /// </summary>
        public void TestingDie()
        {
            Die testDie = new Die(); // creating new die object
            int testRoll=testDie.Roll();
            Debug.Assert((7 > testRoll && testRoll > 0), "die rolled outside of expected range (1-6)"); // checking the die rolled within this class is above 0 and below 7
            Console.WriteLine("Testing die class and methods complete");
        }
    }
}
