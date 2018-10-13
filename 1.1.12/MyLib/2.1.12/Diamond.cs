using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib._2._1._12
{
    public class Diamond
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public double CutQuality { get; set; }
        public double Price { get; set; }
        
        public virtual double Cost()
        {
            return Price = 0.4 * Weight + 0.6 * CutQuality;
        }
    }

    public class KindOfDiamond : Diamond
    {
        public string Color { get; set; }

        public KindOfDiamond(string name, double weight, double cutQuality, double price, string color)
        {
            Name = name;
            Weight = weight;
            CutQuality = cutQuality;
            Price = price;
            Color = color;
        }
        
        public override double Cost()
        {
            if (Color == "Голубой")
            {
                return Price = (0.4 * Weight + 0.6 * CutQuality) + 1;
            }
            else if (Color == "Желтый")
            {
                return Price = (0.4 * Weight + 0.6 * CutQuality) - 0.5;
            }
            else
                return Price;
        }
    }
}
