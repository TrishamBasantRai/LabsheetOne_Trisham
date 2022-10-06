using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class LabOne
    {
        public LabOne()
        {
            int lowerBound = 0; //This variable will hold the lowerbound value of a category
            int thresholdIncrementValue = 20; //The value by which the threshold increases
            int exitAppValue = -1; //The user input value that will cause the app to exit

            //looping through enum
            foreach (var category in Enum.GetValues(typeof(Category)))
            {

                Console.WriteLine($"Category: {category} has the range of {lowerBound} - {(int)category}");
                lowerBound = (int)category + 1; //Adding 1 since the value of the next range will start at threshold of current range plus 1
            }

            int userInput;

            while (true)
            {
                Console.Write("Enter a number: ");
                userInput = int.Parse(Console.ReadLine());

                //Exit the app if true
                if (userInput == exitAppValue)
                {
                    break;
                }

                //If user input is not the same as threshold
                if ((userInput % thresholdIncrementValue) != 0)
                {
                    //perform operations to user input to bring the value to a threshold value
                    userInput = ((userInput / thresholdIncrementValue) * thresholdIncrementValue) + thresholdIncrementValue;
                }

                Console.WriteLine($"Category is: {(Category)userInput}");

            }

            Console.WriteLine("You exited the app!");

        }

        enum Category
        {
            E = 20,
            D = 40,
            C = 60,
            B = 80,
            A = 100
        }
    }
}
