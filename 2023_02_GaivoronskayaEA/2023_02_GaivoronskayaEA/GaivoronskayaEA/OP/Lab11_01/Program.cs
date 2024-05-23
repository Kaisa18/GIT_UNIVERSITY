using System;

namespace Lab11_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа №11");
            Console.WriteLine("Приложение Lab11_01;");
            Console.WriteLine("Разработчик: Гайворонская Е.А");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Определение первого минимального элемента");
            Console.WriteLine("-------------------------");

            Console.WriteLine("Введите длинну массива:");
            int n = int.Parse(Console.ReadLine());
            double[] a = new double[n];
            double min = double.PositiveInfinity;
            int imin = -1;

            Console.WriteLine("Заполните массив:");
            for (int i = 0; i < n; i++)
            {
                a[i] = double.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                if (min > a[i])
                {
                    min = a[i];
                    imin = i;
                }
            }
            Console.WriteLine("Минимальный элемент массива:" + min + ",его индекс:" + imin);
            Console.ReadLine();

            
        }
    }
}
