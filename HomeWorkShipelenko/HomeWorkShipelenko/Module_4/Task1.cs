using System;

namespace HWModule4
{
	public class Chapter1
	{
        public static void Task1Run()
		{
			Task11();
			Task12();
			Task13();
			Task14();
		}
		public static void Task11()
		{
			string a = "hi";
			string b = "hello";

			bool c = a != b;

			Console.WriteLine(c);
		}

		public static void Task12()
		{
			int a = 5;
			int b = 6;
			double x = 2.6;
			double y = 1.5;

			bool c = (a < b) || (x > y);

			Console.WriteLine(c);
		}

        public static void Task13()
		{
            ConsoleColor currentB = Console.BackgroundColor;
            ConsoleColor currentF = Console.ForegroundColor;

            Console.WriteLine("Напиши свой любимый цвет на английском с маленькой буквы");

            var color = Console.ReadLine();
			if (color == "red")
			{
				Console.BackgroundColor = ConsoleColor.Red;
				Console.ForegroundColor = ConsoleColor.Black;

				Console.WriteLine("Your color is red!");
			}
			else if (color == "green")
			{
				Console.BackgroundColor = ConsoleColor.Green;
				Console.ForegroundColor = ConsoleColor.Black;

				Console.WriteLine("Your color is green!");
			}
			else
			{
				Console.BackgroundColor = ConsoleColor.Cyan;
				Console.ForegroundColor = ConsoleColor.Black;

				Console.WriteLine("Your color is cyan!");
			}

            Console.BackgroundColor = currentB;
            Console.ForegroundColor = currentF;
        }

		public static void Task14()
		{
            ConsoleColor currentB = Console.BackgroundColor;
            ConsoleColor currentF = Console.ForegroundColor;

            Console.WriteLine("Напиши свой любимый цвет на английском с маленькой буквы");

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
        }
    }
}

