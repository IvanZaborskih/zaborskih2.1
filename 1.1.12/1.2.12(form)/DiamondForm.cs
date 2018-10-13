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
            catch (Exception e)
            {
                MessageBox.Show("Проверьте правильность введенных данных!");
                return false;
            }
        }

        enum Color
        {
            Blue,
            Yellow,
            Red,
            White
        }

        public bool WriteColor()
        {
            try
            {
                string colorName = inputColor.Text;
                if (colorName == "Голубой" || colorName == "Желтый" || colorName == "Красный" || colorName == "Белый")
                {
                    return true;
                }
                else throw new FormatException();
            }
            catch (Exception e)
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
                string colorName = inputColor.Text;
                KindOfDiamond kindOfDiamond = new KindOfDiamond(diamond.Name, diamond.Weight, diamond.CutQuality, diamond.Cost(), colorName);
                diamond = kindOfDiamond;
                priceOutput.Text = Convert.ToString(diamond.Cost());
                
            }
        }
    }
}
