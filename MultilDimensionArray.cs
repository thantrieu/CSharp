using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class MultilDimensionArray
    {
        static void Main()
        {
            // mang hai chieu
            // mang vuong
            int[,] matrix = new int[10, 8];
            bool[,] cons = new bool[5, 5];
            string[,] something = new string[6, 8];

            int row = cons.GetLength(0); // so hang
            int col = cons.GetLength(1); // so cot

            //Console.WriteLine($"Hang: {row}, so cot: {col}");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = i * j;
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            // mang zigzag
            int[][] matrix2 = new int[10][];
            for (int i = 0; i < matrix2.Length; i++)
            {
                matrix2[i] = new int[1 + i];
            }

            row = matrix2.Length; // so hang
            int colOfRow8 = matrix2[8].Length; // so cot cua hang thu 1

            //Console.WriteLine($"Hang: {row}, so cot: {colOfRow8}");
            Console.WriteLine("===========================================");
            for (int i = 0; i < matrix2.Length; i++)
            {
                for (int j = 0; j < matrix2[i].Length; j++)
                {
                    matrix2[i][j] = j - i;
                    Console.Write(matrix2[i][j] + " ");
                }
                Console.WriteLine();
            }

            float[][] floats;
        }
    }
}
