using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
       public int Roller()
        {
            int sum = 0;
            Die die1 = new Die();
            Die die2 = new Die();
            Die die3 = new Die();
            int firstRoll = die1.roll();
            int secondRoll = die2.roll();
            int thirdRoll = die3.roll();
            sum = (firstRoll + secondRoll + thirdRoll);
            float sumAsFloat = sum;
            float averageRoll = (sumAsFloat / 3);
            int high = 0; // set to value lower than possible roll on a die
            int low = 10; // set to a higher value than die can roll to ensure that any possible rolled value by the die is smaller
            List<int> listOfDie = new List<int>() {firstRoll,secondRoll,thirdRoll};
           
            for (int i = 0; i < 3; i++) { // the loop goes through each value in list of die (3 values)
                if (high < listOfDie[i]) { 
                    high = listOfDie[i];
                }
                if (low > listOfDie[i]) { 
                    low = listOfDie[i];
                }
            }
            int range = (high - low);
            Console.WriteLine("Rolled {0},{1},{2}", firstRoll, secondRoll, thirdRoll);
            Console.WriteLine("sum:{0} average:{1} lowest:{2} highest:{3} range:{4}", sum, averageRoll, low, high, range);
            return sum; //returns sum to test
            
        }
        
        /*
         * The Game class should create three die objects, roll them, sum and report the total of the three dice rolls.
         *
         * EXTRA: For extra requirements (these aren't required though), the dice rolls could be managed so that the
         * rolls could be continous, and the totals and other statistics could be summarised for example.
         */

        //Methods

    }
}
