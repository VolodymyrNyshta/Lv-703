using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Task 1
            Console.Write("Enter a integer number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter b integer number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            for (int i = a; i <= b; i++)
            {
                if ((i % 3) == 0)
                    result++;
            }
            Console.WriteLine(result);

            //Task 2
            Console.Write("\nEnter a string: ");
            string text = Console.ReadLine();
            for (int i = 1; i < text.Length; i++)
            {
                Console.Write(text[i]);
                i++;
            };
            Console.Write("\n");

            //Task 3
            Console.WriteLine("\nChoose drink - coffee, tea, juice, water: ");
            string drink = Convert.ToString(Console.ReadLine());
            switch (drink.ToLower())
            {
                case "coffee" : Console.WriteLine("You choose Coffee for 30 UAH"); break;
                case "tea" : Console.WriteLine("You choose Tea for 20 UAH"); break;
                case "juice": Console.WriteLine("You choose Juice for 25 UAH"); break;
                case "water": Console.WriteLine("You choose Water for 15 UAH"); break;
                default : Console.WriteLine("Unknown drink!"); break;
            }

            //Task 4
            Console.WriteLine("\nEnter sequence integers: ");
            double sum = 0;
            int n = 0;
            double number;
            do
            {
                number = Convert.ToDouble(Console.ReadLine());
                sum += number;
                n++;
            }
            while (number >= 0);
            n--;
            sum -= number;
            Console.WriteLine($"{sum} / {n} = {sum/n}");
            
            //Task 5
            bool LeapYear(int yearToCheck)
            {
                if ((yearToCheck % 4) == 0)
                {
                    if ((yearToCheck % 100) == 0)
                    {
                        if ((yearToCheck % 400) == 0) return true;
                        else return false;
                    }
                    else return true;
                }
                else return false;
            }
            Console.WriteLine("\nEnter year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(LeapYear(year) ? "{0} is a leap year (366 days)" : 
                "{0} is not a leap year (365 days)", year);
            
            //Task 6
            Console.WriteLine("\nEnter integer number: ");
            int numberT6 = Convert.ToInt32(Console.ReadLine());
            int sumT6 = 0;
            while (numberT6 > 0)
            {
                sumT6 += numberT6 % 10;
                numberT6 /= 10;
            }
            Console.WriteLine("Sum of digits of the entered number is: {0}", sumT6);
            
            //Task 7
            Console.WriteLine("\nEnter integer number: ");
            int numberT7 = Convert.ToInt32(Console.ReadLine());
            bool OddCheck (int numberToCheck)
            {
                bool oddFlag = false;
                while (numberToCheck > 0)
                {
                    if ((numberToCheck % 10 % 2) != 0)
                    {
                        oddFlag = true;
                    }
                    else
                    {
                        oddFlag = false;
                        break;
                    }
                    numberToCheck /= 10;
                }
                return oddFlag;
            }
            Console.WriteLine(OddCheck(numberT7) ? "This number contain only odd digits" : "This number contain even digit(s)");
           
 
        }
    }
}
