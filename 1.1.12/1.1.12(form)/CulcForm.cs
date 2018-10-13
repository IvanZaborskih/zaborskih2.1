using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLib;
 
namespace _1._1._12_form_
{
    public partial class CulcForm : Form
    {
        public CulcForm()
        {
            InitializeComponent();
        }
        
        public Fraction fract1;
        public Fraction fract2;
        
        void ZeroTest(int denX, int denY, int numX, int numY)
        {
            if (denX == 0 || denY == 0 || numX == 0 || numY == 0)
                throw new FormatException();
        }

        public bool Write()
        {
            try
            {
                Number num1 = new Number(Convert.ToInt32(inputFirstNum.Text));
                Number den1 = new Number(Convert.ToInt32(inputFirstDen.Text));
                Number num2 = new Number(Convert.ToInt32(inputSecondNum.Text));
                Number den2 = new Number(Convert.ToInt32(inputSecondDen.Text));
                ZeroTest(num1.Value , num2.Value, den1.Value, den2.Value);
                fract1 = new Fraction(num1, den1);
                fract2 = new Fraction(num2, den2);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Проверьте правильность введенных данных!");
                return false;
            }
        }
        
        private void Mult_Click(object sender, EventArgs e)
        {
            if (Write())
            {
                Operation operation = new Operation();
                Fraction res = operation.Mult(fract1, fract2);
                multNum.Text = Convert.ToString(res.Numerator.Value);
                multDen.Text = Convert.ToString(res.Denomerator.Value);
            }
        }

        private void divBut_Click(object sender, EventArgs e)
        {
            if (Write())
            {
                Operation operation = new Operation();
                Fraction res = operation.Div(fract1, fract2);
                divNum.Text = Convert.ToString(res.Numerator.Value);
                divDen.Text = Convert.ToString(res.Denomerator.Value);
            }
        }

        private void sumBut_Click(object sender, EventArgs e)
        {
            if (Write())
            {
                Operation operation = new Operation();
                Fraction res = operation.Sum(fract1, fract2);
                sumNum.Text = Convert.ToString(res.Numerator.Value);
                sumDen.Text = Convert.ToString(res.Denomerator.Value);
            }
        }

        private void subBut_Click(object sender, EventArgs e)
        {
            if (Write())
            {
                Operation operation = new Operation();
                Fraction res = operation.Sub(fract1, fract2);
                subNum.Text = Convert.ToString(res.Numerator.Value);
                subDen.Text = Convert.ToString(res.Denomerator.Value);
            }
        }
    }
}
