using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;


namespace GaivoronskayEA.OP.Lab16_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Helper.Head(16, "01", "Поэлементное сложение двух вещественных массивов.");
            //Ввод первого массива
            double[] a1 = Helper.ReadArrayOfDouble();
            int n  = a1.Length;
            //ввод второго массива 
            double[] a2 = Helper.ReadArrayOfDouble(n);

            double[] sum = new double[n];
            for (int i = 0; i < n; i++)
            {
                sum[i] = a1[i] + a2[i];
            }

            Console.WriteLine("Результат поэлементного сложения:");
            Helper.WriteArray(sum); 

            Console.ReadLine();
        }
    }
}
