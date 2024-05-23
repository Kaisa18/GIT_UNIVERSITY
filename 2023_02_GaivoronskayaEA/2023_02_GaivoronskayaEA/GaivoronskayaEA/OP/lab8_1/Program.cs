using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GnatienkoAE.OP.Lab08_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа №8");
            Console.WriteLine("Приложение Lab08_03");
            Console.WriteLine("Разработчик: Гайворонская Е.А");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Инженерный калькулятор");
            Console.WriteLine("-------------------------------");
            // Основной код программы
            double z = 0;
            Console.WriteLine("Вы хотите использовать унарную операцию? Если да, то - введите (Unary), если нет введите (Binary): ");
            string choice = Console.ReadLine();
            if (choice == "Binary")
            {
                Console.WriteLine("Введите первое число x: ");
                double x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите второе число y: ");
                double y = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите операцию: (+, -, *, /, ^)");
                string OperationUnary = Console.ReadLine();
                switch (OperationUnary)
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
                        z = double.NaN;
                        Console.WriteLine("Неправильный оператор.");
                        Console.ReadLine();
                        return;
                }
            }
            else if (choice == "Unary")
            {
                Console.WriteLine("Введите первое число x: ");
                double x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите операцию: (sin, cos, tan, log):");
                string OperationBinary = Console.ReadLine();
                switch (OperationBinary)
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
                        z = double.NaN;
                        Console.WriteLine("Неправильный оператор.");
                        Console.ReadLine();
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


