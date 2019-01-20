using System;

namespace AreaOfTriangle
{
    internal static class Program
    {
        public static void Main()
        {
            Console.WriteLine("Area of Triangle Calculator!");

            Console.WriteLine("Enter the base of the triangle: ");
            double baseOfTriangle = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Enter the height of the triangle: ");
            double heightOfTriangle = Convert.ToDouble(Console.ReadLine());

            // 1/2 * b * h
            double areaOfTriangle = 0.5 * baseOfTriangle * heightOfTriangle;
            
            Console.WriteLine($"Area of the triangle is {areaOfTriangle} units.");
        }
    }
}