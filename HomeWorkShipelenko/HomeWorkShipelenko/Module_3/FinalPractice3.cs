using System;
namespace HWModule3
{
	public class Module3FinalPractice
    {
        public static void Module3FinalPracticeRun()
        {
            Console.WriteLine("\n\t\t «Анкетируем пользователей» ");

            Console.Write("Привет уважамаемый проверяющий, как ваше имя? ");
            var chName = Console.ReadLine();

            Console.Write("Сколько вам лет?:) ");
            var chAge = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ваша дата рождения? ");
            var chBirthDate = Console.ReadLine();

            Console.WriteLine("\nДанные о проверяющем: \n\nИмя:{0} \nВозраст: {1} \nДата Рождения {2}", chName, chAge, chBirthDate);

            Console.WriteLine("\n Модуль 3 завершен! Спасибо за внимание:) \nPress any key to continue...");

            Console.ReadKey();
        }
    }
}

