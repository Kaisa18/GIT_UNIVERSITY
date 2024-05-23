namespace GaivoronskayEA.OP.Lab15_01
{
    class Program
    {
        static int Fact_Rec(int n)
        {
            if (n > 0)
            {
                return Fact_Rec(n - 1) * n;
            }
            else
            {
                if (n == 0)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа №15");
            Console.WriteLine("Приложение Lab15_01");
            Console.WriteLine("Разработчик: Гайворонская Е. А");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Вычисление факториала по рекуррентной формуле");

            Console.WriteLine("Введите число:");
            int n = int.Parse(Console.ReadLine());
            if (Fact_Rec(n) == 0)
            {
                Console.WriteLine("Некоректное значение:");
            }
            else
            {
                Console.WriteLine(Fact_Rec(n));
            }
        }
    }
}

