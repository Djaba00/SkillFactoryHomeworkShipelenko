using System;
using System.Drawing;

namespace HWModule5
{
	public class Chapter52
	{
		public static void Chapter52Run()
		{
            var array = GetArrayFromConsole(3);
            var sortearray = SortArray(array);

            ShowArray(GetArrayFromConsole(10), true);
		}

		//Задание 5.2.8
		static int[] GetArrayFromConsole(int num = 5)
		{
            Console.WriteLine("\t\t Задание 5.2.8\n");
            int[] array = new int[num];
			for(int i = 0; i < array.Length; i++)
			{
                Console.WriteLine("Напишите элемент массива под номером {0}", i + 1);
                array[i] = int.Parse(Console.ReadLine());
			}
			return array;
		}

		static int[] SortArray(int[] array)
		{
            int temp = 0;
			for (int i = 0; i < array.Length; i++)
			{
				for (int j = i + 1; j < array.Length; j++)
				{
					if(array[i] > array[j])
					{
						temp = array[i];
						array[i] = array[j];
						array[j] = temp;
					}
				}
			}

			Console.WriteLine("Упорядоченная последовательность чисел: ");
            foreach (var numb in array)
            {
                Console.WriteLine(numb);
            }

            Console.WriteLine("\nPress Enter to check next task...");
            Console.ReadKey();
            return array;
		}

        //Задание 5.2.17
        static void ShowArray(int[] array, bool arrayCheck = false)
        {
            var temp = array;
            if(arrayCheck)
            {
                temp = SortArray(array);
            }

            Console.WriteLine("Упорядоченная последовательность чисел: ");
            foreach (int num in temp)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("\nPress Enter to check next task...");
            Console.ReadKey();
        }

        //Задача с параметрами ShowColor
        static void ShowColor(string username = "Тимофей", params string[] favColors)
        {
            ConsoleColor currentB = Console.BackgroundColor;
            ConsoleColor currentF = Console.ForegroundColor;

            Console.WriteLine("{0}, напишите свой любиый цвет", username);

            foreach (string color in favColors)
            {
                switch (color)
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
            }

            Console.BackgroundColor = currentB;
            Console.ForegroundColor = currentF;

            Console.WriteLine("\nPress Enter to check next chapter...");
            Console.ReadKey();
        }
    }
}

