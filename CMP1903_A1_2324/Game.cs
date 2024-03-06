using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {/// <summary>
     /// the method Roller creates die objects, rolls them and returns them to the user in addition to added statistics
     /// </summary>
     /// <returns> returns the values of the 3 die and sum </returns>
        public List<int> Roller(int numberOfRolls)
        {
            
            int sum = 0;
            List<int> returnList = new List<int>(); // a list created which holds the values that will be returned from this method
            List<string> possibleAnswers = new List<string>() { "yes","no" }; // holds values of the two expected answers from the user when asked if they wish to continue
            string answer = "yes";
            while (answer != "no") // loops until user enters "no" after being asked if they wish to roll again
            {
                sum = 0;
                List<int> listOfDie = new List<int>();
                for (int i = 0; i < numberOfRolls; i++) // loops 3 times to create 3 die objects if numberOfRolls set to 3
                {
                    Die loopedDie = new Die(); // creating new die object
                    int loopedDieRoll = loopedDie.Roll();
                    listOfDie.Add(loopedDieRoll);
                    sum += loopedDieRoll; // using the roll method within the die object and adding the returned int value to the sum
                }

                float sumAsFloat = sum;
                float averageRoll = (sumAsFloat / numberOfRolls);
                int high = 0; // set to value lower than possible roll on a die
                int low = 10; // set to a higher value than die can roll to ensure that any possible rolled value by the die is smaller
                returnList=listOfDie;
                returnList.Add(sum);
                Console.WriteLine("Rolled:");
                for (int i = 0; i < numberOfRolls; i++)
                { // the loop goes through each value in list of die (3 values) to find the lowest and highest int value
                    if (high < listOfDie[i])
                    {
                        high = listOfDie[i];
                    }
                    if (low > listOfDie[i])
                    {
                        low = listOfDie[i];
                    }
                    Console.Write("{0},", listOfDie[i]);
                }
                int range = (high - low);
      
                Console.WriteLine();
                Console.WriteLine("sum:{0} average:{1} lowest:{2} highest:{3} range:{4} do you wish to continue rolling? yes/no :", sum, averageRoll, low, high, range); // returning statistics to user
                answer = Console.ReadLine(); // gathers answer from user
                Debug.Assert((possibleAnswers.Contains(answer)), "yes or no where not stated"); // returns error if an expected answer is not given, however will still run until 'no' is entered to prevent further errors
            }
            return returnList; //returns the values of the 3 die and sum
        }

    }
}
