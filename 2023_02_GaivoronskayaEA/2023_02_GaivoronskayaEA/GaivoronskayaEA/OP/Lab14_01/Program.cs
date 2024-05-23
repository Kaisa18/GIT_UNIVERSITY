namespace GaivoronskayEA.OP.Lab14_01
{
    class Program
    {
        static void Head(int nLub, string num, string info)
        {
            Console.WriteLine("Лабораторная работа №" + nLub);
            Console.WriteLine("Приложение Lab" + nLub + "_" + num);
            Console.WriteLine("Разработчик: " + info);
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Вывод стандартной шапки через функцию");
        }
        static void Main(string[] args)
        {
            Head(14, "01", "Гайворонская Е.А");
        }
    }
}
