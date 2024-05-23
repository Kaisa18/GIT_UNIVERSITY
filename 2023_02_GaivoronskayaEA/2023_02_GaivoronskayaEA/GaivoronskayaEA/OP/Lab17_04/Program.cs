using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaivoronskayEA.OP.Lab17_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Helper.Head(17, "04", "Чтение одномерного массива из текстового файла");
            string path = "C:\\Users\\osnov\\Desktop\\массив.txt";
            double[] array = Helper.ReadArrayFile(path);
            Helper.WriteArray(array);
            Console.ReadLine();
        }
    }
}
