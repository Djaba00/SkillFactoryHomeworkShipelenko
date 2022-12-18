using System;

namespace HWModule3
{
    class Module3
    {
        public static void Module3Run()
        {
            Console.WriteLine("\nВы находитесь в модуле 3 \nКакие заданая вы хотели бы посмотреть?\n");
            Console.Write("1 - финальное задание\n2 - все задания модуля \n3 - пропуск модуля \n\nВведите число: ");

            int taskCheck = int.Parse(Console.ReadLine());

            switch(taskCheck)
            {
                case (1):
                    Module3FinalPractice.Module3FinalPracticeRun();
                    break;

                case (2):
                    Module3FinalPractice.Module3FinalPracticeRun();
                    Chapter2.Task2Run();
                    Chapter3.Task3Run();
                    Chapter4.Task4Run();
                    Chapter6.Task6Run();
                    Chapter7.Task7Run();
                    break;

                default:
                    Console.WriteLine("Модуль 3 пропущен... \nНажмите любую клавишу для продолжения...");
                    Console.ReadKey();
                    break;

            }

        }
    }
}