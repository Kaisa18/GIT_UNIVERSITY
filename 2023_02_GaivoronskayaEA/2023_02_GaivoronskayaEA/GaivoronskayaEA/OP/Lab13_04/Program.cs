namespace GaivoronskayEA.OP.Lab13_04
{
    class Program
    {
        static int Fact(int n)
        {
            int f = 1;
            if (n < 0)
            {
                return 0;
            }
            if (n == 0)
            {
                return 1;
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    f *= (i + 1);
                }
                return f;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа №13");
            Console.WriteLine("Приложение Lab13_04");
            Console.WriteLine("Разработчик: Гайворонская Е. А");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Вычисление факториала через функцию");

            Console.WriteLine("Введите число:");
            int n = int.Parse(Console.ReadLine());
            
            if (Fact(n) == 0)
            {
                Console.WriteLine("Некоректное значение");
            }
            else
            {
                Console.WriteLine(Fact(n));
            }

        
        }
    }
}
