using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi9._2
{
    internal class Fraction
    {
        private int numerator;
        private int denominator;
        public int Numerator
        {
            get { return numerator; }
            set { numerator = value; }
        }
        public int Denominator
        {
            get { return denominator; }
            set
            {
                if (value == 0)
                {
                    Console.WriteLine("Mau so phai khac 0,Gia tri mac dinh la 1");
                    denominator = 1;
                }
                else denominator = value;
            }
        }
        public Fraction()
        {
            numerator = 0;
            denominator = 1;
            Simplify();
        }
        public Fraction(int numerator, int denominator)
        {
            this.numerator = numerator;
            if (denominator == 0)
            {
                Console.WriteLine("Mau so phai khac 0,Gia tri mac dinh la 1");
                denominator = 1;
            }
            else this.denominator = denominator;
            Simplify();
        }
        public Fraction(int numerator)
        {
            this.numerator = numerator;
            this.denominator = 1;
            Simplify();
        }
        public virtual void Input()
        {
            Console.Write("Enater numerator: ");
            numerator = int.Parse(Console.ReadLine());
            Console.Write("Enter denominator: ");
            int d;
            while (true)
            {
                d = int.Parse(Console.ReadLine());
                if (d != 0)
                {
                    break;
                }
                Console.WriteLine("Mau so phai khac 0.Vui long thu lai");
            }
            denominator = d;
            Simplify();
        }
        private void Simplify()
        {
            int ucln = GCD(numerator, denominator);
            numerator = numerator / ucln;
            denominator = denominator / ucln;
        }
        private int GCD(int tuso, int mauso)
        {
            tuso = Math.Abs(tuso);
            mauso = Math.Abs(mauso);
            if (tuso == 0)
                return mauso;
            return GCD(mauso % tuso, tuso);
        }
        public double ToDecimal()
        {
            return ((Double)numerator / denominator);
        }
        public static Fraction Add(Fraction p1, Fraction p2)
        {
            int maumoi = p1.denominator * p2.denominator;
            int tumoi = p1.denominator * p2.numerator + p1.numerator * p2.denominator;
            Fraction res = new Fraction(tumoi, maumoi);
            res.Simplify();
            return res;
        }
        public static Fraction Subtract(Fraction p1, Fraction p2)
        {
            int maumoi = p1.denominator * p2.denominator;
            int tumoi = p1.denominator * p2.numerator - p1.numerator * p2.denominator;
            Fraction res = new Fraction(tumoi, maumoi);
            res.Simplify();
            return res;
        }
        public static Fraction Multiply(Fraction p1, Fraction p2)
        {
            int maumoi = p1.denominator * p2.denominator;
            int tumoi = p1.numerator * p2.numerator;
            Fraction res = new Fraction(tumoi, maumoi);
            res.Simplify();
            return res;
        }
        public static Fraction Divide(Fraction p1, Fraction p2)
        {
            int tumoi = p1.denominator * p2.numerator;
            int maumoi = p1.numerator * p2.denominator;
            Fraction res = new Fraction(tumoi, maumoi);
            res.Simplify();
            return res;
        }
        public virtual string ToString()
        {
            return $"{numerator}/{denominator}";
        }
    }
}
