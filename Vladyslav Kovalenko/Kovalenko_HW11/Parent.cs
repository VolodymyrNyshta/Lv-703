using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kovalenko_HW11
{
    internal class Parent : Student
    {
        public void OnMarkChange(int someMark)
        {
            Console.WriteLine($"{Name} new mark is " + someMark);
        }
    }
}
