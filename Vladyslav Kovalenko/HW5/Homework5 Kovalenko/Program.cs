using System.Collections.Generic;
namespace Homework5_Kovalenko
{
    internal class Program
    {
        private const int PersonsCount = 7;

        static void Main(string[] args)
        {
            DoPart1();
            Console.WriteLine();

            Dictionary<int, string> personsIds = new Dictionary<int, string>();

            AddPersons(personsIds);

            string exitCondition = string.Empty;
            while (exitCondition?.ToLower() != "y")
            {
                int searchedId = GetSearchedId();
                FindAndPrintUserById(personsIds, searchedId);
                Console.WriteLine("Exit? If yes - press 'y', else type something");
                exitCondition = Console.ReadLine();
            }
        }

        private static void AddPersons(Dictionary<int, string> persons)
        {
            Console.WriteLine($"We are goind to add {PersonsCount} persons");
            for (int i = 0; i < PersonsCount; i++)
            {
                Console.WriteLine("Enter ID:");
                string idString = Console.ReadLine();

                if (!int.TryParse(idString, out int id))
                {
                    Console.WriteLine("Incorrect ID. Try again");
                    i--;
                    continue;
                }

                Console.WriteLine("Enter Name:");
                var name = Console.ReadLine();

                persons.Add(id, name);
                Console.WriteLine($"Person with ID {id} and name {name} successfully added");
            }
        }
        private static int GetSearchedId()
        {
            Console.WriteLine("Lets find person through ID");
            int seachedId;
            while (true)
            {
                Console.WriteLine("Enter person ID");
                bool canParse = int.TryParse(Console.ReadLine(), out seachedId);

                if (canParse)
                {
                    return seachedId;
                }
                else
                {
                    Console.WriteLine("Can'n parse ID. Try again");
                }
            }
        }
        private static void FindAndPrintUserById(Dictionary<int, string> sourceCollection, int seachedId)
        {
            var isExist = sourceCollection.TryGetValue(seachedId, out var userName);

            if (isExist)
            {
                Console.WriteLine($"The name of the person behind that id {userName}");
            }
            else
            {
                Console.WriteLine("There is no one on the list with this ID");
            }
        }

        private static void DoPart1()
        {
            List<IDeveloper> developers = new List<IDeveloper>();
            developers.Add(new Builder("tool1"));
            developers.Add(new Programmer("Java"));
            developers.Add(new Builder("tool2"));
            developers.Add(new Programmer("Python"));
            developers.Add(new Builder("tool3"));
            developers.Add(new Programmer("C#"));
            foreach (var developer in developers)
            {
                developer.Create();
                developer.Destroy();
            }
            developers.Sort();

            Console.WriteLine();

            foreach (var developer in developers)
            {
                Console.WriteLine(developer.Tool);
            }
        }

    }



}

