using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class Operation
    {
        public Fraction Mult(Fraction frac1, Fraction frac2)
        {
            Number num = new Number();
            Number den = new Number();
            num.Value = frac1.Numerator.Value * frac2.Numerator.Value;
            den.Value = frac1.Denomerator.Value * frac2.Denomerator.Value;
            Fraction result = new Fraction(num, den);
            result.Reduction();
            return result;
        }

        public Fraction Div(Fraction frac1, Fraction frac2)
        {
            Number num = new Number();
            Number den = new Number();
            num.Value = frac1.Numerator.Value * frac2.Denomerator.Value;
            den.Value = frac1.Denomerator.Value * frac2.Numerator.Value;
            Fraction result = new Fraction(num, den);
            result.Reduction();
            return result;
        }

        public Fraction Sum(Fraction frac1, Fraction frac2)
        {
            Number num = new Number();
            Number den = new Number();
            num.Value = frac1.Numerator.Value * frac2.Denomerator.Value + frac2.Numerator.Value * frac1.Denomerator.Value;
            den.Value = frac1.Denomerator.Value * frac2.Denomerator.Value;
            Fraction result = new Fraction(num, den);
            result.Reduction();
            return result;
        }

        public Fraction Sub(Fraction frac1, Fraction frac2)
        {
            Number num = new Number();
            Number den = new Number();
            num.Value = frac1.Numerator.Value * frac2.Denomerator.Value - frac2.Numerator.Value * frac1.Denomerator.Value;
            den.Value = frac1.Denomerator.Value * frac2.Denomerator.Value;
            Fraction result = new Fraction(num, den);
            result.Reduction();
            return result;
        }
    }
}

