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
        /// <summary>
        ///  this method Roll is used to generate a random value from 1 to 6
        /// </summary>
        /// <returns> the roll value of the die object </returns>
        public int Roll()// returns integer and takes no parameters
        {
            int rollValue = random.Next(1, 7); // generates a value from 1 but below 7 (1->6) and acts as a property that holds the die value
            return rollValue; 
        }

    }
}
