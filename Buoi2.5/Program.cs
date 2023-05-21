using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] intMatrixA;
            int[,] intMatrixB;
            InputMatrix(out intMatrixA, out intMatrixB);
            Console.WriteLine("{0:0.00}", Distance(intMatrixA, intMatrixB));
        }
        static void InputMatrix(out int[,] a, out int[,] b)
        {
            int m, n;
            string line = Console.ReadLine();
            string[] nums = line.Split(' ');
            m = int.Parse(nums[0]);
            n = int.Parse(nums[1]);
            a = new int[m, n];
            b = new int[m, n];
            for (int r = 0; r < a.GetLength(0); r++)
            {
                line = Console.ReadLine();
                nums = line.Split(' ');
                for (int c = 0; c < a.GetLength(1); c++)
                {
                    a[r, c] = int.Parse(nums[c]);
                }
            }
            for (int r = 0; r < b.GetLength(0); r++)
            {
                line = Console.ReadLine();
                nums = line.Split(' ');
                for (int c = 0; c < b.GetLength(1); c++)
                {
                    b[r, c] = int.Parse(nums[c]);
                }
            }
        }
        static double Distance(int[,] intMatrixA, int[,] intMatrixB)
        {
            double total = 0;
            for (int i = 0; i < intMatrixA.GetLength(0); i++)
            {
                for (int j = 0; j < intMatrixA.GetLength(1); j++)
                    total += Math.Pow(intMatrixA[i, j] - intMatrixB[i, j], 2);
            }
            return Math.Sqrt(total);
        }
    }
}
