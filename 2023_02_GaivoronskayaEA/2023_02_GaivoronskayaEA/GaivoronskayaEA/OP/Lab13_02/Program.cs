namespace GaivoronskayEA.OP.Lab13_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа №13");
            Console.WriteLine("Приложение Lab13_02");
            Console.WriteLine("Разработчик: Гайворонская Е. А");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Вычисление факториала");

            int f = 1;
            Console.WriteLine("Введите число:");
            int n = int.Parse(Console.ReadLine());
            if (n < 0)
            {
                Console.WriteLine("Некоректное значение");
            }
            else
            {
                if (n == 1)
                {
                    Console.WriteLine("Факториал числа равен 1!");
                }
                else
                {
                    for (int i = 1; i < n; i++)
                    {
                        f *= (i + 1);
                    }
                    Console.WriteLine("Факториал числа " + n + " = " + f);
                }
                
            }
        }
    }
}