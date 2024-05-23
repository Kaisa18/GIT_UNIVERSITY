using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GaivoronskayEA.OP
{
    /// <summary>
    /// Класс-контейнер для разрабатываемых в курсе OP программ.
    /// </summary>
    public static class Helper
    {
        /// <summary>
        /// Вывод стандартной шапки
        /// </summary>
        /// <param name="nLub">номер работы</param>
        /// <param name="num">номер приложения</param>
        /// <param name="info">Информация о задании</param>
        public static void Head(int nLub, string num, string info)
        {
            Console.WriteLine("Лабораторная работа №" + nLub);
            Console.WriteLine("Приложение Lab" + nLub + "_" + num);
            Console.WriteLine("Разработчик: Гайворонская Е.А");
            Console.WriteLine("-------------------------------");
            Console.WriteLine(info);
            Console.WriteLine("-------------------------------");
        }
        /// <summary>
        /// Организует ввод одномерного 
        /// массива вещественных чисел с клавиатуры 
        /// по одному элементу в строке
        /// </summary>
        /// <returns>Возвращает введенный с клавиатуры
        /// массив вещественных чисел</returns>
        public static double[] ReadArrayOfDouble()
        {
            Console.WriteLine("Ввод одномерного массива вещественных чисел.");
            Console.WriteLine("Введите размерность массива:");
            int n = int.Parse(Console.ReadLine());
            double[] array = new double[n];
            Console.WriteLine("Введите элементы массива по одному в строке:");

            for (int i = 0; i < n; i++)
            {
                array[i] = double.Parse(Console.ReadLine());
            }
            return array;
        }

        /// <summary>
        /// Организует ввод одномерного 
        /// массива вещественных чисел с клавиатуры 
        /// по одному элементу в строке
        /// </summary>
        /// <param name="length">Длина массива</param>
        /// <returns>Возвращает введенный с клавиатуры
        /// массив вещественных чисел</returns>
        public static double[] ReadArrayOfDouble(int length)
        {
            Console.WriteLine("Длина массива:" + length);
            double[] array = new double[length];
            Console.WriteLine("Введите элементы массива по одному в строке:");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = double.Parse(Console.ReadLine());
            }
            return array;
        }
        /// <summary>
        /// Выводит массив в консольное окно.
        /// </summary>
        /// <param name="array">Массив который будет выведен</param>
        public static void WriteArray(double[] array) {
            for (int i = 0; i < array.Length; i++) {
                Console.WriteLine(array[i]);
            }
        }
        /// <summary>
        /// Организует ввод целочисленного массива с 
        /// клавиатурой по одному элементу в строке
        /// </summary>
        /// <returns>Возвращет массив целых чисел</returns>
        public static int[] ReadArrayOfInt()
        {
            Console.WriteLine("Ввод одномерного массива вещественных чисел.");
            Console.WriteLine("Введите размерность массива:");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            Console.WriteLine("Введите первый массив:");
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            return array;
        }
        /// <summary>
        /// Организует ввод одномерного 
        /// массива целых чисел с клавиатуры 
        /// по одному элементу в строке
        /// </summary>
        /// <param name="length">Длина массива</param>
        /// <returns>Возвращает введенный с клавиатуры
        /// массив целых чисел</returns>
        public static int[] ReadArrayOfInt(int length)
        {
            Console.WriteLine("Длина массива:" + length);
            int[] array = new int[length];
            Console.WriteLine("Введите второй массив:");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            return array;
        }
        /// <summary>
        /// вычисление факториала
        /// </summary>
        /// <param name="f"></param>
        /// <returns>возвращает значение числа</returns>
        public static int Factorial(int f)
        {
            if (f > 0)
            {
                return Factorial(f - 1) * f;
            }
            else
            {
                if (f == 0)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
        /// <summary>
        /// Вывод таблицы умножения до 9
        /// </summary>
        public static void MultiplicationTable()
        {
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    Console.Write("{0,3}", i * j);
                }
                Console.WriteLine();
            }
        }
        /// <summary>
        /// Расчет функции
        /// </summary>
        /// <param name="a">Левая граница отрезка</param>
        /// <param name="b">Правая граница отрезка</param>
        /// <param name="h">шаг</param>
        public static void TableFuncArctg(double a, double b, double h)
        {
            Console.WriteLine("     x   |  f(x)");
            Console.WriteLine("-------------------");
            double n = (b - a) / h;
            for (int i = 0; i < n; i++)
            {
                double x = a + h * i;
                double f = Math.Atan(x);
                Console.WriteLine("{0,8:F3} {1,8:F3}", x, f);
            }
        }
        /// <summary>
        /// Выводит одномерный массив 
        /// в текстовый файл
        /// </summary>
        /// <param name="path">Путь к файлу</param>
        /// <param name="array">Одномерный массив, который будет выведен</param>
        public static void WriteArrayFile(string path, double [] array)
        {
            StreamWriter f = new StreamWriter(path, false);
            f.WriteLine(array.Length);
             for (int i = 0; i <array.Length; i++)
            {
                f.WriteLine(array[i]);
            }
            f.Close();
        }
        /// <summary>
        /// Считывает одномерный массив вещественных чисел из текстового файла.
        /// </summary>
        /// <param name="path">Путь к файлу</param>
        /// <returns>Возвращает считанный массив</returns>
        public static double[] ReadArrayFile(string path)
        {
            StreamReader f = new StreamReader(path);
            
            int n = int.Parse(f.ReadLine());
            double[] array = new double[n];

            for (int i = 0;i < n; i++)
            {
                array[i] = double.Parse(f.ReadLine());
            }

            f.Close();
            return array;
        }

        /// <summary>
        /// Ввод двумерного массива
        /// </summary>
        /// <param name="MatrixLength">длина массива</param>
        /// <returns>возвращает значение матрицы</returns>
        public static double[][] ReadMatrixOfDouble(int MatrixLength)
        {
            double[][] matrix = new double[MatrixLength][];
            for (int i = 0; i < matrix.Length; i++)
            {
                double[] matrixi = new double[MatrixLength];
                Console.WriteLine("Введите элементы {0}-й строки по одному в строку",
               i);
                for (int j = 0; j < matrixi.Length; j++)
                {
                    matrixi[j] = double.Parse(Console.ReadLine());
                }
                matrix[i] = matrixi;
            }
            return matrix;
        }

        /// <summary>
        /// Вывод двумерного массива
        /// </summary>
        /// <param name="matrix">Матрица, которая будет выведена</param>
        public static void WriteMatrixOfDouble(double[][] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                double[] matrixi = matrix[i];
                for (int j = 0; j < matrixi.Length; j++)
                {
                    Console.Write("{0,7:f2} ", matrixi[j]);
                }
                Console.WriteLine();
            }
        }
        /// <summary>
        /// Вводит двумерный массив в текстовый файл
        /// </summary>
        /// <param name="path">Путь к файлу</param>
        /// <param name="matrix">Матрица, которая будет выведена</param>
        public static void WriteMatrixFile(string path, double[][] matrix)
        {
            StreamWriter f = new StreamWriter(path, false);
            f.WriteLine(matrix.Length);
            for (int i = 0; i < matrix.Length; i++)
            {
                double[] matrixi = matrix[i];
                for (int j = 0; j < matrixi.Length; j++)
                {
                    f.Write(" {0,7:f2}", matrixi[j]);
                }
                f.WriteLine();
            }
            f.Close();
        }
        /// <summary>
        /// Считывание двумерного массива вещественных чисел из текстового файла
        /// </summary>
        /// <param name="path">Путь к файлу</param>
        /// <returns>Возвращает считанный двумерный массив</returns>
        public static double[][] ReadMatrixFile(string path)
        {
            StreamReader f = new StreamReader(path);
            int m = int.Parse(f.ReadLine());
            double[][] matrix = new double[m][];
            for (int i = 0; i < matrix.Length; i++)
            {
                string[] strs = f.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                double[] matrixi = new double[strs.Length];
                for (int j = 0; j < matrixi.Length; j++)
                {
                    matrixi[j] = double.Parse(strs[j]);
                }
                matrix[i] = matrixi;
            }
            f.Close();
            return matrix;
        }
    }
}