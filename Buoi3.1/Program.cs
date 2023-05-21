using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap n :");
            int n = int.Parse(Console.ReadLine());
            Console.Write($"{n}!="+gt(n));

        }
        static int gt(int n)
        {
            if (n <= 1) return 1;
            else return (n * gt(n - 1));
        }
    }
}

