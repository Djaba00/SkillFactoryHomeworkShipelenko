using System;
using HWModule3;

namespace HWModule4
{
	public class Module4
	{
		public static void Module4Run()
		{
            Console.WriteLine("\nВы находитесь в модуле 4 \nКакие заданая вы хотели бы посмотреть?\n");
            Console.Write("1 - финальное задание\n2 - все задания модуля \n3 - пропуск модуля \n\nВведите число: ");

            int taskCheck = int.Parse(Console.ReadLine());

            switch (taskCheck)
            {
                case (1):
                    FinalPractice4.FinalPractice4Run();
                    break;

                case (2):
                    Chapter1.Chapter1Run();
                    Chapter2.Chapter2Run();
                    Chapter3.Chapter3Run();
                    Chapter4.Chapter4Run();
                    FinalPractice4.FinalPractice4Run();
                    break;

                default:
                    Console.WriteLine("Модуль 4 пропущен... \nНажмите любую клавишу для продолжения...");
                    Console.ReadKey();
                    break;

            }
		}
	}
}

