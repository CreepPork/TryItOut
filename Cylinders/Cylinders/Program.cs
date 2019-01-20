using System;

namespace Cylinders
{
    internal static class Program
    {
        public static void Main()
        {
            Console.WriteLine("Cylinder Calculator!");

            Console.WriteLine("Enter radius r: ");
            double radius = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter height h: ");
            double height = Convert.ToInt32(Console.ReadLine());

            double volume = CalculateVolume(radius, height);
            Console.WriteLine($"Volume of cylinder is {volume} units.");

            double surface = CalculateSurface(radius, height);
            Console.WriteLine($"Surface area of the cylinder is {surface} units.");
        }

        private static double CalculateVolume(double radius, double height)
        {
            return Math.PI * Math.Pow(radius, 2) * height;
        }

        private static double CalculateSurface(double radius, double height)
        {
            return 2 * Math.PI * radius * (radius + height);
        }
    }
}