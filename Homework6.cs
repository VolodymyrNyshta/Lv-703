using System;
using System.Collections.Generic;
namespace Homework6
{
    internal class Homework6
    {
        // Task 1
        public static int Div(int a, int b)
        {
            return a / b;
        }
        // Task 2 
        public static double Div(double a, double b)
        {
            return (double)a / b;
        }
        // Task 3
        public static List<int> ReadNumber(int start, int end)
        {
            List<int> numbers = new List<int>();
            const int LENGHT = 10;
            while (true)
            {
                try
                {
                    // Adding the first integer to the list if it is in our range.
                    Console.Write("Enter number [1]: ");
                    int num = Convert.ToInt32(Console.ReadLine());
                    if(num >= end || num <= start)
                    {
                        throw new ApplicationException($"The number must be in range of ({start};{end}).");
                    }
                    numbers.Add(num);
                    break;
                }
                catch(ApplicationException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
            for (int i = 1; i < LENGHT; i++)
            {
                while (true)
                {
                    try
                    {
                        // Adding other elements to the list if they're in our range and the current integer is bigger than the previous one.
                        Console.Write($"Enter number [{i+1}]: ");
                        int num = Convert.ToInt32(Console.ReadLine());
                        if (num >= end || num <= start)
                        {
                            throw new ApplicationException($"The number must be in range of ({start};{end}).");
                        }
                        if (numbers[i - 1] >= num)
                        {
                            throw new ApplicationException($"The number must be > than the previous one.");
                        }
                        numbers.Add(num);

                        break;
                    }
                    catch (ApplicationException ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                }
            }
            return numbers;
            
        }
        static void Main(string[] args)
        {
            // Task 1
            while (true)
            {
                try
                {
                    Console.Write("Enter the first integer value: ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter the second integer value: ");
                    int b = Convert.ToInt32(Console.ReadLine());
                    if (a < b)
                    {
                        throw new ApplicationException("The first value must be >= than the second value");
                    }
                    Console.WriteLine($"The result of division first and second integer is {Div(a, b)}");
                    
                    break;
                }
                catch(ApplicationException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                catch(DivideByZeroException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                catch(FormatException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                finally
                {
                    Console.WriteLine("Success!");
                }
            }

            // Task 2
            while (true)
            {
                try
                {
                    Console.Write("Enter the first double value: ");
                    double a = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter the second double value: ");
                    double b = Convert.ToDouble(Console.ReadLine());
                    if (b == 0)
                    {
                        throw new DivideByZeroException("The second double can't equal 0");
                    }
                    Console.WriteLine($"The result of division the first and the second double is {Div(a, b)}");
                    break;
                }
                catch (ApplicationException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                finally
                {
                    Console.WriteLine("Success!");
                }
            }
            // Task 3
            while (true)
            {    
                try
                {
                    int start, end;
                    Console.Write("Enter the left limit of range: ");
                    start = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter the right limit of range: ");
                    end = Convert.ToInt32(Console.ReadLine());
                    if (start >= end)
                    {
                        throw new ApplicationException("The left limit can't be bigger than the right one!");
                    }
                    if (end - start <= 10)
                    {
                        throw new ApplicationException("The difference of end and start must be at least 10!");
                    }
                    List<int> numbers = new List<int>();
                    numbers = ReadNumber(start, end);
                    Console.Write("Result: ");
                    foreach (var number in numbers)
                    {
                        Console.Write($"{number} ");
                    }
                    break;
                }
                catch (ApplicationException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }

        }
    }
}
