using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Testing test1 = new Testing(); // creating a testing object

            test1.TestingGame(); // runs the method wich tests multiple elements for the game class
            test1.TestingDie(); // runs the die testing method which rolls a die and checks its returned value is between 1 and 6
            Console.ReadLine(); // allows user to read returned values before program is closed

        }
    }
}
