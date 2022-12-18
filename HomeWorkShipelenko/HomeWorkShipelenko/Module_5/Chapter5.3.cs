using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HWModule5
{
	public class Chapter53
	{
		public static void Chapter53Run()
		{
            Task1();
            ShowArays();
		}

		// Задание 5.3.8
		static void Task1()
		{
            Console.WriteLine("\t\t Задание 5.3.8\n");

            int num = 3;
            int[] array = new int[num];

            Console.WriteLine("Начальная длина массива: {0}", array.Length);

            GetArrayfromConsole(ref num);

            array = new int[num];

            Console.WriteLine("Длина массива после изменения: {0}", array.Length);

            Console.WriteLine("\nPress Enter to check next task...");
            Console.ReadKey();
        }

		static int[] GetArrayfromConsole(ref int num)
		{
            num = 6;
            var result = new int[num];
            return result;
		}

        // Задание 5.3.13

        static void ShowArays()
        {
            Console.WriteLine("\t\t Задание 5.3.8\n");

            int[] a;
            int[] b;
            int[] array = { 10, 100, 20, -30, 40, -20 };

            SortArray(array, out a, out b);

            Console.Write("Данный массив: ");
            foreach (int numb in array)
                Console.Write("{0} ", numb);
            Console.WriteLine();

            Console.ReadKey();

            Console.Write("Массив от меньшего к большему: ");
            foreach (int numb in a)
                Console.Write("{0} ", numb);
            Console.WriteLine();

            Console.ReadKey();

            Console.Write("Массив от большего к меньшему ");
            foreach (int numb in b)
                Console.Write("{0} ", numb);
            Console.WriteLine();

            Console.ReadKey();

            Console.WriteLine("\nPress Enter to check next chapter...");
            Console.ReadKey();
        }


        static void SortArray(in int[] arr, out int[] sortedAsc, out int[] sortedDesc)
        {
            sortedAsc = new int[arr.Length];
            sortedDesc = new int[arr.Length];

            Array.Copy(arr, sortedAsc , arr.Length);
            Array.Copy(arr, sortedDesc , arr.Length);

            sortedAsc = SortAsc(sortedAsc);
            sortedDesc = SortDesc(sortedDesc);

        }

        // Массив от меньшего к большему

        static int[] SortAsc(int[] arr)
        {

            int temp = 0;

            for (int i = 0; i < arr.Length; i++)
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
            return arr;
        }

        // Массив от большего к меньшему

        static int[] SortDesc(int[] arr)
        {

            int temp = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }

    }
}