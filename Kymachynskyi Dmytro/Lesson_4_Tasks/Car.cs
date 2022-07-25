using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4
{
    internal class Car
    {
        public const string brand = "Suzuki";
        private string model;
        private string color;
        private double price;
        public Car()
        {
            model = "Vitara";
            color = "white";
            price = 24000.0;
        }
        public Car(string model, string color, double price)
        {
            this.model = model;
            this.color = color;
            this.price = price;
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public static Car Input(int i)
        {
            Console.Write($"Enter {i + 1} car model: ");
            string model = Console.ReadLine();
            Console.Write($"Enter {i + 1} car color: ");
            string color = Console.ReadLine();
            Console.Write($"Enter {i + 1} car price: ");
            double price = Convert.ToDouble(Console.ReadLine());
            Car car = new Car(model, color, price);
            return car;
        }
        public void Print()
        {
            Console.WriteLine($"Car: {brand} {model} Color: {color} Price: {price}");
        }
        public void ChangePrice(double changeValue)
        {
            price -= price * changeValue / 100;
        }
        public static bool operator == (Car first, Car second)
        {
            return first.model == second.model && first.price == second.price;
        }
        public static bool operator != (Car first, Car second)
        {
            return first.model != second.model && first.price != second.price;
        }
        public override string ToString()
        {
            return "Car "+brand+" "+model+" ("+color+" color) for "+price+" USD";
        }
    }
}
