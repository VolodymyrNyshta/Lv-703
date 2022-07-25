using System;

namespace Homework1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Homework1Task1
            Console.Write("Write the square's side value : ");
            string s = Console.ReadLine();
            string s1 = string.Empty; //string of numbers to convert into Int32
            foreach (char value in s)
            {
                if (char.IsNumber(value))
                {
                    s1 = string.Concat(s1, value);
                }
            }
            int a = Convert.ToInt32(s1); //square's side value
            int area = a * a;
            int perimeter = 4 * a;
            Console.WriteLine($"The area of the square with side length {a} is {area} and its perimeter equals {perimeter}\n");
            Console.WriteLine("Press 'ENTER' to go to the next Task... \n");
            while (Console.ReadKey(true).Key != ConsoleKey.Enter)
            {

            }

            //Homework1Task2
            string name;
            int age;
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            Console.WriteLine("How old are you, {0}?", name);
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{name} is {age}.\n");
            Console.WriteLine("Press 'ENTER' to go to the next Task... \n");
            while (Console.ReadKey(true).Key != ConsoleKey.Enter)
            {

            }

            //Homework1Task3
            Console.Write("Write the radius of the circle : ");
            double r = Convert.ToDouble(Console.ReadLine());
            double length = 2 * Math.PI * r;
            double circleArea = Math.PI * r * r;
            double volume = (double)4 / 3 * Math.PI * r * r * r;
            Console.WriteLine($"The length of the circle : {length}, its area : {circleArea}, and the volume : {volume}.\n");
            Console.WriteLine("Press 'ENTER' to end a program... \n");
            while (Console.ReadKey(true).Key != ConsoleKey.Enter)
            {

            }
        }
    }
}
