using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap m:");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Nhap n:");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Uoc so chung lon nhat:"+UC(m, n));
        }
        static int UC(int m, int n)
        {
            if (n == 0) return m;
            else return UC(n, m % n);
        }
    }
}
