using System;
namespace HWModule3
{
	public class Chapter4
	{
        enum Semaphore
        {
            Red = 100,
            Yellow = 200,
            Green = 300,
        }
        public static void Task4Run()
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

