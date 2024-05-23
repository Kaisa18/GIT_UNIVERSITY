using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaivoronskayEA.OP.Lab02_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа №1");
            Console.WriteLine("Приложение Lab01_04;");
            Console.WriteLine("Разработчик: Гайворонская Е.А");
            Console.WriteLine("------------------------");
            // Информация о задаче
            Console.WriteLine("Ввод-вывод целых чисел");
            Console.WriteLine("-------------------------");

            Console.WriteLine("Введите число:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Квадрат числа " + a + " равен: " + a * a);

            Console.ReadLine();
        }
    }
}
