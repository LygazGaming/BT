using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi8._2
{
    internal class MixedFraction:Fraction
    {
        public MixedFraction(int wholePart, int numerator, int denominator) : base(wholePart * denominator + numerator, denominator)
        {

        }
        public MixedFraction(Fraction p) : base(p)
        {
        }
        public override string ToString()
        {
            return $"{Numerator % Denominator}[{Numerator % Denominator}/{Denominator}]";
        }
        public static MixedFraction  operator  +(MixedFraction p1, MixedFraction p2)
        {
            return new MixedFraction(p1.Add(p2));
        }
        public static MixedFraction operator -(MixedFraction p1, MixedFraction p2)
        {
            return new MixedFraction(p1.Subtract(p2));
        }
        public static MixedFraction operator *(MixedFraction p1, MixedFraction p2)
        {
            return new MixedFraction(p1.Multiply(p2));
        }
        public static MixedFraction operator /(MixedFraction p1, MixedFraction p2)
        {
            return new MixedFraction(p1.Divide(p2));
        }
        public static bool operator ==(MixedFraction p1, MixedFraction p2)
        {
            return p1.Numerator*p2.Denominator==p2.Numerator*p1.Denominator;
        }
        public static bool operator !=(MixedFraction p1, MixedFraction p2)
        {
            return !(p1 == p2);
        }
        public static bool operator <(MixedFraction p1, MixedFraction p2)
        {
            return p1.Numerator * p2.Denominator < p2.Numerator * p1.Denominator;
        }
        public static bool operator >(MixedFraction p1, MixedFraction p2)
        {
            return p1.Numerator * p2.Denominator > p2.Numerator * p1.Denominator;
        }
        public static bool operator <=(MixedFraction p1, MixedFraction p2)
        {
            return !(p1>p2);
        }
        public static bool operator >=(MixedFraction p1, MixedFraction p2)
        {
            return !(p1<p2);
        }
    }
}
