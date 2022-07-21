using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            Console.Write("Enter day: " );
            int day = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter month: ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(day > 0 && day < 32 ? "{0} is the day" : "{0} is not a day", day);
            Console.WriteLine(month > 0 && month < 13 ? "{0} is the month" : "{0} is not a month", month);
            
            //Task 2
            //---- Not working with value 3,78 value -------
            Console.Write("\nEnter double number: ");
            double number = Convert.ToDouble(Console.ReadLine());
            int firstResult = (int)((number - (int)number) * 10);
            int secondResult = (int)((((number - (int)number) * 10) - firstResult) * 10);
            Console.WriteLine($"{firstResult} + {secondResult} = {firstResult + secondResult}");

            //---- Good working -------
            Console.Write("\nEnter double number: ");
            double numberV2 = Convert.ToDouble(Console.ReadLine());
            double firstResultV2 = Math.Truncate((numberV2 - Math.Truncate(numberV2)) * 10);
            double secondResultV2 = Math.Truncate(numberV2 * 100 - Math.Truncate(numberV2 * 10) * 10);
            Console.WriteLine($"{firstResultV2} + {secondResultV2} = {firstResultV2 + secondResultV2}");

            //Task 3
            Console.Write("\nEnter hour: ");
            int h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(h >= 0 && h < 6 ? "Good night!" : 
                h >= 6 && h <12 ? "Good morning!" : 
                h >= 12 && h < 18 ? "Good afternoon!" : 
                h >= 18 && h <= 24 ? "Good evening!" : "Your are enter wrong value!");

            //Task 4
            TestCaseStatus test1Status = TestCaseStatus.Pass;
            Console.WriteLine("\nStatus{0}",test1Status);

            //Task 5
            RGB whiteColor;
            whiteColor.r = 255;
            whiteColor.g = 255;
            whiteColor.b = 255;

            RGB blackColor;
            blackColor.r = 0;
            blackColor.g = 0;
            blackColor.b = 0;
            Console.WriteLine($"\nWhite color in RGB - R:{whiteColor.r} G:{whiteColor.g} B:{whiteColor.b}");
            Console.WriteLine($"Black color in RGB - R:{blackColor.r} G:{blackColor.g} B:{blackColor.b}");

        }
        enum TestCaseStatus { Pass, Fail, Blocked, WP, Unexecuted };
        struct RGB
        {
            public byte r;
            public byte g;
            public byte b;
        }

    }
}