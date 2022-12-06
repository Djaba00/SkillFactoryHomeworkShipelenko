using System;

namespace ShipelenkoHW
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Выберите номер модуля \nДоступные модули: #3 #4");

            switch (Console.ReadLine())
            {
                case ("3"):
                    HWModule3.Module3.Module3Run();
                    break;
                case ("4"):
                    HWModule4.Module4.Module4Run();

                    break;
                default:
                    HWModule3.Module3.Module3Run();
                    HWModule4.Module4.Module4Run();

                    break;
            }
        }
    }
}