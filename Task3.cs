using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1
            Console.WriteLine("Enter two integer digit a and b:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int count = 0;
            if (a > b)
            {
                int tmp = a;
                a = b;
                b = tmp;
            }
            for (int i = a; i < b; i++)
            {
                if (i % 3 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine($"{count} digits are divided by 3 without remainder");
            Console.WriteLine("---------------------");

            //Task2
            Console.WriteLine("Enter some text: ");
            string text = Console.ReadLine();
            for (int i = 1; i < text.Length; i = i + 2)
            {
                Console.WriteLine(text[i]);
            }

            //Task3
            Console.WriteLine("Enter the name of the drink (coffee, tea, juice, water).");
            string userDrink = Console.ReadLine();
            switch (userDrink.ToLower())
            {
                case "coffee":
                    {
                        Console.WriteLine($"Coffee price is 20 hrn");
                        break;
                    }
                case "tea":
                    {
                        Console.WriteLine($"Tea price is 15 hrn");
                        break;
                    }
                case "juice":
                    {
                        Console.WriteLine($"Juice price is 25 hrn");
                        break;
                    }
                case "water":
                    {
                        Console.WriteLine($"Water price is 10 hrn");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Undefined drink");
                        break;
                    }
            }

            //Task4
            int userDigit = 1;
            int sum1 = 0;
            int count1 = 0;
            Console.WriteLine("Enter digits:");

            while (userDigit >= 0)
            {
                userDigit = int.Parse(Console.ReadLine());
                if (userDigit < 0)
                {
                    break;
                }
                sum1 += userDigit;
                count1++;
            }

            double result = (double)sum1 / count1;
            Console.WriteLine($"Everege = {result}");

            //Task5
            Console.WriteLine("Enter year: ");
            int year = int.Parse(Console.ReadLine());
            if (year % 4 == 0 && (year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine("Year is leap");
            }
            else
            {
                Console.WriteLine("Year is not leap");
            }

            //Task6 - 7

            Console.WriteLine("Enter integer number");
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            bool odd = false;
            do
            {
                int digit = number % 10;
                if (digit % 2 != 0)
                {
                    odd = true;
                }
                sum += digit;
                number /= 10;
            } while (number % 10 != 0);

            Console.WriteLine(odd ? "Entered number contain odd digit" : "Entered number don't contain odd digit");
            Console.WriteLine($"Sum = {sum}");


            Console.ReadKey();

        }
    }
}
