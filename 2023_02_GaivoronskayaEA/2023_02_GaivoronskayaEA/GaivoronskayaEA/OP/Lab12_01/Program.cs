using System;

namespace GaivoronskayEA.OP.Lab12_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа №12");
            Console.WriteLine("Приложение Lab12_01");
            Console.WriteLine("Разработчик: Гайворонская Е. А");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Обращение порядка массива");

            Console.WriteLine("Введите размерность массива:");
            int n = int.Parse(Console.ReadLine());

            double[] a = new double[n];
            Console.WriteLine("Заполните массив:");
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            double v;

            for (int i = 0; i < n / 2; i++)
            {
                v = a[i];
                a[i] = a[n - i - 1];
                a[n - i - 1] = v;
            }
            Console.WriteLine("Перевернутый массив:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.ReadLine();
        }
    }
}
                          