using System;

namespace HWModule4
{
    public class Chapter3
    {
        public static void Chapter3Run()
        {
            Task1();
            Task2();
            Task3();
            Task4();
            Task5();
            Task6();
            Task7();
            Task8();
            Task9();
            Task10();

        }

        public static void Task1()
        {
            ConsoleColor currentB = Console.BackgroundColor;
            ConsoleColor currentF = Console.ForegroundColor;

            Console.WriteLine("\t\t Задание 4.3.1\n\t\t массивы\n");

            string[] favcolors = new string[3];

            for (int i = 0; i < favcolors.Length; i++)
            {
                Console.WriteLine("Введите цвет номер {0}", i + 1);
                favcolors[i] = Console.ReadLine();
            }

            foreach (var color in favcolors)
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
            Console.WriteLine("\t\t Задание 4.3.5\n\t\t массивы\n");

            Console.Write("Напишите ваше имя: ");
            string name = Console.ReadLine();

            foreach(var letter in name)
            {
                Console.Write("{0} ", letter);
            }

            Console.Write("Последняя буква имени: {0} \n", name[name.Length - 1]);

            Console.WriteLine("Имя наоборот");

            for(int i = 0; i < name.Length; i++)
            {

                Console.Write(name[name.Length - 1 - i] + " ");
            }

            Console.WriteLine();

            Console.ReadKey();
        }

        public static void Task3()
        {
            int[,] array = { { 1,2,3 }, { 5,6,7 }};

            foreach(var numb in array)
            {
                Console.Write(numb + " ");
            }
            Console.WriteLine();

            Console.ReadKey();
        }

        public static void Task4()
        {
            Console.WriteLine("\t\t Задание 4.3.11\n");
            int[,] array = { { 1, 2, 3 }, { 5, 6, 7 }, { 8, 9, 10 }, { 11, 12, 13 } };

            for ( int i = 0; i < array.GetUpperBound(1) + 1; i++ )
            {
                for ( int k = 0; k < array.GetUpperBound(0) + 1; k++ )
                    Console.Write(array[k, i] + " ");

                Console.WriteLine();
            }

            Console.ReadKey();
        }

        public static void Task5()
        {
            Console.WriteLine("\t\t Задание 4.3.12\n");

            var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };

            int temp;

            for ( int i = 0; i < arr.Length; i++ )
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            foreach( var numb in arr)
            {
                Console.Write(numb + " ");
            }
            Console.WriteLine();

            Console.ReadKey();
        }

        public static void Task6()
        {
            Console.WriteLine("\t\t Задание 4.3.13\n");

            var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };

            int sum = 0;

            foreach(var item in arr)
            {
                sum += item;
            }

            Console.WriteLine(sum);

            Console.ReadKey();
        }

        public static void Task7()
        {
            Console.WriteLine("\t\t Задание 4.3.14\n");

            int[][] array = new int[3][];
            array[0] = new int[2] { 1, 2 };
            array[1] = new int[3] { 1, 2, 3 };
            array[2] = new int[5] { 1, 2, 3, 4, 5 };

            foreach(var arr in array)
            {
                foreach(var item in arr)
                {
                    Console.Write(item + " ");
                }
            }
            Console.WriteLine();

            Console.ReadKey();
        }

        public static void Task8()
        {
            Console.WriteLine("\t\t Задание 4.3.15\n");

            int[] array = { -1, 2, 5, -5, 0, 7, 10, 9, 8, -7 };

            Console.Write("Положительные числа в массиве: ");

            foreach(var item in array)
            {
                if (item > 0)
                    Console.Write(item + " ");
            }
            Console.WriteLine();

            int positivenumbs = 0;

            for ( int i = 0; i < array.Length; i++ )
            {
                if (array[i] > 0 )
                {
                    positivenumbs++;
                }
            }
            Console.WriteLine("Колличество положительных чисел в массиве: {0}", positivenumbs);

            Console.ReadKey();
        }

        public static void Task9()
        {
            Console.WriteLine("\t\t Задание 4.3.16\n");

            int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };

            Console.Write("Положительные числа в массиве: ");

            foreach (var item in arr)
            {
                if (item > 0)
                    Console.Write(item + " ");
            }
            Console.WriteLine();

            int positivenumbs = 0;

            for (int i = 0; i < arr.GetUpperBound(0) + 1; i++)
            {
                for(int j = 0; j < arr.GetUpperBound(1) + 1; j++)
                {
                    if (arr[i, j] > 0)
                        positivenumbs++;
                }
            }
            Console.WriteLine("Колличество положительных чисел в массиве: {0}", positivenumbs);

            Console.ReadKey();
        }

        public static void Task10()
        {
            Console.WriteLine("\t\t Задание 4.3.16\n");

            int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };

            Console.WriteLine(arr.GetUpperBound(0));
            Console.WriteLine(arr.GetUpperBound(1));
            Console.WriteLine(arr.Length);

            for ( int i = 0; i < arr.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < arr.GetUpperBound(1) + 1; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }

            // Вариант с упорядоченными строками

            int temp;

            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= arr.GetUpperBound(1); j++)
                {
                    for (int x = j + 1; x <= arr.GetUpperBound(1); x++)
                    {
                        if (arr[i, j] > arr[i, x])
                        {
                            temp = arr[i, x];
                            arr[i, x] = arr[i, j];
                            arr[i, j] = temp;
                        } 
                    }
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}