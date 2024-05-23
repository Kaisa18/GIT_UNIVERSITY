using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace GaivoronskayEA.OP.Lab18_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Helper.Head(18, "03", "Чтение матрицы из текстового файла");
            string path = "C:\\Users\\osnov\\Desktop\\массив.txt";
            double[][] matrix = Helper.ReadMatrixFile(path);
            Helper.WriteMatrixOfDouble(matrix);
            Console.ReadLine();
        }
    }
}
