using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            n = int.Parse(s[0]);
            k = int.Parse(s[1]);
            x = new int[k + 1];
            Try(1);
        }
        static int n, k;
        static int[] x;
        static void Try(int i)
        {
            if (i > k) xuat();
            else
            {
                for (int j = 1; j <= n; j++)
                {
                    x[i] = j;
                    Try(i + 1);
                }
            }
        }
        static void xuat()
        {
            for (int i = 1; i < k; i++)
                Console.Write(x[i] + " ");
            Console.Write(x[k] + " ");
            Console.WriteLine();
        }

    }
}
