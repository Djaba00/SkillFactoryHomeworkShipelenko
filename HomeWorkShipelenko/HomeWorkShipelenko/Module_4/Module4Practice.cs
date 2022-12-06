using System;

namespace HWModule4
{
	public class Module4Practice
	{
		public static void Module4PracticeRun()
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

            Console.WriteLine("Регичтрация {0} пользователй выполнена успешно!", newUsers);

            Console.Write("Показать данные зарегистрированный пользователей? (да/нет) ");
            if (Console.ReadLine() == "да")
                ShowDataNewUsers();
            else
            {
                Console.WriteLine("Завершение программы...");
                Console.ReadKey();
            }
                
            void ShowDataNewUsers()
            {
                for (int i = 0; i < newUsers; i++)
                {
                    Console.WriteLine("\tПользователь #{0}\n", i + 1);

                    Console.WriteLine("Имя: {0}", UserID[i].Name);
                    Console.WriteLine("Фамилия: {0}", UserID[i].Name);
                    Console.WriteLine("Возраст: {0}", UserID[i].Name);

                    Console.WriteLine("Логин: {0}", UserID[i].Name);
                    Console.WriteLine("Длина логина: {0}", UserID[i].Name);

                    Console.WriteLine("Питомец?: {0}", UserID[i].Name);

                    foreach(var color in UserID[i].FavColors)
                    {
                        Console.Write("{0} ", color);
                    }
                    Console.WriteLine();

                    if (i == newUsers - 1)
                    {
                        Console.WriteLine("Завершение программы...");
                        Console.ReadKey();
                    }
                    else continue;
                }
            }  
        }        
	}
}
