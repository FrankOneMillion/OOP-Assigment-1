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
        public int roll()// returns integer and takes no parameters
        {
            int rollValue = random.Next(1, 7); // generates a value from 1 but below 7 (1->6) and acts as a property that holds the die value
            return rollValue; 
        }

    }
}
