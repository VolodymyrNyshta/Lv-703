using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1 -----------------
        start:
            try
            {
                Console.WriteLine("Enter value a:");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter value b:");
                int b = Convert.ToInt32(Console.ReadLine());
                if ((a < 0) || (b < 0)) { throw new ApplicationException("a or b must be positive or 0"); }
                Console.WriteLine("{0} / {1} = {2}", a, b, Div(a, b));
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"\nError: {ex.Message}");
                goto start;
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"\nError: {ex.Message}");
                goto start;
            }
            catch (ApplicationException ex) 
            {
                Console.WriteLine($"\nError: {ex.Message}");
                goto start;
            }
            finally
            {
                Console.WriteLine("\nNice try!\n");
            }
            //Task 2 -----------------
        start2:
            try
            {
                Console.WriteLine("Enter double type value a:");
                double a1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter double type value b:");
                double b1 = Convert.ToDouble(Console.ReadLine());
                if (b1 == 0) { throw new DivideByZeroException("value b must be non zero"); }
                Console.WriteLine("{0} / {1} = {2}", a1, b1, a1 / b1);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"\nError: {ex.Message}");
                goto start2;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nOther errors: {ex.Message}");
                goto start2;
            }
            //Task 3 -----------------
            Console.WriteLine("\nEnter 10 values:");
            int newStart = 1;
            int i = 0;
            do
            {
                newStart = ReadNumber(newStart, 100);
                Console.WriteLine("Ok!");
                i++;
            }
            while (i < 10);
            Console.WriteLine("Thank you!");
            Console.ReadKey();
        }
        public static int Div(int a, int b)
            { return a / b; }
        public static int ReadNumber(int a, int b)
        {
        start3:
            try
            {
                int newValue = Convert.ToInt32(Console.ReadLine());
                if ((a < newValue) & (newValue < b))
                    return newValue;
                else throw new ApplicationException($"Value must be in range {a} < value < {b}");
            }
            catch (FormatException ex)
            {
                Console.Write($"Error: {ex.Message}\nEnter correct value: ");
                goto start3;
            }
            catch (ApplicationException ex)
            {
                Console.Write($"Error: {ex.Message}\nEnter correct value: ");
                goto start3;
            }
        }
    }
}
