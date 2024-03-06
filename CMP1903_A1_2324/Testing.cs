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
            int numberOfRolls = 3;
            Game testGame = new Game(); // creating new game object
            // die objects created within this new game object and tested through their returned values 
            List<int> returnList = new List<int>(); // creating a list to hold returned values from game()
            returnList = testGame.Roller(numberOfRolls); // calling method
            float averageValue = returnList[numberOfRolls] / numberOfRolls;

            // comparing expected output using debug.Assert to make comparisons
            Debug.Assert((returnList[numberOfRolls] < (numberOfRolls*6)), "Sum of die values too large (above sum of die * 6)"); // returns error if sum of all die is more than the maximum (6(max die value)*number of die)
            Debug.Assert((returnList[numberOfRolls] > numberOfRolls), "Sum of die values too small (below 3)"); // returns error if sum of die rolls below the count of die rolls
            Debug.Assert(((returnList[0] + returnList[1] + returnList[2]) == returnList[3]), "Sum of die value does not equal actual sum of die"); // returns error if passed sum is not equal to addition of the three die
            for (int i = 0; i <= (numberOfRolls-1); i++) // a for loop to check die rolled within the game loop
            {
                Debug.Assert(((returnList[i] < 7 && returnList[i] > 0)), "a Die rolled outisde expected range"); // checks the returned die, produces error if any die not between 1 and 6
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
