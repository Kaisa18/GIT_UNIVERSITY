using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaivoronskayEA.OP.Lab02_02
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
            Console.WriteLine("Вывод-вывд нескольких слов");
            Console.WriteLine("-------------------------");
            //Основной код программы
            Console.WriteLine("Введите деннь недели:");
            string day = Console.ReadLine();
            Console.WriteLine("Введите время суток:");
            string time = Console.ReadLine();
            Console.WriteLine("В " + day + " " + time + " был пасмурным.");
            Console.ReadLine();

        }
    }
}
