using System;
namespace Homework9App1
{
    class Circle : Shape
    {
        private double radius;
        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }
        public Circle(string name) : base(name)
        {
            bool toSwitch = true;
            while (toSwitch)
            {
                Console.Write("Circle radius : ");
                string radius = Console.ReadLine();
                double result = 0;
                bool parsable = double.TryParse(radius, out result);
                if (parsable)
                {
                    Radius = Convert.ToDouble(radius);
                    toSwitch = false;
                }
                else if (!parsable)
                {
                    Console.WriteLine("Cannot parse inputed string into the Double, input radius again!!!");
                }
            }
        }
        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
        public override double Perimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
