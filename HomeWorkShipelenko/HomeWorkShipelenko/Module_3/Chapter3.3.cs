using System;
namespace HWModule3
{
	class Chapter3
	{
        public static void Task3Run()
        {
            string myName = "Timofey";
            byte age = 22;
            bool pet = true;
            double shoeSize = 44.5;

            Console.WriteLine("\n\t\t Задание 3.3");
            Console.WriteLine($"My name is {myName}\nMy age is {age}");
            Console.WriteLine($"Do I have pet? {pet}\nMy shoe size is {shoeSize}");

            Console.WriteLine("\nПроверка верхней и нижней границы типа данных int:");
            Console.WriteLine("IntMax: {0}", int.MaxValue);
            Console.WriteLine("IntMin: {0}", int.MinValue);

            Console.WriteLine("\nPress Enter to check next chapter...");

            Console.ReadKey();
        }
    }
}

