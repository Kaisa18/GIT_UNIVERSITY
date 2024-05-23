using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GaivoronskayEA.OP.Lab16_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Helper.Head(16, "02", "Поэлементное умножение двух массивов целых чисел:");

            int[] a1 = Helper.ReadArrayOfInt();
            int n = a1.Length;

            int[] a2 = Helper.ReadArrayOfInt(n);

            double[] product = new double[n];

            for (int i = 0; i < n; i++)
            {
                product[i] = a1[i] * a2[i];
            }

            Console.WriteLine("Результат поэлементного умножения:");
            Helper.WriteArray(product);

            Console.ReadLine();
        }
    }
}
