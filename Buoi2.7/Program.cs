using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] intMatrixA;
            int[,] intMatrixB;
            InputMatrix7(out intMatrixA, out intMatrixB);
            int[,] convMatrix = Convolution(intMatrixA, intMatrixB);
            PrintMatrix(convMatrix);
        }
        static void PrintMatrix(int[,] c)
        {
            for (int r = 0; r < c.GetLength(0); r++)
            {
                for (int t = 0; t < c.GetLength(1); t++)
                {
                    Console.Write(c[r, t] + "  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void InputMatrix7(out int[,] matrixA, out int[,] matrixB)
        {
            int m, n, k;
            string line = Console.ReadLine();

            string[] nums = line.Split(' ');
            m = int.Parse(nums[0]);
            n = int.Parse(nums[1]);
            k = int.Parse(nums[2]);
            matrixA = new int[m, n];
            matrixB = new int[k, k];
            for (int r = 0; r < matrixA.GetLength(0); r++)
            {
                line = Console.ReadLine();
                nums = line.Split(' ');
                for (int c = 0; c < matrixA.GetLength(1); c++)
                {
                    matrixA[r, c] = int.Parse(nums[c]);
                }
            }
            for (int r = 0; r < matrixB.GetLength(0); r++)
            {
                line = Console.ReadLine();
                nums = line.Split(' ');
                for (int c = 0; c < matrixB.GetLength(1); c++)
                {
                    matrixB[r, c] = int.Parse(nums[c]);
                }
            }
        }
        static int[,] Convolution(int[,] intMatrixA, int[,] intMatrixB)
        {
            int[,] convMatrix = new int[intMatrixA.GetLength(0) -
            intMatrixB.GetLength(0) + 1,
            intMatrixA.GetLength(1) - intMatrixB.GetLength(1)
            + 1];
            for (int i = 0; i < convMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < convMatrix.GetLength(1); j++)
                    convMatrix[i, j] = DotProduct2(intMatrixA, intMatrixB, i, j);
            }
            return convMatrix;
        }
        static int DotProduct2(int[,] intMatrixA, int[,] intMatrixB, int i, int j)
        {
            int total = 0;
            for (int k = 0; k < intMatrixB.GetLength(0); k++)
                for (int l = 0; l < intMatrixB.GetLength(1); l++)
                    total += intMatrixA[i + k, j + l] * intMatrixB[k, l];
            return total;
        }
    }
}
