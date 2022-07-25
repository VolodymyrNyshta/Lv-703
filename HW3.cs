using System;

namespace Homework3
{
    internal class Program
    {
        enum Month
        {
            January = 1,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }
        static void Main(string[] args)
        {
            // Task 1. Read some string str.
            // Calculate the counts of characters ‘a’, ’o’, ’i’, ’e’  in this text.
            Console.WriteLine("Enter the string to count characters: ");
            int a = 0;
            int o = 0;
            int i = 0;
            int e = 0;
            string str = Console.ReadLine();
            foreach (char letter in str)
            {
                if (letter == 'a') a++;
                if (letter == 'o') o++;
                if (letter == 'i') i++;
                if (letter == 'e') e++;
            }
            Console.WriteLine($"The count of 'a': {a} letters. \nThe count of 'o': {o} letters.\nThe count of 'i': {i} letters.\nThe count of 'e': {e} letters.");

            // Task 2. Ask user to enter the number of month.
            // Read value and output the count of days in this month.
            Console.Write("Enter the number of month: ");
            int month = Convert.ToInt32(Console.ReadLine());
            switch ((Month)month)
            {
                case Month.January:
                case Month.March:
                case Month.May:
                case Month.July:
                case Month.August:
                case Month.October:
                case Month.December:
                    Console.WriteLine("The number of days in {0} equals 31.", Enum.GetName(typeof(Month), month));
                    break;
                case Month.February:
                    Console.WriteLine("Enter the year:");
                    int year = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine((year % 4 == 0 && year % 100 == 0 && year % 400 != 0) ?
                        $"The number of days in {Enum.GetName(typeof(Month), month)} equals 29."
                        : $"The number of days in {Enum.GetName(typeof(Month), month)} equals 28.");
                    break;
                case Month.April:
                case Month.June:
                case Month.September:
                case Month.November:
                    Console.WriteLine("The number of days in {0} equals 30.", Enum.GetName(typeof(Month), month));
                    break;
                default:
                    Console.WriteLine("Enter correct number of month!");
                    break;
            }

            // Task 3. Enter 10 integer numbers.
            // Calculate the sum of first 5 elements if they are positive or product of last 5 element in  the other case.
            int[] array = new int[10];
            Console.WriteLine("Enter 10 integers:");
            int check = 0; // variable to check if the the first 5 integers are positive.
            for (int j = 0; j < array.Length; j++)
            {
                Console.Write($"Element {j + 1} = ");
                array[j] = Convert.ToInt32(Console.ReadLine());
                if (array[j] > 0 && j < 5)
                    check++;
            }
            if (check == 5)
            {
                int sum = 0;
                for (int j = 0; j < 5; j++)
                {
                    sum += array[j];
                }
                Console.WriteLine($"The sum of the first 5 integers: {sum}.");
            }
            else
            {
                int product = 1;
                for (int j = 5; j < 10; j++)
                {
                    product *= array[j];
                }
                Console.WriteLine($"The product of the last 5 integers: {product}.");
            }

        }
    }
}
