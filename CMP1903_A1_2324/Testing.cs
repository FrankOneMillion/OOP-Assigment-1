﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        public bool test() {
            bool worksWell = true;
            int checkVar = 0;
            List<int> testList = new List<int>() { 0,0,0,0,0,0 };
            while (checkVar != 21) {
                Die testDie = new Die();
                int testRoll = testDie.roll();
                if (testRoll < 7) {
                    testList[testRoll - 1] = testRoll; // adds the value to the list until list has 1,2,3,4,5,6
                }
                else
                {
                    worksWell = false;
                }
                checkVar = testList.Sum();
            }
            return worksWell;
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
