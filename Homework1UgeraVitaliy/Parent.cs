using System;

namespace Homework11
{
    public class Parent
    {
        public void OnMarkChange(int estimate)
        {
            Console.WriteLine("Your child, {0}, got a new mark: {1}",Student.mainName, estimate);
        }
    }
}
