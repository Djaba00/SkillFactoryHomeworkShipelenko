using System;
using System.Xml.Linq;

namespace HWModule5
{
    public class FinalPractice5
    {
        public static void FinalPractice5Run()
        {
            ShowUserData(PersonData());
            Console.WriteLine("\nМодуль 5 завершен. Для продолжения нажмите люблю клавишу...");
            Console.ReadKey();
        }


        static void ShowUserData((string Name, string Surname, int Age, bool HasPet, string[] PetName, string[] FavColors) Person)
        {
            Console.WriteLine("\n\t\t Данные о пользователе\n");
            Console.WriteLine($"Имя: {Person.Name} \nФамилия: {Person.Surname} \nВозраст: {Person.Age}");

            Console.Write("Питомцы: ");
            for(int i = 0; i < Person.PetName.Length; i++)
            {
                if (i == Person.PetName.Length - 1)
                {
                    Console.Write($"{Person.PetName[i]}.");
                }
                else
                {
                    Console.Write($"{Person.PetName[i]}, ");
                }
            }
            Console.WriteLine();

            Console.Write("Любимые цвета: ");
            for (int i = 0; i < Person.FavColors.Length; i++)
            {
                if (i == Person.FavColors.Length - 1)
                {
                    Console.Write($"{Person.FavColors[i]}.");
                }
                else
                {
                    Console.Write($"{Person.FavColors[i]}, ");
                }
            }
            Console.WriteLine();
        }

        // Регистрация пользователя

        static (string Name, string Surname, int Age, bool HasPet, string[] PetName, string[] FavColors) PersonData()
        {
            Console.WriteLine("Добро пожаловать! Мне поручено собрать некоторые данные о вас.\n");

            (string Name, string Surname, int Age, bool HasPet, string[] PetName, string[] FavColors) Person;


            // Имя
            Console.Write("Введите ваше имя: ");
            Person.Name = Console.ReadLine();
            string editedName;
            Editing("Имя", Person.Name, out editedName);

            // Фамилию
            Console.Write("Введите вашу фамилию: ");
            Person.Surname = Console.ReadLine();
            string editedSurname;
            Editing("Фамилия", Person.Surname, out editedSurname);

            // Возраст
            Console.Write("Введите ваш возраст: ");
            string Age = Console.ReadLine();
            string editingAge;
            Editing("Возраст", Age, out editingAge);
            Person.Age = Int32.Parse(editingAge);

            // Питомцы
            Console.Write("У вас есть домашние животные? ");
            if (Console.ReadLine() == "да" || Console.ReadLine() == "yes")
            {
                Person.HasPet = true;
                Console.Write("Сколько у вас питомцев? ");
                int petsCount = int.Parse(Console.ReadLine());
                Person.PetName = new string[petsCount];
                Console.WriteLine();
                Person.PetName = UserPets(petsCount);
                Console.WriteLine();
            }

            else
            {
                Person.PetName = new string[0];
                Person.HasPet = false;
            }

            // Любимые цвета

            Console.Write("Сколько у вас любимых цветов? ");
            int favColorsCount = int.Parse(Console.ReadLine());
            if (favColorsCount > 0)
            {
                Person.FavColors = new string[favColorsCount];
                Console.WriteLine();
                Person.FavColors = UserFavColors(favColorsCount);
                Console.WriteLine();
            }

            else
            {
                Person.FavColors = new string[0];
            }

            return Person;//(Person.Name, Person.Surname, Person.Age, Person.HasPet, Person.PetName, Person.FavColors);


            // Метод "Клички питомцев"

            static string[] UserPets(int count)
            {
                string[] petName = new string[count];

                for (int i = 0; i < count; i++)
                {
                    Console.Write($"Введите кличку {i + 1} питомца: ");
                    petName[i] = Console.ReadLine();
                }

                return petName;
            }

            // Метод "Любимые цвета"

            static string[] UserFavColors(int count)
            {
                string[] favColors = new string[count];

                for (int i = 0; i < count; i++)
                {
                    Console.Write($"Введите любимый цвет #{i + 1}: ");
                    favColors[i] = Console.ReadLine();
                }

                return favColors;
            }

            // Метод проверки

            static string Editing(string data, string enter, out string edit)
            {
                if (data == "Имя" || data == "Фамилия")
                {
                    foreach (var sign in enter)
                    {
                        bool signCheck = Char.IsNumber(sign);
                        while (signCheck == true)
                        {
                            Console.Write($"{data} не может содержать цифры!\nВведите еще раз: ");
                            enter = Console.ReadLine();
                            foreach (var signSecond in enter)
                            {
                                signCheck = Char.IsNumber(signSecond);
                            }
                            Console.WriteLine();
                        }
                    }
                    edit = enter;
                    return edit;
                }
                else
                {
                    bool signCheck = int.TryParse(enter, out int number);

                    while (signCheck == false || (signCheck == true && number <= 0))
                    {
                        Console.Write($"{data} должен состоять только из цифр и быть больше нуля!\nВведите еще раз: ");
                        enter = Console.ReadLine();
                        signCheck = int.TryParse(enter, out number);
                        Console.WriteLine();
                    }
                    edit = enter;
                    return edit;
                }
            }
        }
    }
}

