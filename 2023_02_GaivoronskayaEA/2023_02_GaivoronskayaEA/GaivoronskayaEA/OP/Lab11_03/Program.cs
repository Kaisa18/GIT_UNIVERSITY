using System;

namespace GaivoronskayEA.OP.Lab11_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа №11");
            Console.WriteLine("Приложение Lab11_03");
            Console.WriteLine("Разработчик: Гайворонская Е. А");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Определение всех мминимальных значений");
            Console.WriteLine("-------------------------------");

            double min = double.PositiveInfinity;
            int m = 0;

            Console.WriteLine("Введите размер массива:");
            int n = int.Parse(Console.ReadLine());
            double[] a = new double[n];
            Console.WriteLine("Заполните массив:");
            double[] imin = new double[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                if (min > a[i])
                {
                    min = a[i];
                    m = 1;
                    imin[0] = i;
                }
                else
                {
                    if (min == a[i])
                    {
                        m += 1;
                        imin[m - 1] = i;
                    }
                }
            }
            Console.WriteLine("Минимальный значение элементов массива: " + min);
            Console.WriteLine("Индексы всех минимальных элементов:");
            for (int i = 0; i < m; i++)
            {
                Console.WriteLine(imin[i]);
            }
            Console.ReadLine();
        }
    }
}
