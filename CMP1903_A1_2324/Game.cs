using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
       public int Roller()
        {
            Die die1 = new Die();
            Die die2 = new Die();
            Die die3 = new Die();
            int firstRoll = die1.roll();
            int secondRoll = die2.roll();
            int thirdRoll = die3.roll();

            Console.WriteLine("Rolled {0},{1},{2}", firstRoll,secondRoll,thirdRoll);
            return firstRoll;
            
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
