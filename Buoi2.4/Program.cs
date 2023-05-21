using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2._4
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
        static void xuatMang(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void hoandoi(int[,] a, int[,] b)
        {
            for (int i = 0; i < a.GetLength(1); i++)
            {
                for (int j = 0; j < a.GetLength(0); j++)
                {
                    b[i, j] = a[j, i];
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("nhap n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap m: ");
            int m = int.Parse(Console.ReadLine());
            int[,] a = new int[n, m];
            int[,] b = new int[m, n];
            Console.WriteLine("nhap mang a: ");
            nhapMang(a);
            Console.WriteLine("xuat mang a: ");
            xuatMang(a);
            hoandoi(a, b);
            Console.WriteLine("ma tran chuyen vi cua a la: ");
            xuatMang(b);
        }

    }
}
