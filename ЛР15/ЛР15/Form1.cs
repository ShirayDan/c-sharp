using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЛР15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblRes1.Text = "";
            lbl2Res1.Text = "";
            lbl2Res2.Text = "";
            lbl3Res.Text = "";
            lbl4Res.Text = "";
            lbl5Res.Text = "";
            lbl6Res.Text = "";
            lbl7Res.Text = "";
            

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textX.Text);
            double y = Convert.ToDouble(textY.Text);
            double res = Math.Pow(3, x) - 4 * x + (y - Math.Sqrt(Math.Abs(x)));
            lblRes1.Text = res.ToString();
        }

        private void textX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                
                return;
            }
            if (e.KeyChar == '.')
            {
                
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (textX.Text.IndexOf(',') != -1)
                {
                    
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                
                if (e.KeyChar == (char)Keys.Enter)

                    btn1.Focus();
                return;
            }
            
            e.Handled = true;
        }

        private void textY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {

                return;
            }
            if (e.KeyChar == '.')
            {

                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (textY.Text.IndexOf(',') != -1)
                {

                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {

                if (e.KeyChar == (char)Keys.Enter)

                    btn1.Focus();
                return;
            }

            e.Handled = true;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            
            double r = Convert.ToDouble(textR.Text);

            double len = 2 * Math.PI * r;
            double area =  Math.PI * Math.Pow(r,2);
            lbl2Res1.Text = area.ToString();
            lbl2Res2.Text = len.ToString();
        }

        private void textR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {

                return;
            }
            if (e.KeyChar == '.')
            {

                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (textY.Text.IndexOf(',') != -1)
                {

                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {

                if (e.KeyChar == (char)Keys.Enter)

                    btn2.Focus();
                return;
            }

            e.Handled = true;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textA.Text);
            double b = Convert.ToDouble(textB.Text);
            double c = Convert.ToDouble(textC.Text);
            double d = Convert.ToDouble(textD.Text);

            double max = Math.Max(Math.Min(a, b), Math.Min(c, d));
            lbl4Res.Text = max.ToString();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textN.Text);
            int last = n % 10;
            n /= 10;
            int num = n;
            int min = 9;
            while(num > 0)
            {
                int digit = num % 10;
                if(digit < min)
                {
                    min = digit;
                }
                num /= 10;
            }
            if(min > last)
            {
                min = last;
            }
            int res = n * 10 + min;
           lbl5Res.Text = res.ToString();
        }

        private void textA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {

                return;
            }
            if (e.KeyChar == '.')
            {

                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (textA.Text.IndexOf(',') != -1)
                {

                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {

                if (e.KeyChar == (char)Keys.Enter)

                    btn4.Focus();
                return;
            }

            e.Handled = true;
        }

        private void textB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {

                return;
            }
            if (e.KeyChar == '.')
            {

                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (textB.Text.IndexOf(',') != -1)
                {

                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {

                if (e.KeyChar == (char)Keys.Enter)

                    btn4.Focus();
                return;
            }

            e.Handled = true;
        }

        private void textC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {

                return;
            }
            if (e.KeyChar == '.')
            {

                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (textC.Text.IndexOf(',') != -1)
                {

                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {

                if (e.KeyChar == (char)Keys.Enter)

                    btn4.Focus();
                return;
            }

            e.Handled = true;
        }

        private void textD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {

                return;
            }
            if (e.KeyChar == '.')
            {

                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (textD.Text.IndexOf(',') != -1)
                {

                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {

                if (e.KeyChar == (char)Keys.Enter)

                    btn4.Focus();
                return;
            }

            e.Handled = true;
        }

        private void textN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {

                return;
            }
            if (e.KeyChar == '.')
            {

                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (textN.Text.IndexOf(',') != -1)
                {

                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {

                if (e.KeyChar == (char)Keys.Enter)

                    btn5.Focus();
                return;
            }

            e.Handled = true;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            string str = text6.Text;
            string substr = "";
            for(int i = 0; i < str.Length; i++)
            {
                if(str[i] == '0')
                {
                    substr += str[i];
                }
            }
            for(int i = substr.Length; i < str.Length; i++)
            {
                substr += '1';
            }
            lbl6Res.Text = substr;
        }

        private void text6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '1'))
            {

                return;
            }
            if (Char.IsControl(e.KeyChar))
            {

                if (e.KeyChar == (char)Keys.Enter)

                    btn6.Focus();
                return;
            }

            e.Handled = true;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            string str = text7.Text;
            double half = Math.Floor((double)str.Length / 2);
            string substr = "";
            for(int i = 0; i < half; i++)
            {
                if(str[i] == ':')
                {
                    substr += ".";
                    continue;
                }
                substr += str[i];
            }
            
            for (int i = (int)half; i < str.Length; i++)
            {
                if (str[i] == '!')
                {
                    substr += ".";
                    continue;
                }
                substr += str[i];
            }
            lbl7Res.Text = substr;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            int x1 = Convert.ToInt32(text3X1.Text); 
            int x2 = Convert.ToInt32(text3X2.Text); 
            int y1 = Convert.ToInt32(text3Y1.Text);
            int y2 = Convert.ToInt32(text3Y2.Text);
            lbl3Res.Text = "false";
            if (x1 > 0 && x1 < 9 && x2 > 0 && x2 < 9 && y1 > 0 && y1 < 9 && y2 > 0 && y2 < 9)
            {
                if(x1 + 2 == x2 && y1 + 1 == y2)
                {
                    lbl3Res.Text = "true";
                }
                if (x1 + 2 == x2 && y1 - 1 == y2)
                {
                    lbl3Res.Text = "true";
                }
                if (x1 + 1 == x2 && y1 - 2 == y2)
                {
                    lbl3Res.Text = "true";
                }
                if (x1 + 1 == x2 && y1 + 2 == y2)
                {
                    lbl3Res.Text = "true";
                }
                if (x1 - 1 == x2 && y1 + 2 == y2)
                {
                    lbl3Res.Text = "true";
                }
                if (x1 - 1 == x2 && y1 - 2 == y2)
                {
                    lbl3Res.Text = "true";
                }
                if (x1 - 2 == x2 && y1 + 1 == y2)
                {
                    lbl3Res.Text = "true";
                }
                if (x1 - 2 == x2 && y1 - 1 == y2)
                {
                    lbl3Res.Text = "true";
                }
            }
        }

    }
}
