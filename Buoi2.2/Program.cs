using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrixA, matrixB, matrixC;
            InputMatrix2(out matrixA, out matrixB);
            Console.WriteLine("Ma tran A:");
            PrintMatrix(matrixA);
            Console.WriteLine("Ma tran B:");
            PrintMatrix(matrixB);
            matrixC = ProductMatrix(matrixA, matrixB);
            Console.WriteLine("Tich Ma tran A va Matran B:");
            PrintMatrix(matrixC);
        }
        static void InputMatrix2(out int[,] matrixA, out int[,] matrixB)
        {
            int m, n, p;
            string line = Console.ReadLine();
            string[] nums = line.Split(' ');
            m = int.Parse(nums[0]);
            n = int.Parse(nums[1]);
            p = int.Parse(nums[2]);
            matrixA = new int[m, n];
            matrixB = new int[n, p];
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
        static int[,] ProductMatrix(int[,] matrixA, int[,] matrixB)
        {
            int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
            for (int i = 0; i < matrixC.GetLength(0); i++)
            {
                for (int j = 0; j < matrixC.GetLength(1); j++)
                {
                    matrixC[i, j] = DotProduct(matrixA, matrixB, i, j);
                }
            }
            return matrixC;
        }
        static int DotProduct(int[,] matrixA, int[,] matrixB, int i, int j)
        {
            int total = 0;
            for (int k = 0; k < matrixA.GetLength(1); k++)
            {
                total += matrixA[i, k] * matrixB[k, j];
            }
            return total;
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
    }
}
