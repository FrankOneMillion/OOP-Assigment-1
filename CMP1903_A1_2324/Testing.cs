using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        
        public bool testingGame(){
            bool worksWell = true;
            Game testGame = new Game(); // creating new game
            List<int> returnList = new List<int>(); // creating a list to hold returned values from game()
            returnList = testGame.Roller();
            float averageValue = returnList[3] / 3;
            Debug.Assert((returnList[3] < 18), "Sum of die values too large (above 18)");// returns error if sum of 3 die rolls above 18 
            Debug.Assert((returnList[3] > 3), "Sum of die values too small (below 3)");// returns error if sum of 3 die rolls below 3
            Debug.Assert(((returnList[0] + returnList[1] + returnList[2]) == returnList[3]), "Sum of die value does not equal actual sum of die");// returns error if passed sum is not equal to addition of the three die
            Debug.Assert((averageValue < 6), "average die value (from sum) is too large (above 6)");// returns error if average die value is above 6
            for (int i = 0; i <= 2; i++) // reworked into a for loop
            {
                Debug.Assert(((returnList[i] < 7 && returnList[i] > 0)), "a Die rolled outisde expected range"); // checks the 3 returned die, produces error if not between 1 and 6
            }   
            Debug.Assert(worksWell, "dosnt work well");

            return worksWell; // returns bool value
        }
        /*
         * This class should test the Game and the Die class.
         * Create a Game object, call the methods and compare their output to expected output.
         * Create a Die object and call its method.
         * Use debug.assert() to make the comparisons and tests.
         */

        //Method
    }
}
