using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Person> persons = new List<Person>();
                persons.Add(new Staff("John", "Smith", 239076, 2000));
                persons.Add(new Staff("Bob", "Williams", 241007, 1900));
                persons.Add(new Staff("Tom", "Peters", 235887, 2100));
                persons.Add(new Staff("Mary", "Davis", 255766, 2000));
                persons.Add(new Teacher("James", "Martin", 22890, 2300, "Python"));
                persons.Add(new Teacher("David", "Jackson", 24332, 2500, "Java"));
                persons.Add(new Teacher("Jennifer", "Grant", 25670, 2400, "C++"));
                persons.Add(new Developer("Richard", "Jordan", 24907, 3000, "Senior"));
                persons.Add(new Developer("Matthew", "Morgan", 25455, 2500, "Middle"));
                persons.Add(new Developer("Bob", "Jones", 24334, 1500, "Junior"));
                foreach (var person in persons)
                    person.Print();
                Console.WriteLine("\nEnter name to search info:");
                string name = Console.ReadLine();
                foreach (var person in persons)
                {
                    if (person.FirstName.ToLower() == name.ToLower())
                    {
                        person.Print();
                    }
                }
                Console.WriteLine("\nSorting list by firstname and output to file:\n");
                persons.Sort();
                string filePath = @"C:\SoftServe\Lesson_7\persons.txt";
                using (StreamWriter sw = new StreamWriter(filePath, false, System.Text.Encoding.Default))
                {
                    foreach (var person in persons)
                        sw.WriteLine(person.OutputToString());

                }
                using (StreamReader sr = new StreamReader(filePath, System.Text.Encoding.Default))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                        Console.WriteLine(line);
                }
                Console.WriteLine("\nCreate list Employees and sorting it by salary:\n");
                List<Staff> Employees = new List<Staff>();
                foreach (Staff person in persons)
                {
                    if ((person.GetType() == typeof(Developer)) || (person.GetType() == typeof(Teacher)))
                        Employees.Add(person);
                }
                Employees.Sort();
                foreach (var person in Employees)
                    person.Print();
                Console.ReadKey();
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
        }
    }
}
