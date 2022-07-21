using System;
namespace Homework9App1
{
    class Square : Shape
    {
        private double side;
        public double Side
        {
            get { return side; }
            set { side = value; }
        }
        public Square(string name) : base(name)
        {
            bool toSwitch = true;
            while (toSwitch)
            {
                Console.Write("Square side : ");
                string side = Console.ReadLine();
                double result = 0;
                bool parsable = double.TryParse(side, out result);
                if (parsable)
                {
                    Side = Convert.ToDouble(side);
                    toSwitch = false;
                }
                else if (!parsable)
                {
                    Console.WriteLine("Cannot parse inputed string into the Double, input side again!!!");
                }
            }
        }
        public override double Area()
        {
            return Math.Pow(Side, 2);
        }
        public override double Perimeter()
        {
            return Side * 4;
        }
    }
}
