﻿using System;
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
            Testing test1 = new Testing();
            Console.WriteLine(test1.testingDie());

            Game franksGame = new Game();
            franksGame.Roller();
            Console.ReadLine();
            /*
             * Create a Game object and call its methods.
             * Create a Testing object to verify the output and operation of the other classes.
             */
        }
    }
}
