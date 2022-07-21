using System;

namespace HW6
{
    class Program
    {
        static void Main(string[] args)
        {
        a1:
            try
            {
                Console.WriteLine("Write first number");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Write second number");
                int b = Convert.ToInt32(Console.ReadLine());
                if (a < b)
                {
                    throw new ApplicationException("first number must be > second number");
                }
                Console.WriteLine("Dividing " + Div(a, b));
                Console.Write("Write first number c: ");
                double c = Convert.ToDouble(Console.ReadLine());
                Console.Write("Write second number d: ");
                double d = Convert.ToDouble(Console.ReadLine());
                if (d == 0)
                {
                    throw new DivideByZeroException();
                }
                Console.WriteLine("Dividing (double): {0}", Div(c, d));
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                goto a1;
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                goto a1;
            }
            catch (ApplicationException ex)
            {
                Console.WriteLine(ex.Message);
                goto a1;
            }
            finally
            {
                Console.WriteLine(new string('-', 30));
            }
            Console.WriteLine("Write start numbers");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write end numbers");
            int end = Convert.ToInt32(Console.ReadLine());
            ReadNumber(start, end);
        }

        static int Div(int a, int b)
        {
            return a / b;
        }
        static double Div(double c, double d)
        {
            return c / d;
        }
        static void ReadNumber(int start, int end)
        {
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
            b1:
                try
                {
                    if (start >= end)
                    {
                        throw new Exception("End number must be > start number");
                    }

                    arr[i] = Convert.ToInt32(Console.ReadLine());

                    if (arr[i] <= start)
                    {
                        throw new ArgumentOutOfRangeException("num must be the greater than previous num or start num");
                    }
                    else if (arr[i] >= end)
                    {
                        throw new ArgumentOutOfRangeException("num must be < end num");
                    }

                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                    goto b1;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                    goto b1;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Write new end num");
                    end = Convert.ToInt32(Console.ReadLine());
                    goto b1;
                }
                start = arr[i];
            }
            Console.WriteLine("Numbers");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
