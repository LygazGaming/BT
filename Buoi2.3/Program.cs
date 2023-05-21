using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2._3
{
    internal class Program
    {
        static void nhapMang(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"[{i},{j}]: ");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        static void xuatMang(int[,] a, int[,] b, int[,] c)
        {
            int tong = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    c[i, j] = dotpro(a, b, i, j);
                    tong += c[i, j];
                    Console.Write(c[i, j] + " ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("tong doanh thu 7 ngay la: " + tong);
        }
        static int dotpro(int[,] a, int[,] b, int i, int j)
        {
            int dot = 0;
            for (int k = 0; k < a.GetLength(1); k++)
            {
                dot = dot + a[i, k] * b[k, j];
            }
            return dot;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("nhap so trai cay: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap so ngay: ");
            int m = int.Parse(Console.ReadLine());
            int[,] a = new int[1, n];
            int[,] b = new int[n, m];
            int[,] c = new int[1, m];
            Console.WriteLine("nhap gia tien: ");
            nhapMang(a);
            Console.WriteLine("nhap so trai cay ban duoc");
            nhapMang(b);
            Console.WriteLine("doanh thu tung ngay la: ");
            xuatMang(a, b, c);
        }

    }
}
