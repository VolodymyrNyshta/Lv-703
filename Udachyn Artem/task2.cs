using System;

namespace task2_SoftServe
{
    enum TestCaseStatus
    {
        Pass,
        Fail,
        Blocked,
        WP,
        Unexecuted
    }
    struct RGB
    {
        public byte red;
        public byte green;
        public byte blue;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("task1");

            int day = Convert.ToInt32(Console.ReadLine());
            int month = Convert.ToInt32(Console.ReadLine());
            if ((day > 0 && day < 32) && (month > 0 && month < 13))
            {
                Console.WriteLine("Day {0}, month {1}", day, month);
            }

            Console.WriteLine("Task2");
            double num = Convert.ToDouble(Console.ReadLine());
            double n = (int)(num * 100) % 100;
            double sum = (n % 10) + (int)n / 10;
            Console.WriteLine(sum);

            Console.WriteLine("Task3");
            int h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(h < 8 && h >= 1 ? "Good morning!" : h >= 8 && h < 14 ?
            "Good afternoon!" : h >= 14 && h < 20 ? "Good evening!" : h >= 20 && h < 24 ?
            "Good night!" : "time from 1 to 24");


            Console.WriteLine("Task4");
            TestCaseStatus test1Status = 0;
            Console.WriteLine(test1Status);

            Console.WriteLine("Task5");
            RGB white = new RGB { red = 255, green = 255, blue = 255 };
            RGB black = new RGB { red = 0, green = 0, blue = 0 };
        }
    }
}
