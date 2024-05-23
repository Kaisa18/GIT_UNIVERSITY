using System;

namespace GaivoronskayEA.OP.Lab08_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа №8");
            Console.WriteLine("Приложение Lab08_02");
            Console.WriteLine("Разработчик: Гайворонская Е. А");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Простейший калькулятор (if)");
            Console.WriteLine("-------------------------------");
            // Основной код программы
            Console.WriteLine("Введите значение первого операнда(аргумента): ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение второго операнда(аргумента): ");
            double y = double.Parse(Console.ReadLine());
            double z;
            Console.WriteLine("Задайте операцию (+, -, /, *, ^):");
            string op = Console.ReadLine();
            if (op == "+")
            {
                z = x + y;
                Console.WriteLine(x + " " + op + " " + y + " = " + z);
            }
            else if (op == "-")
            {
                z = x - y;
                Console.WriteLine(x + " " + op + " " + y + " = " + z);
            }
            else if (op == "/")
            {
                z = x / y;
                Console.WriteLine(x + " " + op + " " + y + " = " + z);

            }
            else if (op == "*")
            {
                z = x * y;
                Console.WriteLine(x + " " + op + " " + y + " = " + z);
            }
            else if (op == "^")
            {
                z = Math.Pow(x, y);
                Console.WriteLine(x + " " + op + " " + y + " = " + z);
            }
            else
            {
                z = double.NaN;
                Console.WriteLine("Неизвестная операция");
            }
            Console.ReadLine();
        }
    }
}

