using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi3._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap n:");
            int n = int.Parse(Console.ReadLine());
            string kq = "";
            Console.Write(np(n,kq));
        }
        static string np(int n, string kq)
        {
            if (n == 0) return kq;
            else
            {
                kq = n % 2 + kq;
            }
            return np(n / 2, kq);
        }
    }
}
