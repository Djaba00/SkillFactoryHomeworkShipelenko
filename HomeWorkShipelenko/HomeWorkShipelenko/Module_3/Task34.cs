using System;
namespace Module3_Shipelenko
{
	public class Task34
	{
        enum Semaphore
        {
            Red = 100,
            Yellow = 200,
            Green = 300,
        }
        public static void Task34Run()
        {

            Console.WriteLine("\n\t\t Задание 3.4");

            Console.WriteLine(Semaphore.Red);
            Console.WriteLine(Semaphore.Yellow);
            Console.WriteLine(Semaphore.Green);

            Console.WriteLine("\nPress Enter to check next task...");

            Console.ReadKey();
        }
    }
}

