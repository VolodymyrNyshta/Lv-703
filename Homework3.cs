using System;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1
            Console.WriteLine("Enter your string");
            string str = Console.ReadLine();
            string searchLetter = "aoie";
            int myCount = 0;
            foreach (char el in searchLetter)
            {
                foreach (char myelement in str)
                {
                    if (myelement == el)
                    {
                        myCount++;
                    }
                }
            }
            Console.WriteLine($"Count of characters ‘a’, ’o’, ’i’, ’e’ is : {myCount}");
            Console.WriteLine(new string('*', 15));

            //Task2
            Console.WriteLine("Enter month number: ");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine($"Your month has {DateTime.DaysInMonth(2022, month)} days");
            Console.WriteLine(new string('*', 15));

            //Task3
            Console.WriteLine("Enter 10 numbers: ");
            int sum = 0;
            int sum2 = 0;
            bool isnegativ = false;
            for (int i = 0; i < 10; i++)
            {
                int digit = int.Parse(Console.ReadLine());

                if (i < 5)
                {
                    if (digit > 0)
                    {
                        sum += digit;
                        continue;
                    }
                    else
                        isnegativ = true;

                }
                else if (isnegativ)
                {
                    sum2 += digit;
                }

            }
            Console.Write("Sum = ");
            Console.WriteLine(isnegativ ? sum2 : sum);
            Console.WriteLine(new string('*', 15));
            Console.ReadKey();
        }
    }
}
