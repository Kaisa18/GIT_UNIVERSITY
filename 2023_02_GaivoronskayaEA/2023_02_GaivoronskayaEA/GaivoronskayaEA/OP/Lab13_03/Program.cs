namespace GaivoronskayEA.OP.Lab13_03
{
    class Program
    {
        static bool Predicate(double X, double Y)
        {
            bool p1 = (Y <= -(X - 1) * (X - 1) + 2);
            bool p2 = (Y >= -(X - 1));
            bool p3 = ((X - 1) * (X - 1) + (Y - 2) * (Y - 2) <= 4);
            return p1 && p2 && p3;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа №13");
            Console.WriteLine("Приложение Lab13_03");
            Console.WriteLine("Разработчик: Гайворонская Е. А");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Попадет ли точка в заданную область");

            Console.WriteLine("Введите координату точки x:");
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите координату точки y:");
            double y = double.Parse(Console.ReadLine());

            if (Predicate(x, y))
            {
                Console.WriteLine("Точка принадлежит области");
            }
            else
            {
                Console.WriteLine("Точка не принадлежит области");
            }
        }
    }
}