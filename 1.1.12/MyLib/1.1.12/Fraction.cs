using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class Fraction
    {
        public Number Numerator { get; set; }
        public Number Denomerator { get; set; }
        
        public Fraction(Number num, Number den)
        {
            this.Numerator = num;
            this.Denomerator = den;
        }

        public void Reduction()
        {
            int a = Numerator.Value;
            int b = Denomerator.Value;
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            Numerator.Value = Numerator.Value / a;
            Denomerator.Value = Denomerator.Value / a;
        }
    }
        
}
