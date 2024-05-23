using System;

namespace GaivoronskayEA.OP.Lab13_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа №13");
            Console.WriteLine("Приложение Lab13_01");
            Console.WriteLine("Разработчик: Гайворонская Е. А");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Попадает ли точкка в заданную область");

            Console.WriteLine("Введите координату точки x:");
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите координату точки y:");
            double y = double.Parse(Console.ReadLine());

            double x1 = x - 1;
            double y1 = y - 2;

            bool p1 = (y <= -x1 * x1 + 2);
            bool p2 = (y >= -x1);
            bool p3 = (x1 * x1 + y1 * y1 <= 4);

            if (p1 && p2 && p3)
            {
                Console.WriteLine("Точка принадлежит области");
            }
            else
            {
                Console.WriteLine("Точка не принадлежит области");
            }

            Console.ReadLine();
        }
        
    }
}
