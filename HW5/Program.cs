using System;
using System.Collections.Generic;

namespace Homework5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IDeveloper> myList = new List<IDeveloper>();
            myList.Add(new Programmer("C_sharp"));
            myList.Add(new Builder("Some_tool"));
            myList.Add(new Builder("Hammer"));
            myList.Add(new Programmer("Java"));
            myList.Add(new Programmer("C_sharp"));
            myList.Add(new Builder("Some_tool"));
            foreach (var item in myList)
            {
                item.Create();
                item.Destroy();
            }
            Console.WriteLine("======Sort======");
            SortClass.Sort(myList);

            foreach (var item in myList)
            {
                Console.WriteLine(item.Tool);
            }
            {

            }

           
            Console.WriteLine();

            
        }
    }
}
