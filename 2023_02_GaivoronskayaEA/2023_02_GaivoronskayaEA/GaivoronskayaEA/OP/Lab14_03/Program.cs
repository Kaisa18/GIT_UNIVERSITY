namespace GaivoronskayEA.OP.Lab14_03
{
    internal class Program
    {
        static void Head(int nLub, string num, string info)
        {
            Console.WriteLine("Лабораторная работа №" + nLub);
            Console.WriteLine("Приложение Lab" + nLub + "_" + num);
            Console.WriteLine("Разработчик: " + info);
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Вывод стандартной шапки через функцию");
            Console.WriteLine("------------------------");
        }
        static double Max(params double[] num)
        {
            double max = num[0];
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] > max)
                {
                    max = num[i];
                }
            }
            return max;
        }
        static void Main(string[] args)
        {
            Head(14, "03", "Гайворонская Е.А");

            double max = Max(3, 7, 2, -1);
            Console.WriteLine("Максимальный элемент массива:" + max);

            Console.ReadLine();
        }

    }
}
