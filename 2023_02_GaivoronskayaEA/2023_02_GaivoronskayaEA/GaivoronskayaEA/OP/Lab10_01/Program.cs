using System;

namespace GaivoronskayEA.OP.Lab10_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа №10");
            Console.WriteLine("Приложение Lab10_01");
            Console.WriteLine("Разработчик: Гайворонская Е. А");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Умножение вектора на число");
            Console.WriteLine("-------------------------------");
            // Основной код программы
            // n - размерность массива а
            // p - поэлементный множитель
            Console.WriteLine("Введите вектор (одномерный массив вещественных чисел)");
            Console.WriteLine("Введите размерность массива");
            int n = int.Parse(Console.ReadLine());
            double[] a = new double[n];
            Console.WriteLine("Введите элементы массива по одному в строке: ");
            for (int i = 0; i < n; i++)
            {
                a[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Введите значение множителя: ");
            double p = double.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                a[i] = a[i] * p;
            }
            Console.WriteLine("Результат умножения: ");     
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.ReadLine();
        }
    }
}
