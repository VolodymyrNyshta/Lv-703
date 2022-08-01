namespace HW6Kovalenko
{
    internal class Program
    {
        public static void ReadNumber(int start, int end)
        {
        a1:
            try
            {

                Console.WriteLine("Enter 10 int number");
                Console.WriteLine("Enter num1");
                int num1 = Convert.ToInt32(Console.ReadLine());
                if (start > num1 || num1 > end || start > end || end - start < 10) { throw new ApplicationException("Error"); }
                Console.WriteLine("Enter num2");
                int num2 = Convert.ToInt32(Console.ReadLine());
                if (num1 > num2) { throw new ApplicationException("Error"); }
                Console.WriteLine("Enter num3");
                int num3 = Convert.ToInt32(Console.ReadLine());
                if (num3 < num2 || num3 > end) { throw new ApplicationException("Error"); }
                Console.WriteLine("Enter num4");
                int num4 = Convert.ToInt32(Console.ReadLine());
                if (num4 < num3 || num4 > end) { throw new ApplicationException("Error"); }
                Console.WriteLine("Enter num5");
                int num5 = Convert.ToInt32(Console.ReadLine());
                if (num5 < num4 || num5 > end) { throw new ApplicationException("Error"); }
                Console.WriteLine("Enter num6");
                int num6 = Convert.ToInt32(Console.ReadLine());
                if (num6 < num5 || num6 > end) { throw new ApplicationException("Error"); }
                Console.WriteLine("Enter num7");
                int num7 = Convert.ToInt32(Console.ReadLine());
                if (num7 < num6 || num7 > end) { throw new ApplicationException("Error"); }
                Console.WriteLine("Enter num8");
                int num8 = Convert.ToInt32(Console.ReadLine());
                if (num8 < num7 || num8 > end) { throw new ApplicationException("Error"); }
                Console.WriteLine("Enter num9");
                int num9 = Convert.ToInt32(Console.ReadLine());
                if (num9 < num8 || num9 > end) { throw new ApplicationException("Error"); }
                Console.WriteLine("Enter num10");
                int num10 = Convert.ToInt32(Console.ReadLine());
                if (num10 < num9 || num10 > end) { throw new ApplicationException("Error"); }


            }
            catch (ApplicationException exception)
            {
                Console.WriteLine(exception.Message);
                goto a1;
            }

        }
        public static int Div(int a, int b)
        {
            return a / b;
        }
        public static double Div2(double num1, double num2) { return num1 / num2; }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter b");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(Div(a, b));
            }
            catch (DivideByZeroException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (ArgumentNullException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (System.ArithmeticException exception)
            {
                Console.WriteLine(exception.Message);
            }
            finally
            {
                Console.WriteLine("Nice!!!");
            }
            try
            {
                Console.WriteLine("Enter 1 num double");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter 2 num double");
                double num2 = Convert.ToDouble(Console.ReadLine());
                if (num2 == 0) { throw new DivideByZeroException(); }
                Console.WriteLine("{0}/{1}={2}", num1, num2, Div2(num1, num2));
            }
            catch (DivideByZeroException exception)
            {
                Console.WriteLine(exception.Message);
            }
            //task3
            Console.WriteLine("Enter int start");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter int end");
            int end = Convert.ToInt32(Console.ReadLine());
            ReadNumber(start, end);
            Console.WriteLine();
        }

    }
}

