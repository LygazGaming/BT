using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi9._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fraction p1 = new Fraction();
            p1.Input();
            Fraction p2 = new Fraction(3, 4);
            Fraction res = Fraction.Add(p1, p2);
            Console.WriteLine(res.ToString());
        }
    }
}
