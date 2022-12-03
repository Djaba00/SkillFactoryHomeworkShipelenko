using System;
namespace HWModule3
{
	public class Chapter7
	{
        enum DaysOfWeek //либо можно использовать системный список DayOfWeek, в котором Sunday = 0 
        {
            Monday = 1,
            Tuseday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday,
        }

        public static void Task7Run()
        {
            Console.WriteLine("\n\t\t Задание 3.7");

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");



            byte age = (byte)int.Parse(Console.ReadLine());
            Console.WriteLine("Your name is {0} and age is {1} ", name, age);

            Console.WriteLine("What's your favorite day of week?");
            DaysOfWeek day = (DaysOfWeek)int.Parse(Console.ReadLine());
            Console.WriteLine("Your favorite day is {0}", day);

            Console.WriteLine("\nPress Enter to check final practice...");

            Console.ReadKey();
        }
    }
}

