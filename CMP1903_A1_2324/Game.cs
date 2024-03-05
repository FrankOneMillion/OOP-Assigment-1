using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
       public List<int> Roller()
        {
            int sum = 0;
            List<int> returnList = new List<int>(); // a list created which holds the values that will be returned from this method
            List<string> possibleAnswers = new List<string>() { "yes","no" }; // holds values of the two expected answers from the user when asked if they wish to continue
            string answer = "yes";
            while (answer != "no") // loops until user enters "no" after being asked if they wish to roll again
            {

                Die die1 = new Die(); // creating new die objects
                Die die2 = new Die();
                Die die3 = new Die();
                int firstRoll = die1.Roll(); // calling the objects to run their roll method which return an int value
                int secondRoll = die2.Roll();
                int thirdRoll = die3.Roll();
                sum = (firstRoll + secondRoll + thirdRoll); // creating a sum of the three returned int values for each dies face value
                float sumAsFloat = sum;
                float averageRoll = (sumAsFloat / 3);
                int high = 0; // set to value lower than possible roll on a die
                int low = 10; // set to a higher value than die can roll to ensure that any possible rolled value by the die is smaller
                List<int> listOfDie = new List<int>() { firstRoll, secondRoll, thirdRoll };
                returnList=listOfDie;
                returnList.Add(sum);
                for (int i = 0; i < 3; i++)
                { // the loop goes through each value in list of die (3 values) to find the lowest and highest int value
                    if (high < listOfDie[i])
                    {
                        high = listOfDie[i];
                    }
                    if (low > listOfDie[i])
                    {
                        low = listOfDie[i];
                    }
                }
                int range = (high - low);
                Console.WriteLine("Rolled {0},{1},{2}", firstRoll, secondRoll, thirdRoll);
                Console.WriteLine("sum:{0} average:{1} lowest:{2} highest:{3} range:{4} do you wish to continue rolling? yes/no :", sum, averageRoll, low, high, range); // returning statistics to user
                answer = Console.ReadLine(); // gathers answer from user
                Debug.Assert((possibleAnswers.Contains(answer)), "yes or no where not stated"); // returns error if an expected answer is not given, however will still run until 'no' is entered to prevent further errors
            }
            return returnList; //returns the values of the 3 die and sum
        }

    }
}
