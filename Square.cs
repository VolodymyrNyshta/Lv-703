namespace Vitaliy_S_HW_9
{
    class Square : Shape
    {
        private double side;
        public Square(string name, double side) : base(name)
        {
            this.side = side;
        }
        public override double Area()
        {
            return 2 * side;
        }
        public override double Perimetr()
        {
            return 4 * side;
        }
    }
}
