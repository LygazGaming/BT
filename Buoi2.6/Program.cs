using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2._6
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
        static double dotpro(int[,] a, int[,] b)
        {
            double dot = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    dot = dot + a[i, j] * b[i, j];
                }
            }
            return dot;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("nhap n: ");
            int n = int.Parse(Console.ReadLine());
            int[,] a = new int[n, n];
            int[,] b = new int[n, n];
            Console.WriteLine("nhap mang a: ");
            nhapMang(a);
            Console.WriteLine("nhap mang b:");
            nhapMang(b);
            Console.WriteLine("xuat mang a: ");
            xuatMang(a);
            Console.WriteLine("xuat mang b: ");
            xuatMang(b);
            Console.WriteLine("dot product cua a va b = " + dotpro(a, b));
        }

    }
}
