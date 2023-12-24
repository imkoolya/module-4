using System;

class MainClass
{
    static void Main(string[] args)
    {
        (string Name, string LastName, string Login, int LoginLength, bool HasPet, string[] favcolors, double Age) User;
        for (int a = 0; a < 3; a++)
        {
            Console.WriteLine("Введите имя");
            User.Name = Console.ReadLine();

            Console.WriteLine("Введите фамилию");
            User.LastName = Console.ReadLine();

            Console.WriteLine("Введите логин");
            User.Login = Console.ReadLine();
            User.LoginLength = User.Login.Length;

            Console.WriteLine("Есть ли у вас животные? Да или Нет");
            var HasPetReadLine = Console.ReadLine();
            if (HasPetReadLine == "Да")
            {
                User.HasPet = true;
            }
            else
            {
                User.HasPet = false;
            }

            Console.WriteLine("Введите возраст пользователя");
            User.Age = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите 3 любимых цвета пользователя");
            User.favcolors = new string[3];
            for (int i = 0; i < User.favcolors.Length; i++)
            {
                User.favcolors[i] = Console.ReadLine();
            }
        }

    }
}