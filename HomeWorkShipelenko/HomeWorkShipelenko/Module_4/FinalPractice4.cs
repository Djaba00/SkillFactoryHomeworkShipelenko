using System;

namespace HWModule4
{
	public class FinalPractice4
	{
		public static void FinalPractice4Run()
		{
            Registration();
        }

		public static void Registration()
		{
            Console.Write("Сколько новых пользователей вы хотите добавить?\n Количество нвых пользователей: ");

            int newUsers = int.Parse(Console.ReadLine());
            int countUsers = newUsers;
            var UserID = new (string Name, string Surname, string Login, int Logincount, bool HasPet, int Age, string[] FavColors)[countUsers];

            for (int x = 0; x < newUsers; x++)
            {
                Console.WriteLine("\t\t Новый пользватель #{0}", x+1);

                (string Name, string Surname, string Login, int Logincount, bool HasPet, int Age, string[] FavColors) User;

                Console.Write("Введите имя: ");
                User.Name = Console.ReadLine();

                Console.Write("Введите фамилмию: ");
                User.Surname = Console.ReadLine();

                Console.Write("Введите логин: ");
                User.Login = Console.ReadLine();
                User.Logincount = User.Login.Length;

                Console.Write("Есть ли у вас питомец?(да/нет): ");
                if (Console.ReadLine() == "да")
                    User.HasPet = true;
                else User.HasPet = false;

                Console.Write("Ваш возраст: ");
                User.Age = int.Parse(Console.ReadLine());

                User.FavColors = new string[3];

                Console.WriteLine("Введите три любимых цвета:");

                for (int i = 0; i < User.FavColors.Length; i++)
                {
                    User.FavColors[i] = Console.ReadLine();
                }

                UserID[x] = User;
            }

            Console.WriteLine("Региcтрация {0} пользователй выполнена успешно!", newUsers);

            Console.Write("Показать данные зарегистрированный пользователей? (да/нет) ");
            if (Console.ReadLine() == "да")
                ShowDataNewUsers();


            else
            {
                Console.WriteLine("\n Модуль 4 завершен! Спасибо за внимание:) \nPress any key to continue...");
                Console.ReadKey();
            }
                
            void ShowDataNewUsers()
            {
                for (int i = 0; i < newUsers; i++)
                {
                    Console.WriteLine("\tПользователь #{0}\n", i + 1);

                    Console.WriteLine("Имя: {0}", UserID[i].Name);
                    Console.WriteLine("Фамилия: {0}", UserID[i].Surname);
                    Console.WriteLine("Возраст: {0}", UserID[i].Age);

                    Console.WriteLine("Логин: {0}", UserID[i].Login);
                    Console.WriteLine("Длина логина: {0}", UserID[i].Logincount);

                    Console.WriteLine("Питомец?: {0}", UserID[i].HasPet);

                    foreach(var color in UserID[i].FavColors)
                    {
                        Console.Write("{0} ", color);
                    }
                    Console.WriteLine();

                    if (i == newUsers - 1)
                    {
                        Console.WriteLine("\n Модуль 4 завершен! Спасибо за внимание:) \nPress any key to continue...");
                        Console.ReadKey();
                    }
                    else continue;
                }
            }  
        }        
	}
}
