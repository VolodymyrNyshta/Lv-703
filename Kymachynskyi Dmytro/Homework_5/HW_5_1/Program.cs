using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IDeveloper> devList = new List<IDeveloper>();
            devList.Add(new Builder("hammer"));
            devList.Add(new Builder("axe"));
            devList.Add(new Builder("screwdriver"));
            devList.Add(new Programmer("c#"));
            devList.Add(new Programmer("python"));
            devList.Add(new Programmer("java"));
            foreach (var dev in devList) dev.Create();
            Console.WriteLine();
            foreach (var dev in devList) dev.Destroy();
            devList.Sort();
            Console.WriteLine("\nSorting list...");
            foreach (var developer in devList) Console.WriteLine(developer.Tool);
            Console.ReadKey();
        }
    }
}
