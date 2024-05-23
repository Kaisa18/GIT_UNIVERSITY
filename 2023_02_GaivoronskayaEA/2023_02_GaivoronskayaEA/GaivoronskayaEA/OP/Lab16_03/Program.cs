using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GaivoronskayEA.OP.Lab16_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Helper.Head(16, "03", "Вывод факториала");

            Console.WriteLine("Введите число для вычисления факториала:");
            int f = int.Parse(Console.ReadLine());
            if (Helper.Factorial(f) > 0)
            {
                Console.WriteLine("Факториал равен = " + Helper.Factorial(f));
            }
            else
            {
                Console.WriteLine("Некоректное значение");
            }
            Console.ReadLine();
        }
    }
}
