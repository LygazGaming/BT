using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a;
            int k;
            DocMang(out a, out k);
            InMang(a, k);
        }
        static void DocMang(out int[,] a, out int k)
        {
            string chuoi = Console.ReadLine();
            string[] num = chuoi.Split(' ');
            int rows = int.Parse(num[0]);
            int cols = int.Parse(num[1]);
            k = int.Parse(num[2]);
            a = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                chuoi = Console.ReadLine();
                num = chuoi.Split(' ');
                for (int j = 0; j < cols; j++)
                {
                    a[i, j] = int.Parse(num[j]);
                }
            }
        }
        static void InMang(int[,] a, int k)
        {
            if (k < 0 || k >= a.GetLength(0)) Console.WriteLine("Invalid k");
            else
                for (int i = 0; i < a.GetLength(1); i++)
                    Console.Write(a[k, i] + " ");
        }
    }
}


