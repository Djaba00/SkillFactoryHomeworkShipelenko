using System;

namespace HWModule4
{
	public class Chapter4
	{
		public static void Chapter4Run()
		{
            Task1();
            Task2();
            Task3();
        }

		public static void Task1()
		{

            Console.WriteLine("\t\t Задание 4.4.2\n");

            (string name, int age) anketa;

            Console.Write("Напишите ваше имя: ");
            anketa.name = Console.ReadLine();
            Console.Write("Напишите ваш возраст: ");

            anketa.age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ваше имя: {0}", anketa.name);
            Console.WriteLine("Ваш возраст: {0}", anketa.age);

            Console.WriteLine("\nPress Enter to check next task...");
            Console.ReadKey();
        }

        public static void Task2()
        {
            Console.WriteLine("\t\t Задание 4.4.3\n");

            var (name, age) = ("Тимофей", 22);

            Console.WriteLine("Ваше имя: {0}", name);
            Console.WriteLine("Ваш возраст: {0}", age);

            Console.Write("Напишите ваше имя: ");
            name = Console.ReadLine();
            Console.Write("Напишите ваш возраст: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ваше имя: {0}", name);
            Console.WriteLine("Ваш возраст: {0}", age);

            Console.WriteLine("\nPress Enter to check next task...");
            Console.ReadKey();
        }

        public static void Task3()
        {
            Console.WriteLine("\t\t Задание 4.4.5\n");

            (string Name, string Type, double Age, int NameCount) pet;

            Console.Write("Напишите имя питомца: ");
            pet.Name = Console.ReadLine();
            pet.NameCount = pet.Name.Length;

            Console.Write("Тип вашего питомца: ");
            pet.Type = Console.ReadLine();

            Console.Write("Возраст вашего питомца: ");
            pet.Age = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\t\tИнформация о питомце\nИмя: {0}\nТип: {1}\nВозраст: {2}\nДлина имени: {3}", pet.Name, pet.Type, pet.Age, pet.NameCount);

            Console.WriteLine("\nPress Enter to check next chapter...");
            Console.ReadKey();
        }
    }
}

