using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi7._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fraction p2 = new Fraction(2);
            Fraction p3 = new Fraction(2, 3);
            Fraction p4 = new Fraction(3, 4);
            Console.WriteLine("Phan so thu 2:" + p2.ToString());
            Console.WriteLine("Phan so thu 3:" + p3.ToString());
            Console.WriteLine("Phan so thu 4:" + p4.ToString());
            Fraction psum = p3.Add(p4);
            Fraction psub = p3.Subtract(p4);
            Fraction pmul = p3.Multiply(p4);
            Fraction pdiv = p3.Divide(p4);
            Console.WriteLine($"{p3.ToString()} + {p4.ToString()} = {psum.ToString()} = {psum.ToDecimal()}");
            Console.WriteLine($"{p3.ToString()} - {p4.ToString()} = {psub.ToString()} = {psub.ToDecimal()}");
            Console.WriteLine($"{p3.ToString()} * {p4.ToString()} = {pmul.ToString()} = {pmul.ToDecimal()}");
            Console.WriteLine($"{p3.ToString()} : {p4.ToString()} = {pdiv.ToString()} = {pdiv.ToDecimal()}");
            MixedFraction pp = new MixedFraction(1, 2, 7);
            Console.WriteLine(pp.ToString());
        }
    }
}
