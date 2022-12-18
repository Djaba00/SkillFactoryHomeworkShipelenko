using System;
namespace HWModule5
{
	public class Chapter51
	{
		public static void Chapter51Run()
		{
            Task1();
            GetArrayFromConsole();
        }

        static string ShowColor(string username, int userage)
		{
            ConsoleColor currentB = Console.BackgroundColor;
            ConsoleColor currentF = Console.ForegroundColor;

            Console.WriteLine("{0}, {1} \nНапишите свой любиый цвет", username, userage);

            string color = Console.ReadLine();
			switch(color)
			{
				case "red":
					Console.BackgroundColor = ConsoleColor.Red;
					Console.ForegroundColor = ConsoleColor.Black;

					Console.WriteLine("Your color is red!");
					break;
				case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is green!");
                    break;
				case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is cyan!");
                    break;
				default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is yellow!");
                    break;
            }
            
            Console.BackgroundColor = currentB;
            Console.ForegroundColor = currentF;

            return color;
        }

        //Задание 5.1.5
		static void Task1()
		{
            Console.WriteLine("\t\t Задание 5.1.5\n");

            (string name, int age) = ("Тимофей", 22);

            Console.WriteLine("Мое имя: {0}", name);
            Console.WriteLine("Мой возраст: {0}", age);

            Console.WriteLine("Введите имя: ");
            name = Console.ReadLine();
            Console.WriteLine("Введите возраст: ");
            age = int.Parse(Console.ReadLine());

            Console.WriteLine("Ваше имя: {0}", name);
            Console.WriteLine("Ваш возраст: {0}", age);
            
            string[] favColors = new string[3];

            for (int i = 0; i < favColors.Length; i++)
            {
                favColors[i] = ShowColor(name, age);
            }

            Console.WriteLine("\nСписок ваших любимых цеветов:");

            foreach (string color in favColors)
            {
                Console.WriteLine(color);
            }

            Console.WriteLine("\nPress Enter to check next task...");
            Console.ReadKey();
        }

        //Задание 5.1.6
        static int[] GetArrayFromConsole()
        {
            Console.WriteLine("\t\t Задание 5.1.6\n");

            var result = new int[5];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Напишите элемент массива под номером {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }

            int temp = 0;

            for (int i = 0; i < result.Length; i++)
            {
                for (int j = i + 1; j < result.Length; j++)
                {
                    if (result[i] > result[j])
                    {
                        temp = result[i];
                        result[i] = result[j];
                        result[j] = temp;
                    }
                }
            }

            Console.WriteLine("Упорядоченная последовательность чисел: ");
            foreach (int numb in result)
            {
                Console.WriteLine(numb);
            }

            return result;
        }
    }
}

