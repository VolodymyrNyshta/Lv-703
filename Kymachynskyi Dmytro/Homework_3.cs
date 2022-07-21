using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            Console.WriteLine("Enter string: ");
            string str = Console.ReadLine();
            int aCount = 0;
            int oCount = 0;
            int iCount = 0;
            int eCount = 0;
            for (int i = 0; i < str.Length; i++)
            {
                switch (str[i])
                {
                    case 'a': aCount++; break; 
                    case 'o': oCount++; break;
                    case 'i': iCount++; break;
                    case 'e': eCount++; break;
                }
            }
            Console.WriteLine($"Characters counted - 'a':{aCount} 'o':{oCount} 'i':{iCount} 'e':{eCount}");

            //Task 2
            int LeapYear(int yearToCheck)
            {
                if ((yearToCheck % 4) == 0)
                {
                    if ((yearToCheck % 100) == 0)
                    {
                        if ((yearToCheck % 400) == 0) return 1;
                        else return 0;
                    }
                    else return 1;
                }
                else return 0;
            }
            Console.WriteLine("\nEnter year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter month (number): ");
            int month = Convert.ToInt32(Console.ReadLine());

            //1st method
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine($"1st method: {year} year {month} month - 31 days");
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine($"1st method: {year} year {month} month - 30 days");
                    break;
                case 2:
                    Console.WriteLine($"1st method: {year} year {month} month - {28 + LeapYear(year)} days");
                    break;
            }

            //2nd method
            int days = 28 + ((month + (month / 8)) % 2) + 2 % month + ((1 + LeapYear(year)) / month) + (1 / month) - (LeapYear(year) / month);
            Console.WriteLine($"2nd method: {year} year {month} month - {days} days");
            
            //Task 3
            Console.WriteLine("\nEnter 10 integer numbers: ");
            int[] numbers = new int[10];
            for (int i = 0; i < 10; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            int sum = 0;
            int product = 1;
            for (int i = 0; i < 10; i++)
            {
                if (i < 5)
                {
                    if (numbers[i] > 0) sum += numbers[i];
                    else
                    {
                        i = 5;
                        sum = -1;
                    }
                }
                if ((i >= 5) && (sum == -1)) product *= numbers[i];
            }
            Console.WriteLine(sum >= 0 ? $"Sum of the first 5 elements: {sum}" : $"Product of the last 5 elements: {product}");
        }
    }
}