using System;
using System.Collections.Generic;
using System.Linq;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task3Part1
            Console.Write("Write the initial value of a range : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Write the last value of a range : ");
            int b = Convert.ToInt32(Console.ReadLine());
            int calculation = 0;
            while (a <= b)
            {
                if (a % 3 == 0)
                {
                    calculation++;
                }
                a++;
            }
            Console.WriteLine("Amount of integers that has no remainder while being divided by 3 : {0}\n", calculation);

            //Task3Part2
            Console.Write("Write something : ");
            string text = Console.ReadLine();
            string charsToConcat = string.Empty;
            for (int i = 0; i < text.Length; i++)
            {
                if ((i + 1) % 2 == 0 && i != 0)
                {
                    charsToConcat += text[i];
                }
            }
            Console.WriteLine("Output of just every second character of a written string : {0}\n", charsToConcat);

            //Task3Part3
            Console.Write("Enter your drink : ");
            string drink = Console.ReadLine();
            switch (drink)
            {
                case "coffe":
                    Console.WriteLine($"Name of a drink : {drink}, its price - 4$\n");
                    break;
                case "tea":
                    Console.WriteLine($"Name of a drink : {drink}, its price - 3$\n");
                    break;
                case "juice":
                    Console.WriteLine($"Name of a drink : {drink}, its price - 6$\n");
                    break;
                case "water":
                    Console.WriteLine($"Name of a drink : {drink}, its price - 1$\n");
                    break;
                default:
                    Console.WriteLine("Wrong drink!!!\n");
                    break;
            }

            //Task3Part4
            Console.WriteLine("Write the sequence of integers to find an average value (negative one will end the sequence, and will not be considered) : ");
            int inputedValue;
            List<int> inputedValues = new List<int>();
            do
            {
                inputedValue = Convert.ToInt32(Console.ReadLine());
                inputedValues.Add(inputedValue);
                Console.Write("");
            } while (inputedValue >= 0);
            inputedValues.RemoveAt(inputedValues.Count - 1);
            int sum = 0;
            foreach (int value in inputedValues)
            {
                sum += value;
            }
            Console.WriteLine("The average value of upward integers is : {0}\n", (double)sum / inputedValues.Count);

            //Task3Part5(Case 1)
            Console.Write("Write a year to check whether it is a leap year or not : ");
            int year1 = Convert.ToInt32(Console.ReadLine());
            bool isLeapYear1 = false;
            if (year1 % 4 == 0)
            {
                isLeapYear1 = true;
            }
            else
            {
                Console.WriteLine("Written year is a leap year!");
            }
            if (isLeapYear1 == true && year1 % 100 == 0)
            {
                if (year1 % 400 == 0)
                {
                    Console.WriteLine("Written year is a leap year!");
                }
                else
                {
                    Console.WriteLine("Written year is not a leap year!!!");
                }
            }
            else
            {
                Console.WriteLine("Written year is a leap year!");
            }
            //Task3Part5(Case 2)
            Console.Write("\nWrite a year to check whether it is a leap year or not : ");
            int year2 = Convert.ToInt32(Console.ReadLine());
            DateTime inputedYear = new DateTime(year2);
            bool isLeapYear2 = DateTime.IsLeapYear(inputedYear.Year);
            if (isLeapYear2)
            {
                Console.WriteLine("Written year is a leap year!");
            }
            else
            {
                Console.WriteLine("Written year is not a leap year!!!");
            }

            //Task3Part6
            Console.Write("\nEnter some number : ");
            string number = Console.ReadLine();
            int sumOfAllDigits = 0;
            foreach (char item in number)
            {
                int variable = Convert.ToInt32(item);
                sumOfAllDigits += variable;
            }
            Console.WriteLine("The sum of all digits in the inputed number : {0}\n", sumOfAllDigits);

            //Task3Part7
            Console.Write("Enter your integer number to parse : ");
            string integerNumberToParse = Console.ReadLine();
            bool numberHasNoEvenDigits = false;
            for (int i = 0; i < integerNumberToParse.Length; i++)
            {
                if (Convert.ToInt32(integerNumberToParse[i]) % 2 == 0)
                {
                    Console.WriteLine($"The number {Convert.ToInt32(integerNumberToParse)}, that you wrote, contains even numbers!!!");
                    break;
                }
                else
                {
                    numberHasNoEvenDigits = true;
                }
            }
            if (numberHasNoEvenDigits)
            {
                Console.WriteLine($"The number {Convert.ToInt32(integerNumberToParse)}, that you wrote, contains only odd numbers!");
            }
        }
    }
}
