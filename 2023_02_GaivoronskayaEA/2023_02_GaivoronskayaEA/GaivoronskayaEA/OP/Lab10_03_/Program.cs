using System;


namespace GaivoronskayEA.OP.Lab10_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа №10");
            Console.WriteLine("Приложение Lab10_03");
            Console.WriteLine("Разработчик: Гайворонская Е. А");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Скалярное произведение");
            // Основной код программы
            //Вводим первый вектор
            Console.WriteLine("Введите вектор (одномерный массив вещественных чисел)");
            Console.WriteLine("Введите размерность массивов");
            int n = int.Parse(Console.ReadLine());
            double[] a = new double[n];
            Console.WriteLine("Введите элементы массива по одному в строке: ");
            for (int i = 0; i < n; i++)
            {
                a[i] = double.Parse(Console.ReadLine());
            }
            //Вводим второй вектор
            Console.WriteLine("Введите вектор (одномерный массив вещественных чисел)");
            Console.WriteLine("Введите размерность массива B");
            int m = int.Parse(Console.ReadLine());
            double[] b = new double[n];
            Console.WriteLine("Введите элементы массива по одному в строке: ");
            for (int i = 0; i < n; i++)
            {
                b[i] = double.Parse(Console.ReadLine());
            }
            //Умножение массивов
            double P = 0;
            for (int i = 0; i < n; i++)
            {
                P += a[i] * b[i];
            }
            Console.WriteLine("Скалярное произведение векторов равно: " + P);
            Console.ReadLine();
        }
    }
}
