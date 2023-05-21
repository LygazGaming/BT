using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap a:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap n:");
            int n = int.Parse(Console.ReadLine());
            Console.Write("${a} mu {n}"+lt(a, n));
        }
            static int lt(int a, int n)
            {
                if (n == 0) return 1;
                else if (n % 2 == 0 && n > 0) return lt(a, n / 2) * lt(a, n / 2);
                else return a * lt(a, n / 2) * lt(a, n / 2);
            }
    }
}
