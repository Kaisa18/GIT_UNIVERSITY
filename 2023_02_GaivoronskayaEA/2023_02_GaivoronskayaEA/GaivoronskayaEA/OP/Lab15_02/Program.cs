namespace GaivoronskayEA.OP.Lab15_02
{
    class Program
    {
        static int C_Rec(int n, int m)
        {
            if (n == m)
            {
                return 1;
            }
            else
            {
                if (m == 1)
                {
                    return n;
                }
                else
                {
                    {
                        return C_Rec(n - 1, m) + C_Rec(n - 1, m - 1);
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа №15");
            Console.WriteLine("Приложение Lab15_02");
            Console.WriteLine("Разработчик: Гайворонская Е. А");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Подсчет числа сочетаний без повторений по рекуррентной формуле");

            Console.WriteLine("Введите число n:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число m:");
            int m = int.Parse(Console.ReadLine());
            if (n >= m && m > 0)
            {
                Console.WriteLine(C_Rec(n, m));
            }
            else
            {
                Console.WriteLine("Недопустимое значение");
            }
        }
    }
}