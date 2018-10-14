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
            double a;
            while (!double.TryParse(inputWeight.Text, out a) || !double.TryParse(inputCutQuality.Text, out a) || inputName.Text == "")
            {
                MessageBox.Show("Проверьте правильность введенных данных!");
                return false;
            }
            return true;
        }

        public bool WriteColor()
        {
            int a;
            while (!int.TryParse(inputColor.Text, out a) || a > 4 || a < 1)
            {
                MessageBox.Show("Введите цвета из списка!");
                return false;
            }
            return true;
        }

        public void getPriceButton_Click(object sender, EventArgs e)
        {
            diamond = new Diamond();
            if (Write() && WriteColor())
            {
                diamond.Name = inputName.Text;
                diamond.Weight = Convert.ToDouble(inputWeight.Text);
                diamond.CutQuality = Convert.ToDouble(inputCutQuality.Text);
                int colorNumber = Convert.ToInt32(inputColor.Text);

                ColorNum color = new ColorNum();
                if (colorNumber == 1)
                {
                    color = ColorNum.Blue;
                }
                else if (colorNumber == 2)
                {
                    color = ColorNum.Yellow;
                }
                else
                    color = ColorNum.None;
                diamond = new KindOfDiamond(diamond.Name, diamond.Weight, diamond.CutQuality, diamond.Cost(), color);
                priceOutput.Text = Convert.ToString(diamond.Cost());
            }
        }
    }
}
