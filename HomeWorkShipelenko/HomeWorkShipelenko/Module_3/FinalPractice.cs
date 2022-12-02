using System;
namespace Module3_Shipelenko
{
	public class FinalPractice
    {
        public static void FinalPracticeRun()
        {
            Console.WriteLine("\n\t\t «Анкетируем пользователей» ");

            Console.Write("Привет уважамаемый проверяющий, как ваше имя? ");
            var chName = Console.ReadLine();

            Console.Write("Сколько вам лет?:) ");
            var chAge = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ваша дата рождения? ");
            var chBirthDate = Console.ReadLine();

            Console.WriteLine("\nДанные о проверяющем: \n\nИмя:{0} \nВозраст: {1} \nДата Рождения {2}", chName, chAge, chBirthDate);

            Console.WriteLine("\n Спасибо за внимание, для завершения нажмите на любую клавишу:)");

            Console.ReadKey();
        }
    }
}

