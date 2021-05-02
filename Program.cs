using System;

namespace EX5
{
    class Program
    {
        static void Main(string[] args)
        {
            //5.
            //а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
            //б) Сделать задание, только вывод организовать в центре экрана.
            //в) *Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y).

            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            int centerX1 = (Console.WindowWidth / 2) - (name.Length / 2);
            int centerY1 = (Console.WindowHeight / 2) - 3;

            Console.Write("Введите фамилию: ");
            string surname = Console.ReadLine();
            int centerX2 = (Console.WindowWidth / 2) - (surname.Length / 2);
            int centerY2 = (Console.WindowHeight / 2) - 2;

            Console.Write("Введите город: ");
            string city = Console.ReadLine();
            int centerX3 = (Console.WindowWidth / 2) - (city.Length / 2);
            int centerY3 = (Console.WindowHeight / 2) - 1;

            Console.SetCursorPosition(centerX1, centerY1);
            Console.WriteLine(name);
            Console.SetCursorPosition(centerX2, centerY2);
            Console.WriteLine(surname);
            Console.SetCursorPosition(centerX3, centerY3);
            Console.WriteLine(city);

        }
    }
}
