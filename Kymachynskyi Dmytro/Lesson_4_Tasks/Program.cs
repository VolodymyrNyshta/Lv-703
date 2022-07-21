using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            var cars = new Car[4];
            cars[0] = car;
            for(int i = 1; i < cars.Length; i++)
            {
                cars[i] = Car.Input(i);
            }
            Console.WriteLine("\nEnter price decrease for cars in percents: ");
            double percents = Convert.ToDouble(Console.ReadLine());
            for (int i = 0; i < cars.Length; i++)
            {
                cars[i].ChangePrice(percents);
                cars[i].Print();
            }
            Console.WriteLine("\nEnter a new color for repaint white color car: ");
            string newColor = Console.ReadLine();
            for (int i = 0; i < cars.Length; i++)
            {
                if (cars[i].Color == "white")
                {
                    cars[i].Color = newColor;
                    Console.Write($"Car #{i + 1} repainted - ");
                    cars[i].Print();
                }
                else Console.WriteLine($"Car #{i + 1} not repainted");
            }
            Console.WriteLine();
            for (int i = 0; i < cars.Length; i++)
            {
                for (int j = i + 1; j < cars.Length; j++)
                {
                    if (cars[i] == cars[j])
                        Console.WriteLine($"Car #{i+1} equal to car #{j+1}");
                }
            }
            Console.WriteLine();
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i].ToString());
            }
        }
    }
}
