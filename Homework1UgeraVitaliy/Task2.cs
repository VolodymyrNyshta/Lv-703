using System;

namespace Task2
{
    internal class Program
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

            public void FullRGBColorOutput()
            {
                Console.WriteLine($"RGB ({red}, {green}, {blue})");
            }
        }

        static void Main(string[] args)
        {
            //Task2Part1
            Console.Write("Write the day's value : ");
            int day = Convert.ToInt32(Console.ReadLine());
            if (day > 0 && day <= 31)
            {
                Console.WriteLine($"The day's value is {day}");
            }
            else
            {
                Console.WriteLine("That's not correct value for the day!");
            }
            Console.Write("Write the month's value : ");
            int month = Convert.ToInt32(Console.ReadLine());
            if (month > 0 && month <= 12)
            {
                Console.WriteLine($"The month's value is {month}\n");
            }
            else
            {
                Console.WriteLine("That's not correct value for the month!\n");
            }

            //Task2Part2
            Console.Write("Print a floating-point number to parse : ");
            string s = Console.ReadLine();
            string connectedString = string.Empty;
            bool cheked = false;
            foreach (char item in s)
            {
                if (char.IsPunctuation(item) || cheked == true)
                {
                    if (cheked)
                    {
                        connectedString = string.Concat(connectedString, item);
                    }
                    cheked = true;
                }
            }
            string firstNumberString = connectedString.Substring(0, 1);
            string secondNumberString = connectedString.Substring(1, 1);
            int firstNumber = Convert.ToInt32(firstNumberString);
            int secondNumber = Convert.ToInt32(secondNumberString);
            int sum = firstNumber + secondNumber;
            Console.WriteLine($"Sum output : {sum}\n");

            //Task2Part3
            Console.Write("Write an \"hour\" value : ");
            int h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((h >= 6 && h < 12) ? "Good morning!\n" : (h >= 12 && h < 18) ? "Good afternoon!\n" :
                (h >= 18 && h < 24) ? "Good evening!\n" : (h == 24 && h < 6) ? "Good night\n" : "What is the time?\n");

            //Task2Part4
            Console.WriteLine("Assigning status “Pass” for variable test1Status and output it on the console :");
            TestCaseStatus test1Status = new TestCaseStatus();
            test1Status = TestCaseStatus.Pass;
            Console.WriteLine($"Outputting {nameof(test1Status)} variable as {test1Status} equals to {(int)test1Status}");

            //Task2Part5
            Console.WriteLine("\nColors in RGB format : ");
            RGB white = new RGB();
            white.red = white.green = white.blue = 255;
            Console.WriteLine("Color is '{0}'", nameof(white));
            white.FullRGBColorOutput();
            RGB black = new RGB();
            Console.WriteLine("Color is '{0}'", nameof(black));
            black.red = black.green = black.blue = 0;
            black.FullRGBColorOutput();
            Console.Read();
        }
    }
}
