﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        public bool testingDie() { // called within the program.cs returning a true or false indicating if the Die works well or not
            bool worksWell = true;
            int checkVar = 0;

            /*  // Old code used to try and roll 1,2,3,4,5 and 6 from a die
            
            List<int> testList = new List<int>() { 0,0,0,0,0,0 };
            while (checkVar != 21) {
                Die testDie = new Die(); // creating die to test
                int testRoll = testDie.roll();
                if (testRoll < 7) {
                    testList[testRoll - 1] = testRoll; // adds the value to the list until list has 1,2,3,4,5,6
                }
                else
                {
                    worksWell = false; // if a value is generated above 6
                }
                checkVar = testList.Sum(); // if the sum is 21 the loop ends
            }
            */

            Die testDie = new Die(); // creating die to test
            int testRoll = testDie.roll();
            Debug.Assert((testRoll < 7 && testRoll > 0), "a Die rolled outisde expected range"); // checking a die roll is between 1 and 6

            return worksWell; // returns bool value
        }
        public bool testingGame(){
            bool worksWell = true;
            Game testGame = new Game(); // creating new game
            List<int> returnList = new List<int>();
            returnList = testGame.Roller();
            float averageValue = returnList[3] / 3;

            Debug.Assert((returnList[3] < 18), "Sum of die values too large (above 18)");// if sum of 3 die rolls above 18 
            Debug.Assert((returnList[3] > 3), "Sum of die values too small (below 3)");// if sum of 3 die rolls below 3
            Debug.Assert((averageValue < 6), "average die value (from sum) is too large (above 6)");// if average die value is above 6
            for (int i = 0; i <= 2; i++) // reworked into a for loop
            {
                Debug.Assert(((returnList[i] < 7 && returnList[i] > 0)), "a Die rolled outisde expected range");
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
