using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5_part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<uint, string> customers = new Dictionary<uint, string>();
            uint id;
            string name;
            for (int i = 0; i < 7; i++)
            {
                Console.Write($"Enter customer #{i + 1} ID: ");
                id = Convert.ToUInt16(Console.ReadLine());
                Console.Write($"Enter customer #{i + 1} name: ");
                name = Console.ReadLine();
                customers.Add(id, name);
            }
            do
            {
                Console.WriteLine("\nEnter customer ID to search his name: ");
                id = Convert.ToUInt16(Console.ReadLine());
                if (customers.TryGetValue(id, out name))
                {
                    Console.WriteLine($"For ID: {id} found customer name: {name}");
                    break;
                }
                else
                {
                    string answer;
                    Console.WriteLine("ID not found! Do you want repeat search? (y/n):");
                    answer = Console.ReadLine().ToLower();
                    if (answer != "y") break;
                }
            } while (true);
        }
    }
}
