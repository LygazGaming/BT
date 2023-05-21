using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] a;
            Nhap(out a);
            Xuat(a);
        }
        static void Nhap(out int[,] intArr)
        {
            int n;
            do
            {
                Console.Write("Nhap n:");
                n = int.Parse(Console.ReadLine());
            } while (n <= 1 || n >= 4);
            intArr = new int[n, n];
            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c < n; c++)
                {
                    Console.Write($"a[{r},{c}]= ");
                    intArr[r, c] = int.Parse(Console.ReadLine());
                }
            }
        }
        static void Xuat(int[,]a)
        {
            for (int r = 0; r < a.GetLength(0); r++)
            {
                for (int c = 0; c < a.GetLength(1); c++)
                {
                    Console.Write(a[r,c]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
