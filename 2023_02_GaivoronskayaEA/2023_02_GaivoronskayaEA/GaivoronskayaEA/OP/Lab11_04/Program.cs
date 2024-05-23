using System;

namespace GaivoronskayEA.OP.Lab11_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа №11");
            Console.WriteLine("Приложение Lab11_04");
            Console.WriteLine("Разработчик: Гайворонская Е. А");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Номирование массива");

            Console.WriteLine("Введите размерность массива:");
            int n = int.Parse(Console.ReadLine());
            double[] a = new double[n];
            double max = double.NegativeInfinity;
            Console.WriteLine("Заполните массив:");
            for(int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if (max < Math.Abs(a[j]))
                    {
                        max = Math.Abs(a[j]);
                    }
                }
                a[i] /= max;
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.ReadLine();
        }
    }
}
