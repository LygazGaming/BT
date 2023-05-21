using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi5._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            it();
            Try(0);
        }
        static int[] x;
        static bool[] cot;
        static bool[] cheochinh;
        static bool[] cheophu;
        static int dem;
        static void Try(int i)
        {
            if (i >= 8)
                xuat();
            else
            {
                for (int j = 0; j <= 7; j++)
                {
                    if (!cot[j] && !cheochinh[i - j + 7] && !cheophu[i + j])
                    {
                        x[i] = j;
                        cot[j] = true;
                        cheochinh[i - j + 7] = true;
                        cheophu[i + j] = true;
                        Try(i + 1);
                        cot[j] = false;
                        cheochinh[i - j + 7] = false;
                        cheophu[i + j] = false;
                    }
                }
            }
        }
        static void xuat()
        {
            Console.Write($"Cach {++dem}:");
            for (int i = 0; i <= 7; i++)
                Console.Write(x[i] + 1 + " ");
            Console.WriteLine();
        }
        static void it()
        {
            x = new int[8];
            cot = new bool[8];
            cheochinh = new bool[15];
            cheophu = new bool[15];
            for (int i = 0; i < cot.Length; i++)
            {
                cot[i] = false;
            }
            for (int i = 0; i < cheophu.Length; i++)
            {
                cheochinh[i] = false;
                cheophu[i] = false;
            }
            dem = 0;
        }

    }
}
