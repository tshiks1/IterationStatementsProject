using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a List called "numbers" - DONE
            List<int> numbers = new List<int>();

            //Create a variable of type int and initialize the variable with a value of 0 -DONE
            int number = 0;


            // Create a do-while loop
            do
            {
                number++;
                // Increment your variable by 1

                // Then add your variable to "numbers"
                numbers.Add(number);
            }
            while (number < 100);
            // While your variable is less than 100


            while(number<200)
            // Create a while loop
            // While your variable is less than 200
            {
                number++;
                numbers.Add(number);
                // Increment your variable by 1

                // Then add your variable to "numbers"
                Console.WriteLine("Increase:");
            }

           // Console.WriteLine("Increase:");

            // Create a foreach loop
            // Write your variable to the console
             foreach( int item in numbers)
            {
                Console.WriteLine("");
                Console.WriteLine("Decrease:");
            }
            

            // Create a for loop
            // in your initializer set the value of i to 199
            // in your conditional, as long as i is less than or equal to the amount of items in "numbers" (numbers.Count)
            // and as long as i is greater than or equal to 0
            // Decrement i by 1

             for(int i= 199;i<=numbers.Count && i>=0; --i)
            {
                Console.WriteLine($"numbers[i]");
                // Write to the console "numbers" at index i
            }
        }
    }
}
