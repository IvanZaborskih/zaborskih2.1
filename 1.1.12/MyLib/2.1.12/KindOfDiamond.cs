using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib._2._1._12
{
    public class KindOfDiamond : Diamond
    {
        public ColorNum Color { get; set; }

        public KindOfDiamond(string name, double weight, double cutQuality, double price, ColorNum color)
        {
            Name = name;
            Weight = weight;
            CutQuality = cutQuality;
            Price = price;
            Color = color;
        }

        public override double Cost()
        {
            if (Color == ColorNum.Blue)
            {
                return Price = (0.4 * Weight + 0.6 * CutQuality) + 1;
            }
            else if (Color == ColorNum.Yellow)
            {
                return Price = (0.4 * Weight + 0.6 * CutQuality) - 0.5;
            }
            else
                return Price;
        }
    }

    public enum ColorNum
    {
        Blue,
        Yellow,
        Red,
        White,
        None
    }
}
