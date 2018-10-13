using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib._2._1._12
{
    public class KindOfDiamond : Diamond
    {
        public int Color { get; set; }

        public KindOfDiamond(string name, double weight, double cutQuality, double price, int color)
        {
            Name = name;
            Weight = weight;
            CutQuality = cutQuality;
            Price = price;
            Color = color;
        }

        public override double Cost()
        {
            if (Color == 1)
            {
                return Price = (0.4 * Weight + 0.6 * CutQuality) + 1;
            }
            else if (Color == 2)
            {
                return Price = (0.4 * Weight + 0.6 * CutQuality) - 0.5;
            }
            else
                return Price;
        }
    }
}
