using System;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter side of the square: ");
            int a = int.Parse(Console.ReadLine());
            int squareAria = a * a;
            int squarePerimetr = a + a;
            Console.WriteLine($"Square aria = {squareAria}");
            Console.WriteLine($"Square perimetr = {squarePerimetr}");

            Console.Write("\nWhat is you name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"How old are you, {name}?");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine($"{name} is {age}.");

            Console.Write("\nEnter radius of the circle:");
            double radius = double.Parse(Console.ReadLine());
            double length = 2 * Math.PI * radius;
            double area = Math.PI * Math.Pow(radius, 2);
            double volume = (4 / 3) * Math.PI * Math.Pow(radius, 3);
            Console.WriteLine($"Length of circle = {length :F2}");
            Console.WriteLine($"Area of circle = {area :F2}");
            Console.WriteLine($"Volume of circle = {volume :F2}");
        }
    }
}
