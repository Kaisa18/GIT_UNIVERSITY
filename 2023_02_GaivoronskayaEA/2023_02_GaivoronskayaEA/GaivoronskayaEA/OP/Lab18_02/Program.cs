using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace GaivoronskayEA.OP.Lab18_02
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            Helper.Head(18, "02", "Ввод матрицы в текстовый файл");
            string path = "C:\\Users\\osnov\\Desktop\\массив.txt";
            Console.WriteLine("Введите размерность массива:");
            int n = int.Parse(Console.ReadLine());
            double[][] matrix = Helper.ReadMatrixOfDouble(n);
            Helper.WriteMatrixFile(path, matrix);
            Console.ReadLine();
        }
    }   
}
