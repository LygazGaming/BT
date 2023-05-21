using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a;
            int[,] b;
            DocMT(out a, out b);
            Output2DArray(TongMT(a, b));
        }
        static void DocMT(out int[,] a, out int[,] b)
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
        static int[,] TongMT(int[,] a, int[,] b)
        {
            int[,] c = new int[a.GetLength(0), a.GetLength(1)];
            for (int i = 0; i < a.GetLength(0); i++)
                for (int j = 0; j < a.GetLength(1); j++)
                    c[i, j] = a[i, j] + b[i, j];
            return c;
        }
        static void Output2DArray(int[,] c)
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
