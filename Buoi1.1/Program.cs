﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap mang a:");
            int[,] a;
            NhapMang1(out a);
            Console.WriteLine("Mang a vua nhap:");
            XuatMang(a);
            Console.WriteLine("Nhap mang b:");
            int[,] b;
            b = NhapMang2();
            Console.WriteLine("Nhap b vua nhap:");
            XuatMang(b);
            Console.WriteLine("Nhap mang c:");
            int m, n;
            m = int.Parse(Console.ReadLine());
            n = int.Parse(Console.ReadLine());
            int[,] c = new int[m, n];
            NhapMang3(c);
            Console.WriteLine("Mang c vua nhap:");
            XuatMang(c);
        }
        static void NhapMang1(out int[,] a)
        {
            Console.Write("Nhap so dong:");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot:");
            int cols = int.Parse(Console.ReadLine());
            a = new int[rows, cols];
            for (int i = 0; i < a.GetLength(0); i++)

                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"a[{i},{j}]=");
                    a[i, j] = int.Parse(Console.ReadLine());
                }

        }
        static void XuatMang(int[,] a)
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
        static int[,] NhapMang2()
        {
            int[,] b;
            Console.Write("Nhap so dong:");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot:");
            int cols = int.Parse(Console.ReadLine());
            b = new int[rows, cols];
            for (int i = 0; i < b.GetLength(0); i++)

                for (int j = 0; j < b.GetLength(1); j++)
                {
                    Console.Write($"b[{i},{j}]=");
                    b[i, j] = int.Parse(Console.ReadLine());
                }
            return b;
        }
        static void NhapMang3(int[,] c)
        {
            for (int i = 0; i < c.GetLength(0); i++)

                for (int j = 0; j < c.GetLength(1); j++)
                {
                    Console.Write($"c[{i},{j}]=");
                    c[i, j] = int.Parse(Console.ReadLine());
                }
        }
    }
}

