using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digit a: ");
            int a = int.Parse(Console.ReadLine());
            if (a > 0 && a <= 12)
            {
                Console.WriteLine("You digit can be a month and day");
            }
            else if (a > 12 && a < 31)
            {
                Console.WriteLine("You digit can be a day");
            }
            else
            {
                Console.WriteLine("You digit can't be day or month");
            }
            Console.WriteLine(new string('*', 15));


            Console.WriteLine("Enter digit with float point b: ");
            double b = double.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < 2; i++)
            {
                sum += (int)(b * 10) % 10;
                b = b * 10;
            }
            Console.WriteLine(sum);
            Console.WriteLine(new string('*', 15));

            Console.WriteLine("Enter time of day: ");
            int h = int.Parse(Console.ReadLine());

            Console.WriteLine((h >= 6 && h <= 10) ? "Good morning" : (h > 10 && h <= 19) ? "Good day" : (h > 19 && h <= 22) ? "Good evening" : "Good night");
            Console.WriteLine(new string('*', 15));


            TestCaseStatus test1Status = TestCaseStatus.Pass;
            Console.WriteLine($"{test1Status} = {(int)test1Status}");
            Console.WriteLine(new string('*', 15));

            RGB white = new RGB(255, 255, 255);
            RGB black = new RGB(0, 0, 0);
            Console.WriteLine(white);
            Console.WriteLine(black);
            Console.WriteLine(new string('*',15));

            Console.ReadKey();

        }
        struct RGB 
        {
            byte red;
            byte green;
            byte blue;

            public RGB(byte red, byte green, byte blue)
            {
                this.red = red;
                this.green = green;
                this.blue = blue;
            }
         
            public override string ToString()
            {
                return string.Format($"Red = {red}\nGreen = {green}\nBlue = {blue}");
            }
        }
        enum TestCaseStatus
        {
            Pass,
            Fail,
            Blocked,
            WP,
            Unexecuted
        }
    }
}
