using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a;
            NhapMang(out a);
            int min;
            int max;
            TimMin(a, 0, a.Length - 1, out min);
            Console.WriteLine(min);
            TimMax(a, 0, a.Length - 1, out max);
            Console.WriteLine(max);
        }
        static void NhapMang(out int[] a)
        {
            int n = int.Parse(Console.ReadLine());
            a = new int[n];
            string[] line = Console.ReadLine().Split();
            for (int i = 0; i < a.Length; i++)
                a[i] = int.Parse(line[i]);
        }
        static void TimMin(int[] a, int dau, int cuoi, out int min)
        {
            int minLeft, minRight; if (dau == cuoi) min = a[dau];
            else
            {
                int k = (dau + cuoi) / 2;
                TimMin(a, dau, k, out minLeft);
                TimMin(a, k + 1, cuoi, out minRight);
                if (minLeft < minRight) min = minLeft;
                else min = minRight;
            }
        }
        static void TimMax(int[] a, int dau, int cuoi, out int max)
        {
            int maxLeft, maxRight; if (dau == cuoi) max = a[dau];
            else
            {
                int k = (dau + cuoi) / 2;
                TimMax(a, dau, k, out maxLeft);
                TimMax(a, k + 1, cuoi, out maxRight);
                if (maxLeft > maxRight) max = maxLeft;
                else max = maxRight;
            }
        }

    }
}
