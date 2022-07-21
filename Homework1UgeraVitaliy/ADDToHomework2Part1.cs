using System;

namespace AdditionToHomework2
{
    class Cat
    {
        public int SatietyLevel {get; set;}

        public void EatSomething(Food food)
        {
            SatietyLevel = SatietyLevel + (int)food;
        }

        public void FoodOutput()
        {
            Console.WriteLine("- fish\n- grass\n- mouse\n- rock\n");
        }

        public enum Food
        {
            fish = 4,
            grass = 1,
            mouse = 3,
            rock = -1
        }
    }

    struct Student
    {
        public string surname;
        public int group;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //ADDHomework2Part1
            Cat cat = new Cat();
            Console.WriteLine("If you want to feed your cat and see available food press 'ENTER'...");
            while (Console.ReadKey(true).Key != ConsoleKey.Enter)
            {

            }
            cat.FoodOutput();
            while (true)
            {
                Console.Write("Write cat food to eat : ");
                string food;
                while (true)
                {
                    food = Console.ReadLine();
                    if (food != "fish" && food != "grass" && food != "mouse" && food != "rock")
                    {
                        Console.WriteLine("Incorrect value, please, write it again...");
                    }
                    else
                    {
                        Console.WriteLine("");
                        break;
                    }
                }
                switch (food)
                {
                    case "fish":
                        cat.EatSomething(Cat.Food.fish);
                        break;
                    case "grass":
                        cat.EatSomething(Cat.Food.grass);
                        break;
                    case "mouse":
                        cat.EatSomething(Cat.Food.mouse);
                        break;
                    case "rock":
                        cat.EatSomething(Cat.Food.rock);
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Satiety level is currently on : {0}", cat.SatietyLevel);
                Console.WriteLine("If you want to end the program, then press 'Esc'...\n");
                if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                {
                    break;
                }
            }
        }
    }
}
