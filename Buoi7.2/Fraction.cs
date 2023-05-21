using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi7._2
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
            Simplify() ;
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
        public Fraction Add(Fraction p)
        {
            int maumoi = p.denominator * denominator;
            int tumoi = p.denominator * numerator + p.numerator * denominator;
            Fraction res = new Fraction(tumoi, maumoi);
            res.Simplify();
            return res;
        }
        public Fraction Subtract(Fraction p)
        {
            int maumoi = p.denominator * denominator;
            int tumoi = p.denominator * numerator - p.numerator * denominator;
            Fraction res = new Fraction(tumoi, maumoi);
            res.Simplify();
            return res;
        }
        public Fraction Multiply(Fraction p)
        {
            int maumoi = p.denominator * denominator;
            int tumoi = p.numerator * numerator;
            Fraction res = new Fraction(tumoi, maumoi);
            res.Simplify();
            return res;
        }
        public Fraction Divide(Fraction p)
        {
            int tumoi = p.denominator * numerator;
            int maumoi = p.numerator * denominator;
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
