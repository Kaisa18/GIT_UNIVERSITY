using System;

namespace GaivoronskayEA.OP.Lab09_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа №9");
            Console.WriteLine("Приложение Lab09_03");
            Console.WriteLine("Разработчик: Гайворонская Е. А");
            Console.WriteLine("-------------------------");
            //Информация о задаче
            Console.WriteLine("Вычисление суммы четных чисел");
            Console.WriteLine("----------------------------");

            // Основной код программы
            int a = 0;
            int sum = 0;
            while (a % 2 == 0)
            {
                Console.WriteLine("Введите число");
                a = int.Parse(Console.ReadLine());

                if (a % 2 == 1)
                {
                    break;
                }
                sum += a;
            }
            Console.WriteLine("Сумма четных чисел = " + sum);
            Console.ReadLine();
        }
    }
}

