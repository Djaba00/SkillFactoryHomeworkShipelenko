using System;
using static System.Net.Mime.MediaTypeNames;

namespace HWModule4
{
    public class Chapter3
    {
        public static void Chapter3Run()
        {
            Task1();
        }

        public static void Task1()
        {
            ConsoleColor currentB = Console.BackgroundColor;
            ConsoleColor currentF = Console.ForegroundColor;

            Console.WriteLine("\t\t Задание 4.3.1\n\t\t массивы\n");

            string[] favcolors = new string[3];

            for (int i = 0; i < favcolors.Length; i++)
            {
                Console.WriteLine("Введите цвет новер {0}", 0 + i);
                favcolors[i] = Console.ReadLine();
            }

            foreach (var color in favcolors)
            {
                switch (Console.ReadLine())
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
                    case "cyanw":
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is yellow!");
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
        }
    }
}