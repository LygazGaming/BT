using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi4._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string a = "A";
            string b = "B";
            string c = "C";
            THN(n, a, c, b);
        }
        static void THN(int n, string a, string c, string b)
        {
            if (n == 1)
                Console.WriteLine($"Di chuyen 1 dia tu cot {a} -> {c}");
            else
            {
                THN(n - 1, a, b, c);
                THN(1, a, c, b);
                THN(n - 1, b, c, a);
            }
        }

    }
}
