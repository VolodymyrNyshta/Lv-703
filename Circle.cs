namespace Vitaliy_S_HW_9
{
    class Circle : Shape
    {
        private double radius;
        public Circle(string name, double radius) : base(name)
        {
            this.radius = radius;
        }
        public override double Area()
        {
            return Math.PI * (radius * radius);
        }
        public override double Perimetr()
        {
            return 2 * Math.PI * radius;
        }
    }
}
