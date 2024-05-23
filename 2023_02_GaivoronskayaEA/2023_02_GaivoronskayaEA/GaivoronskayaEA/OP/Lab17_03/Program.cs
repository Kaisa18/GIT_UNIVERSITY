using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace GaivoronskayEA.OP.Lab17_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Helper.Head(17, "03", "Разработка и использование метода записи массива в файл");
            string path = "C:\\Users\\osnov\\Desktop\\массив.txt";
            double[] array = Helper.ReadArrayOfDouble();
            Helper.WriteArrayFile(path, array);
            Console.ReadLine();
        }
    }
}
