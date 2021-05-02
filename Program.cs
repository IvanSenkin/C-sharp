using System;

namespace EX4
{
    class Program
    {
        static void Main(string[] args)
        {
            //4.Написать программу обмена значениями двух переменных типа int без использования вспомогательных методов.
            //а) с использованием третьей переменной;
            //б) *без использования третьей переменной.

            Console.Write("Введите первое число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = a;
            a = b;
            b = c;
            Console.WriteLine($"a) Первое число: {a}, второе число {b}");

            // задание б)*
            Console.Write("Введите первое число: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int y = Convert.ToInt32(Console.ReadLine());

            (x, y) = (y, x);
            Console.WriteLine($"б)* Первое число: {x}, второе число {y}");
        }
    }
}
