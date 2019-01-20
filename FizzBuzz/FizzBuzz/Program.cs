using System;

namespace FizzBuzz
{
    internal static class Program
    {
        public static void Main()
        {
            /*
             * Print out all numbers from 1 to 100.
             * Except if a number is a multiple of 3, then print out Fizz instead.
             * If the number is a multiple of 5, then print out Buzz.
             * But if a number is a multiple of 3 and 5 then print out FizzBuzz.
             */

            for (int i = 1; i < 101; i++)
            {
                bool isMultipleOfThree = i % 3 == 0;
                bool isMultipleOfFive = i % 5 == 0;

                if (isMultipleOfThree && ! isMultipleOfFive)
                {
                    Console.Write("Fizz ");
                    continue;
                }
                
                if (! isMultipleOfThree && isMultipleOfFive)
                {
                    Console.Write("Buzz ");
                    continue;
                }

                if (isMultipleOfThree && isMultipleOfFive)
                {
                    Console.Write("FizzBuzz ");
                    continue;
                }

                Console.Write($"{i} ");
            }
        }
    }
}