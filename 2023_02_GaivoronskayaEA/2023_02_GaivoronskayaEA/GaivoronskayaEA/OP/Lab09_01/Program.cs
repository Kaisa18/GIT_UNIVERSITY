using System;

namespace GaivoronskayEA.OP.Lab09_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа №9");
            Console.WriteLine("Приложение Lab09_01");
            Console.WriteLine("Разработчик: Гайворонская Е. А");
            Console.WriteLine("-------------------------");
            //Информация о задаче
            Console.WriteLine("Вычисление суммы ряда с заданной точностью");
            Console.WriteLine("-----------------------------------------");
            // Основной код программы
            Console.WriteLine("Введите значение x: ");
            double x = double.Parse(Console.ReadLine());

            if (Math.Abs(x) >= 1)
            {
                Console.WriteLine("Введенное значение x не принадлежит области определений |x|<1");
            }
            else
            {
                Console.WriteLine("Введите максимальное количество слагаемых: ");
                int imax = int.Parse(Console.ReadLine());
                double e = 0.00001;
                double st = 1;
                double s = 0;
                bool pr = false;
                int i = 1;
                for (i = 1; i <= imax; i++)
                {
                    st = st * x;
                    double a = -(st) / i;
                    s = s + a;
                    if (Math.Abs(a) < e)
                    {
                        pr = true;
                        break;
                    }
                }
                Console.WriteLine(pr ? ("Сумма ряда равна " + s) : ("Превышено максимальное число итераций " + imax));
                Console.WriteLine("Проверка: ln(1-" + x + ")=" + Math.Log(1 - x));
            }
            Console.ReadLine();
        }
    }
}

