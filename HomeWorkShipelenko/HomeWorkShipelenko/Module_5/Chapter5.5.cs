using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HWModule5
{
	public class Chapter55
	{
		public static void Chapter55Run()
		{
			Task1();
			Task2();
			Task3();
        }

		// Задание 5.5.3

		private static void Task1()
		{
            Console.WriteLine("\t\t Задание 5.5.3\n\t\t Эхо\n");

            ConsoleColor currentB = Console.BackgroundColor;

            Console.WriteLine("Напишите что-нибудь:");
			string saidWord = Console.ReadLine();

            Console.Write("Глубина эхо: ");
			int deep = int.Parse(Console.ReadLine());
			Console.WriteLine();

			Echo(saidWord, deep);

            Console.BackgroundColor = currentB;

            Console.WriteLine("\nPress Enter to check next task...");
            Console.ReadKey();
        }

		static void Echo(string saidWord, int deep)
		{
			var modif = saidWord;

			if (modif.Length > 2)
			{
				modif = modif.Remove(0, 2);
			}

			Console.BackgroundColor = (ConsoleColor)deep;
			Console.WriteLine("..." + modif);

			if (deep > 1)
			{
				Echo(modif, deep - 1);
			}
		}

		// Задание 5.5.5

		private static void Task2()
		{
            Console.WriteLine("\t\t Задание 5.5.5\n\t\t Факториал\n");

			Console.Write("Введите число: ");
			int number = int.Parse(Console.ReadLine());

			Console.WriteLine($"{number}! = {Factorial(number)}");

            Console.WriteLine("\nPress Enter to check next task...");
            Console.ReadKey();
        }

		private static decimal Factorial(int x)
		{
			if (x == 0)
			{
				return 1;
			}

			else
			{
				return x * Factorial(x - 1);
			}
		}

		//Задание 5.5.8

		private static void Task3()
		{
            Console.WriteLine("\t\t Задание 5.5.8\n\t\t Возведение в степень\n");

			Console.Write("Введите число x: ");
			int number = int.Parse(Console.ReadLine());

			Console.Write("Введите степень числа x: ");
			string pow = Console.ReadLine();
			byte bytePow;
			bool powCheck = Byte.TryParse(pow, out bytePow);

			if (powCheck == true)
			{
				Console.WriteLine($"Вычисление: {number} ^ {bytePow} = {PowerUp(number, bytePow)}");
			}
			else
			{
				Console.WriteLine("Cтепень должна быть не меньше 0 и не больше 255!\nпопробуй еще раз:)\n");
				Task3();
			}

            Console.WriteLine("\nPress Enter to check next task...");
            Console.ReadKey();
        }

		private static decimal PowerUp(int number, byte pow)
		{
			if (pow == 0)
			{
                return 1;
            }

			else
			{
				if (pow == 1)
					return number;
				else
				return number * PowerUp(number, --pow);
			}
		}
    }
}