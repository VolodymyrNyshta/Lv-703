using System;

namespace Homework_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1");
            Console.Write("Enter square side length: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int squareArea = a * a;
            int squarePerimeter = a * 4; 
            Console.WriteLine($"Square area is: {squareArea}");
            Console.WriteLine($"Square perimeter is: {squarePerimeter}");
            
            Console.WriteLine("\nTask 2");
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            Console.Write("How old are you, {0}? ", name);
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your name is {0}, your age is {1} years", name, age);
            
            Console.WriteLine("\nTask 3");
            Console.Write("Enter circle radius: ");
            double r = Convert.ToDouble(Console.ReadLine());
            double circleLength = 2.0 * Math.PI * r;
            double circleArea = Math.PI * r * r;
            double sphereVolume = 4.0 / 3.0 * Math.PI * r * r * r;
            Console.WriteLine($"Circle length: {circleLength:F2}");
            Console.WriteLine($"Circle area: {circleArea:F2}");
            Console.WriteLine($"Sphere volume: {sphereVolume:F2}");

            Console.ReadKey();
        }
    }
}