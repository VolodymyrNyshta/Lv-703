using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VitaliySmuk_HW_11
{
    internal class Parent : Student
    {
        public void OnMarkChange(int mark)
        {
            Console.WriteLine($"Your sons {Name} new mark is {mark}");
        }
    }
}
