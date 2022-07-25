using System;

namespace HW3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task1");
            string str = Console.ReadLine();
            char[] c = { 'a', 'o', 'i', 'e' };
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < c.Length; j++)
                {
                    if (str[i] == c[j])
                    {
                        count++;
                    }
                }

            }
            Console.WriteLine(count);

            Console.WriteLine("Task2");

            int[] months = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            int[] days = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            Console.WriteLine("Write month");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write year");
            int year = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < months.Length; i++)
            {
                if (months[i] == month)
                {
                    if (months[i] == 2 && (year % 4 == 0 && year % 100 == 0 && year != 400))
                    {
                        Console.WriteLine("Month have: " + days[i] + 1);
                    }
                    else
                        Console.WriteLine("Month have: " + days[i]);
                }
            }

            Console.WriteLine("Task3");

            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            int k = 0;
            while (k < arr.Length / 2)
            {
                if (arr[k] > 0)
                {
                    sum += arr[k];
                    k++;
                }
                else
                {
                    sum = 0;
                    for (int i = arr.Length / 2; i < arr.Length; i++)
                    {
                        sum += arr[i];
                    }
                    break;
                }
            }
            Console.WriteLine("Sum: {0}", sum);

        }
    }
}