namespace GaivoronskayEA.OP.Lab14_02
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
        static double Arctg(double x, ref double e, ref int n, out bool pr)
        {
            double sum = 0;
            double s1 = 0;
            for (int i = 0; i <= n; i++)
            {
                s1 = (Math.Pow(-1, i) * Math.Pow(x, 2 * i + 1) / (2 * i + 1));
                sum += s1;
                if (Math.Abs(s1) < e)
                {
                    e = Math.Abs(s1);
                    pr = true;
                    n = i;
                    return sum;
                }
                else
                {
                    continue;
                }

            }
            e = Math.Abs(s1);
            pr = false;
            return sum;
        }
        static void Main(string[] args)
        {
            Head(14, "01", "Гайворонская Е.А");

            Console.WriteLine("Введите аргумент x: ");
            double x = double.Parse(Console.ReadLine());
            if (Math.Abs(x) > 1)
            {
                Console.WriteLine("не принадлежит ОДЗ");

            }
            else
            {

                Console.WriteLine("Введите требуемую точность: ");
                double e = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите количество итераций: ");
                int n = int.Parse(Console.ReadLine());
                bool pr = false;
                double res = Arctg(x, ref e, ref n, out pr);
                if (pr)
                {
                    Console.WriteLine("Значение arctg = " + res);
                    Console.WriteLine("Фактическая точность = " + e);
                    Console.WriteLine("Фактическое кол-во итераций = " + n);
                    Console.WriteLine("Проверка:" + Math.Atan(x) + "= " + res);
                }
                else
                {
                    Console.WriteLine("Превышено количество итераций");
                }
            }
            Console.ReadLine();
        }

    }
}
