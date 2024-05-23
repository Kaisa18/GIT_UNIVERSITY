using System;

namespace GaivoronskayEA.OP.Lab09_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа №9");
            Console.WriteLine("Приложение Lab09_02");
            Console.WriteLine("Разработчик: Гайворонская Е. А");
            Console.WriteLine("-------------------------");
            //Информация о задаче
            Console.WriteLine("Вычисление суммы ряда с заданной точностью");
            Console.WriteLine("-----------------------------------------");

            // Основной код программы
            bool pr = false;
            Console.WriteLine("Введите точность");
            double e = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение x: ");
            double x = double.Parse(Console.ReadLine());
            if (Math.Abs(x) >= 1)
            {
                Console.WriteLine("X не принадлежит ОДЗ");
            }
            else
            {
                Console.WriteLine("Введите макс.кол-во слагаемых");
                int imax = int.Parse(Console.ReadLine());
                double S = 0;
                double St = 1;
                int i = 0;
                while ((i < imax) && (pr == false))
                {
                    i++;
                    St *= x;
                    double a = -St / i;
                    S += a;
                    if (Math.Abs(a) < e)
                    {
                        pr = true;
                    }
                }
                Console.WriteLine(pr ? ("Сумма ряда равна: " + S) : ("Превышено максимальное количество итераций" + imax));
                Console.WriteLine("Проверка: ln(1-" + x + ")=" + Math.Log(1 - x));
            }
            Console.ReadLine();
        }
    }
}

