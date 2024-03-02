using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        static Random random = new Random(); //importing use of random into project
        public int roll() {
            int rollValue = random.Next(1, 7);
            return rollValue;
        }
        /*
         * The Die class should contain one property to hold the current die value,
         * and one method that rolls the die, returns and integer and takes no parameters.
         */

        //Property


        //Method


    }
}
