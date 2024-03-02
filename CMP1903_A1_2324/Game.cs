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
            Console.WriteLine("Rolled {0},{1},{2}", firstRoll,secondRoll,thirdRoll);
            return sum;
            
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
