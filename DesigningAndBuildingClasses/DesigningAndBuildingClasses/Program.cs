using System;

namespace DesigningAndBuildingClasses
{
    internal static class Program
    {
        public static void Main()
        {
            Ball ball = new Ball(5, new Color(255, 255, 0, 200));

            Console.WriteLine(ball.Thrown);
            Console.WriteLine(ball.Color.Grayscale());
            Console.WriteLine(ball.Size);
            
            ball.Throw();
            Console.WriteLine(ball.Thrown);
            
            ball.Pop();
            Console.WriteLine(ball.Thrown);
            
            ball.Throw();
            Console.WriteLine(ball.Thrown);
        }
    }
}