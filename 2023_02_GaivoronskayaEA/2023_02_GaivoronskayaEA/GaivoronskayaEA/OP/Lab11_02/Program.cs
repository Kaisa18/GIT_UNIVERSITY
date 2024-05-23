using System;

namespace Lab11_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа №11");
            Console.WriteLine("Приложение Lab11_02;");
            Console.WriteLine("Разработчик: Гайворонская Е.А");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Определение последнего минимального элемента");
            Console.WriteLine("-------------------------");

            double min = double.PositiveInfinity;
            double imin = -1;
            Console.WriteLine("Введите размер массива:");
            int n = int.Parse(Console.ReadLine());
            double[] a = new double[n];
            Console.WriteLine("Заполните массив:");
            for (int i = 0; i < n; i++)
            {
                a[i] = double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                if (min >= a[i])
                {
                    min = a[i];
                    imin = i;
                }
            }
            Console.WriteLine("Последний минимальный элемент массива: " + min);
            Console.WriteLine("Его индекс: " + imin);
            Console.ReadLine();
        }
    }
}