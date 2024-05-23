using System;

namespace GaivoronskayEA.OP.Lab12_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа №12");
            Console.WriteLine("Приложение Lab12_03");
            Console.WriteLine("Разработчик: Гайворонская Е. А");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Сортировка с выбором");
            Console.WriteLine("-------------------------------");


            Console.WriteLine("Введите размер массива:");
            int n = int.Parse(Console.ReadLine());
            double[] a = new double[n];
            Console.WriteLine("Заполните массив");
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            for (int k = 1; k <= n - 1; k++)
            {
                double max = double.NegativeInfinity;
                int imax = -1;
                for (int i = 0; i <= n - k; i++)
                {
                    if (max < a[i])
                    {
                        max = a[i];
                        imax = i;
                    }
                }
                a[imax] = a[n - k];
                a[n - k] = max;
            }

            Console.WriteLine("Отсортированный массив:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
}