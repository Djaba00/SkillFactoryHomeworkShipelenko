using System;
using static System.Net.Mime.MediaTypeNames;

namespace HWModule4
{
    public class Chapter2
    {
        public static void Chapter2Run()
        {
            Task1();
            Task2();
            Task3();
            Task4();
            Task5();
        }

        public static void Task1()
        {
            ConsoleColor currentB = Console.BackgroundColor;
            ConsoleColor currentF = Console.ForegroundColor;

            Console.WriteLine("\t\t Задание 4.2.6\n\t\t цикл for\n");
            Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");

            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine($"Iteration {i}");
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

            Console.ReadKey();
        }

        public static void Task2()
        {
            int k = 0;
            ConsoleColor currentB = Console.BackgroundColor;
            ConsoleColor currentF = Console.ForegroundColor;

            Console.WriteLine("\t\t Задание 4.2.10\n\t\t цикл while\n");
            Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");

            while (k < 3)
            {
                Console.WriteLine(k);

                Console.WriteLine($"Iteration {k}");

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

                k++;
            }
            Console.BackgroundColor = currentB;
            Console.ForegroundColor = currentF;

            Console.ReadKey();
        }

        public static void Task3()
        {
            int k = 0;
            ConsoleColor currentB = Console.BackgroundColor;
            ConsoleColor currentF = Console.ForegroundColor;

            Console.WriteLine("\t\t Задание 4.2.11\n\t\t цикл do...while\n");
            Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");

            do
            {
                Console.WriteLine(k);

                Console.WriteLine($"Iteration {k}");

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

                k++;
            }
            while (k < 3);
            
            Console.BackgroundColor = currentB;
            Console.ForegroundColor = currentF;

            Console.ReadKey();
        }

        public static void Task4()
        {
            Console.WriteLine("\t\t Задание 4.2.12\n\t\t отличие while от do...while\n");

            ConsoleColor currentB = Console.BackgroundColor;
            ConsoleColor currentF = Console.ForegroundColor;

            Console.WriteLine("Цикл while (k < 0)");
            int k = 0;

            while (k < 0)
            {
                Console.WriteLine(k);

                Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");

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

                k++;
            }

            Console.WriteLine("Цикл do (t < 0)");
            int t = 0;

            do
            {
                Console.WriteLine(t);

                Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");

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

                t++;
            } while (t < 0);

            Console.BackgroundColor = currentB;
            Console.ForegroundColor = currentF;

            Console.ReadKey();
        }

        public static void Task5()
        {
            Console.WriteLine("\t\t Задание 4.2.14\n\t\t infinity while\n");

            ConsoleColor currentB = Console.BackgroundColor;
            ConsoleColor currentF = Console.ForegroundColor;

            int k = 0;

            while (true)
            {
                Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
                Console.WriteLine(k);

                var text = Console.ReadLine();

                switch (text)
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

                if (text == "stop")
                {
                    Console.WriteLine("Цикл остановлен!");
                    break;
                }

                k++;
            }
            Console.BackgroundColor = currentB;
            Console.ForegroundColor = currentF;

            Console.ReadKey();
        }
    }
}