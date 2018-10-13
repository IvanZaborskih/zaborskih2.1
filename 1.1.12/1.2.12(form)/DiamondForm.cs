using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLib._2._1._12;

namespace _1._2._12_form_
{
    public partial class DiamondForm : Form
    {
        public DiamondForm()
        {
            InitializeComponent();
        }

        Diamond diamond;

        public bool Write()
        {
            try
            {
                diamond = new Diamond();
                diamond.Name = inputName.Text;
                diamond.Weight = Convert.ToDouble(inputWeight.Text);
                diamond.CutQuality = Convert.ToDouble(inputCutQuality.Text);
                return true;
            }
            catch
            {
                MessageBox.Show("Проверьте правильность введенных данных!");
                return false;
            }
        }

        public bool WriteColor()
        {
            try
            {
                int colorName = Convert.ToInt32(inputColor.Text);
                if (colorName > 0 && colorName < 5)
                {
                    return true;
                }
                else throw new FormatException();
            }
            catch
            {
                MessageBox.Show("Введите цвета из списка!");
                return false;
            }
        }

        public void getPriceButton_Click(object sender, EventArgs e)
        {
            diamond = new Diamond();
            if (Write() && WriteColor())
            {
                int colorName = Convert.ToInt32(inputColor.Text);
                KindOfDiamond kindOfDiamond = new KindOfDiamond(diamond.Name, diamond.Weight, diamond.CutQuality, diamond.Cost(), colorName);
                diamond = kindOfDiamond;
                priceOutput.Text = Convert.ToString(diamond.Cost());
            }
        }
    }
}
