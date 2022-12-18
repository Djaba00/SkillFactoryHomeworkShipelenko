using System;

namespace ShipelenkoHW
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Выберите номер модуля \nДоступные модули: #3 #4 #5");

            Console.Write("Введите номер модуля: ");
            switch (Console.ReadLine())
            {
                case ("3"):
                    HWModule3.Module3.Module3Run();

                    break;
                case ("4"):
                    HWModule4.Module4.Module4Run();

                    break;
                case ("5"):
                    HWModule5.Module5.Module5Run();

                    break;
                default:
                    HWModule3.Module3.Module3Run();
                    HWModule4.Module4.Module4Run();
                    HWModule5.Module5.Module5Run();

                    break;
            }
        }
    }
}