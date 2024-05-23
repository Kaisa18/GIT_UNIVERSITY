using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaivoronskayEA.OP.Lab02_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Стандартная шапка
            Console.WriteLine("Лабораторная работа №2");
            Console.WriteLine("Приложение Lab02_01;");
            Console.WriteLine("Разработчик: Гайворонская Е.А");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Вывод-вывод текста");
            Console.WriteLine("-------------------------");

            //Основной код программы
            Console.WriteLine("Саша + Маша = Л");
            Console.WriteLine("Введите первое имя:");
            string name1 = Console.ReadLine();
            Console.WriteLine("Введите второе имя:");
            string name2 = Console.ReadLine();
            Console.WriteLine(name1 + " + " + name2 + " = Л");

            Console.ReadLine();

        }
    }
}
