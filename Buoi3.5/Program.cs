using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi3._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap n:");
            int n = int.Parse(Console.ReadLine());
            Console.Write(fibo(n));
        }
        static int fibo(int n)
        {
            if (n == 1 || n == 2) return 1;
            else return fibo(n - 1) + fibo((n - 2));
        }

    }
}
