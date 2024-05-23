using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaivoronskayEA.OP.Lab17_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Helper.Head(17, "02", "Вывод таблицы значений функции");
            Console.WriteLine("Введите левую границу:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите правую границу:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите шаг:");
            double h = double.Parse(Console.ReadLine());
            Helper.TableFuncArctg(a, b, h);
            Console.ReadLine();
        }
    }
}
