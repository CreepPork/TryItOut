using System;

namespace PrintAPyramid
{
    internal static class Program
    {
        public static void Main()
        {
            /* Print a pyramid that has 5 rows using loops.
             *
             *        *
             *       ***
             *      *****
             *     *******
             *    *********
             *
             * There is a pattern between each level:
             *     Row:     n
             *     Spaces:  5 - n - 1
             *     Stars:   n * 2 + 1
             */

            Console.WriteLine("Print-a-Pyramid!");

            const int levels = 5;

            for (int row = 0; row < levels; row++)
            {
                for (int space = 0; space < levels - row - 1; space++)
                {
                    Console.Write(" ");
                }

                for (int star = 0; star < row * 2 + 1; star++)
                {
                    Console.Write("*");
                }
                
                Console.WriteLine();
            }
        }
    }
}