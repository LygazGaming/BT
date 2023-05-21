using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi7._2
{
    internal class MixedFraction:Fraction
    {
        public MixedFraction(int wholePart, int numerator, int denominator) : base(wholePart * denominator + numerator, denominator)
        {

        }
        public MixedFraction(Fraction p) : base(p.Numerator,p.Denominator)
        {
        }
        public override string ToString()
        {
            return $"{Numerator % Denominator}[{Numerator % Denominator}/{Denominator}]";
        }
    }
}
