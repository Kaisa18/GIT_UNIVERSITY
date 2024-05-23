using System;

namespace Lab12_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа №12");
            Console.WriteLine("Приложение Lab12_04");
            Console.WriteLine("Разработчик: Гайворонская Е. А");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Метод попарного сравнения");

            Console.WriteLine("Введите размерность массива:");
            int n = int.Parse(Console.ReadLine());
            double[] a = new double[n];
            Console.WriteLine("Введите массив:"); 

            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            for (int k = 1; k < n; k++)
            {
                for (int i = 0; i < n - k; i++)
                {
                    if (a[i] > a[i + 1])
                    {
                        double v = a[i];
                        a[i] = a[i + 1];
                        a[i + 1] = v;
                    }

                }
            }
            Console.WriteLine("Отсортированный массив:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
}
