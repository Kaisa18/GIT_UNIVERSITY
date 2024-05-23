using System;

namespace GaivoronskayEA.OP.Lab10_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа №10");
            Console.WriteLine("Приложение Lab10_02");
            Console.WriteLine("Разработчик: Гайворонская Е. А");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Объединение массива");
            Console.WriteLine("-------------------------------");
            // Основной код программы
            //Ввод первого массива
            Console.WriteLine("Введите вектор (одномерный массив вещественных чисел)");
            Console.WriteLine("Введите размерность массива A");
            int n = int.Parse(Console.ReadLine());
            double[] a = new double[n];
            Console.WriteLine("Введите элементы массива по одному в строке: ");
            for (int i = 0; i < n; i++)
            {
                a[i] = double.Parse(Console.ReadLine());
            }
            //Ввод второго массива
            Console.WriteLine("Введите вектор (одномерный массив вещественных чисел)");
            Console.WriteLine("Введите размерность массива B");
            int m = int.Parse(Console.ReadLine());
            double[] b = new double[m];
            Console.WriteLine("Введите элементы массива по одному в строке: ");
            for (int i = 0; i < m; i++)
            {
                b[i] = double.Parse(Console.ReadLine());
            }
            //Объединение массивов
            int f = n + m;
            double[] c = new double[f];
            for (int k = 0; k < n; k++)
            {
                c[k] = a[k];
            }
            for (int k = n; k < n + m; k++)
            {
                c[k] = b[k - n];
            }
            //Вывод объединенного массива
            Console.WriteLine("Объединенный массив: ");
            for (int k = 0; k < n + m; k++)
            {
                Console.WriteLine(c[k]);
            }
            Console.ReadLine();
        }

    }
}
