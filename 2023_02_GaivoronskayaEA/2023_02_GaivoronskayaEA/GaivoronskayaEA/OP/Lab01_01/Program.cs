using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaivoronskayEA.OP.Lab08_03 
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа №8");
            Console.WriteLine("Приложение Lab08_03");
            Console.WriteLine("Разработчик: Гайворонская Е. А");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Инженерный калькулятор");
            Console.WriteLine("-------------------------------");
            // Основной код программы
            double z = 0;
            Console.WriteLine("Вы хотите использовать унарную операцию? Если да, то - введите (Uno), если нет введите (Bin): ");
            string choice = Console.ReadLine();
            if (choice == "Bin")
            {
                Console.WriteLine("Введите первое число x: ");
                double x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите второе число y: ");
                double y = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите операцию: (+, -, *, /, ^)");
                string OperationUno = Console.ReadLine();
                switch (OperationUno)
                {
                    case "+":
                        z = x + y;
                        break;
                    case "-":
                        z = x - y;
                        break;
                    case "*":
                        z = x * y;
                        break;
                    case "/":
                        z = x / y;
                        break;
                    case "^":
                        z = Math.Pow(x, y);
                        break;
                    default:
                        Console.WriteLine("Неправильный оператор.");
                        return;
                }
            }
            else if (choice == "Uno")
            {
                Console.WriteLine("Введите первое число x: ");
                double x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите операцию: (sin, cos, tan, log):");
                string OperationBin = Console.ReadLine();
                switch (OperationBin)
                {
                    case "sin":
                        z = Math.Sin(x);
                        break;
                    case "cos":
                        z = Math.Cos(x);
                        break;
                    case "tan":
                        z = Math.Tan(x);
                        break;
                    case "log":
                        z = Math.Log(x);
                        break;
                    default:
                        Console.WriteLine("Неправильный оператор.");
                        return;
                }
            }
            else
            {
                z = double.NaN;
                Console.WriteLine("Введенная операция не предусмотрена");
                Console.ReadLine();
            }
            Console.WriteLine("Результат операции равен: " + z);
            Console.ReadLine();
        }
    }
}
