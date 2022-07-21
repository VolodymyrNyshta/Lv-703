using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task_1
            Console.WriteLine("Enter 1st float type number: ");
            float num1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter 2nd float type number: ");
            float num2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter 3rd float type number: ");
            float num3 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine((num1 >= -5 && num1 <= 5) && (num2 >= -5 && num2<= 5) && (num3 >= -5 && num3 <= 5) 
                ? "All numbers in range" : "Some numbers not in range");

            //Task_2
            Console.WriteLine("\nEnter 1st int type number: ");
            int num1T2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd int type number: ");
            int num2T2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 3rd int type number: ");
            int num3T2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num1T2 > num2T2 ? (num1T2 > num3T2 ? "1st is max" : "3rd is max") : (num2T2 > num3T2 ? "2nd is max" : "3rd is max"));
            Console.WriteLine(num1T2 < num2T2 ? (num1T2 < num3T2 ? "1st is min" : "3rd is min") : (num2T2 < num3T2 ? "2nd is min" : "3rd is min"));

            //Task_3
            Console.WriteLine("\nEnter HTTP Error code: ");
            int httpErrCode = Convert.ToInt32(Console.ReadLine());
            PrintHTTPErrorName(httpErrCode);
            void PrintHTTPErrorName(int codeNumber)
            {
                if (Enum.IsDefined(typeof(HTTPError), codeNumber))
                {
                    HTTPError codeName = (HTTPError)codeNumber;
                    string cleanCodeName = Convert.ToString(codeName);
                    cleanCodeName = cleanCodeName.Replace("_"," ");
                    Console.WriteLine("Name for {0} HTTP Error code is {1}", codeNumber, cleanCodeName);
                }
                else Console.WriteLine("{0} HTTP Error code is not exist!", codeNumber);
            }

            //Task_4
            Dog myDog;
            Console.Write("\nEnter dog name: ");
            myDog.name = Convert.ToString(Console.ReadLine());
            Console.Write("Enter dog mark: ");
            myDog.mark = Convert.ToString(Console.ReadLine());
            Console.Write("Enter dog age: ");
            myDog.age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(myDog);

            Console.ReadKey();


        }
        public struct Dog
        {
            public string name;
            public string mark;
            public int age;
            public override string ToString()
            {
                return string.Format("\nDog name: {0}, mark: {1}, age: {2} years", name, mark, age);
            }
        }
        
        enum HTTPError
        {
            Bad_Request = 400,
            Unauthorized,
            Payment_Required,
            Forbidden,
            Not_Found,
            Method_Not_Allowed,
            Not_Acceptable,
            Proxy_Authentication_Required,
            Request_Timeout,
            Conflict,
            Gone,
            Length_Required,
            Precondition_Failed,
            Payload_Too_Large,
            URI_Too_Long,
            Unsupported_Media_Type,
            Range_Not_Satisfiable,
            Expectation_Failed,
            Im_a_teapot,
            Authentication_Timeout,
            Misdirected_Request = 421,
            Unprocessable_Entity,
            Locked,
            Failed_Dependency,
            Too_Early,
            Upgrade_Required,
            Precondition_Required = 428,
            Too_Many_Requests,
            Request_Header_Fields_Too_Large = 431,
            Retry_With = 449,
            Unavailable_For_Legal_Reasons = 451,
            Client_Closed_Request = 499
        }
    }
}
