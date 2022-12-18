using System;
using HWModule4;

namespace HWModule5
{
	public class Module5
	{
		public static void Module5Run()
		{
            Console.WriteLine("\nВы находитесь в модуле 5 \nКакие заданая вы хотели бы посмотреть?\n");
            Console.Write("1 - финальное задание\n2 - все задания модуля \n3 - пропуск модуля \n\nВведите число: ");

            int taskCheck = int.Parse(Console.ReadLine());

            switch (taskCheck)
            {
                case (1):
                    FinalPractice5.FinalPractice5Run();
                    break;

                case (2):
                    Chapter51.Chapter51Run();
                    Chapter52.Chapter52Run();
                    Chapter53.Chapter53Run();
                    Chapter55.Chapter55Run();
                    FinalPractice5.FinalPractice5Run();
                    break;

                default:
                    Console.WriteLine("Модуль 5 пропущен... \nНажмите любую клавишу для продолжения...");
                    Console.ReadKey();
                    break;

            }
        }
	}
}

