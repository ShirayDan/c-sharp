using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Реалізувати alert при додаванні двох чисел наприклад 255 + 255
        LongNum num1 = new LongNum();
        LongNum num2 = new LongNum();
        private void Form1_Load(object sender, EventArgs e)
        {
            res.Text = "";
            alert11.Text = "";
            alert12.Text = "";
            alert21.Text = "";
            alert22.Text = "";
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
               
            if (Convert.ToInt32(Big1.Text) < 256 && Convert.ToInt32(Big1.Text) > -256)
            {
                alert11.Text = "";
                num1.setNumLeft(Convert.ToInt32(Big1.Text));
                
            }
            else
            {
                alert11.Text = "Enter num from -255 to 255";
                return;
            }
            if (Convert.ToInt32(Small1.Text) < 256 && Convert.ToInt32(Small1.Text) > -256)
            {
                alert21.Text = "";
                num1.setNumRight(Convert.ToInt32(Small1.Text));

            }
            else
            {
                alert21.Text = "Enter num from -255 to 255";
                return;
            }
            if (Convert.ToInt32(Big2.Text) < 256 && Convert.ToInt32(Big2.Text) > -256)
            {
                alert12.Text = "";
                num2.setNumLeft(Convert.ToInt32(Big2.Text));

            }
            else
            {
                alert12.Text = "Enter num from -255 to 255";
                return;
            }
            if (Convert.ToInt32(Small2.Text) < 256 && Convert.ToInt32(Small2.Text) > -256)
            {
                alert22.Text = "";
                num2.setNumRight(Convert.ToInt32(Small2.Text));

            }
            else
            {
                alert22.Text = "Enter num from -255 to 255";
                return;
            }
            


            num1.addNums(num2);
            if (num1.getNumLeft() > 255)
            {
                res.Text = "Enter less numbers";
                return;
            }
             res.Text = num1.getNumLeft() + " " + num1.getNumRight();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(Big1.Text) < 256 && Convert.ToInt32(Big1.Text) > -256)
            {
                alert11.Text = "";
                num1.setNumLeft(Convert.ToInt32(Big1.Text));

            }
            else
            {
                alert11.Text = "Enter num from -255 to 255";
                return;
            }
            if (Convert.ToInt32(Small1.Text) < 256 && Convert.ToInt32(Small1.Text) > -256)
            {
                alert21.Text = "";
                num1.setNumRight(Convert.ToInt32(Small1.Text));

            }
            else
            {
                alert21.Text = "Enter num from -255 to 255";
                return;
            }
            if (Convert.ToInt32(Big2.Text) < 256 && Convert.ToInt32(Big2.Text) > -256)
            {
                alert12.Text = "";
                num2.setNumLeft(Convert.ToInt32(Big2.Text));

            }
            else
            {
                alert12.Text = "Enter num from -255 to 255";
                return;
            }
            if (Convert.ToInt32(Small2.Text) < 256 && Convert.ToInt32(Small2.Text) > -256)
            {
                alert22.Text = "";
                num2.setNumRight(Convert.ToInt32(Small2.Text));

            }
            else
            {
                alert22.Text = "Enter num from -255 to 255";
                return;
            }

            num1.minusNums(num2);
            if (num1.getNumLeft() < -255)
            {
                res.Text = "Enter bigger numbers";
                return;
            }
            res.Text = num1.getNumLeft() + " " + num1.getNumRight();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(Big1.Text) < 256 && Convert.ToInt32(Big1.Text) > -256)
            {
                alert11.Text = "";
                num1.setNumLeft(Convert.ToInt32(Big1.Text));

            }
            else
            {
                alert11.Text = "Enter num from -255 to 255";
                return;
            }
            if (Convert.ToInt32(Small1.Text) < 256 && Convert.ToInt32(Small1.Text) > -256)
            {
                alert21.Text = "";
                num1.setNumRight(Convert.ToInt32(Small1.Text));

            }
            else
            {
                alert21.Text = "Enter num from -255 to 255";
                return;
            }
            if (Convert.ToInt32(Big2.Text) < 256 && Convert.ToInt32(Big2.Text) > -256)
            {
                alert12.Text = "";
                num2.setNumLeft(Convert.ToInt32(Big2.Text));

            }
            else
            {
                alert12.Text = "Enter num from -255 to 255";
                return;
            }
            if (Convert.ToInt32(Small2.Text) < 256 && Convert.ToInt32(Small2.Text) > -256)
            {
                alert22.Text = "";
                num2.setNumRight(Convert.ToInt32(Small2.Text));

            }
            else
            {
                alert22.Text = "Enter num from -255 to 255";
                return;
            }
            num1.mulNums(num2);
            if (num1.getNumLeft() > 255)
            {
                res.Text = "Enter less numbers";
                return;
            }else if(num1.getNumLeft() < -255)
            {
                res.Text = "Enter bigger numbers";
                return;
            }
            res.Text = num1.getNumLeft() + " " + num1.getNumRight();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(Big1.Text) < 256 && Convert.ToInt32(Big1.Text) > -256)
            {
                alert11.Text = "";
                num1.setNumLeft(Convert.ToInt32(Big1.Text));

            }
            else
            {
                alert11.Text = "Enter num from -255 to 255";
                return;
            }
            if (Convert.ToInt32(Small1.Text) < 256 && Convert.ToInt32(Small1.Text) > -256)
            {
                alert21.Text = "";
                num1.setNumRight(Convert.ToInt32(Small1.Text));

            }
            else
            {
                alert21.Text = "Enter num from -255 to 255";
                return;
            }
            if (Convert.ToInt32(Big2.Text) < 256 && Convert.ToInt32(Big2.Text) > -256)
            {
                alert12.Text = "";
                num2.setNumLeft(Convert.ToInt32(Big2.Text));

            }
            else
            {
                alert12.Text = "Enter num from -255 to 255";
                return;
            }
            if (Convert.ToInt32(Small2.Text) < 256 && Convert.ToInt32(Small2.Text) > -256)
            {
                alert22.Text = "";
                num2.setNumRight(Convert.ToInt32(Small2.Text));

            }
            else
            {
                alert22.Text = "Enter num from -255 to 255";
                return;
            }
            int rest = num1.divideNums(num2);
            if (num1.getNumLeft() < -255)
            {
                res.Text = "Enter bigger numbers";
                return;
            }
            res.Text = num1.getNumLeft() + " " + num1.getNumRight() + " Остача " + rest; 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(Big1.Text) < 256 && Convert.ToInt32(Big1.Text) > -256)
            {
                alert11.Text = "";
                num1.setNumLeft(Convert.ToInt32(Big1.Text));

            }
            else
            {
                alert11.Text = "Enter num from -255 to 255";
                return;
            }
            if (Convert.ToInt32(Small1.Text) < 256 && Convert.ToInt32(Small1.Text) > -256)
            {
                alert21.Text = "";
                num1.setNumRight(Convert.ToInt32(Small1.Text));

            }
            else
            {
                alert21.Text = "Enter num from -255 to 255";
                return;
            }
            if (Convert.ToInt32(Big2.Text) < 256 && Convert.ToInt32(Big2.Text) > -256)
            {
                alert12.Text = "";
                num2.setNumLeft(Convert.ToInt32(Big2.Text));

            }
            else
            {
                alert12.Text = "Enter num from -255 to 255";
                return;
            }
            if (Convert.ToInt32(Small2.Text) < 256 && Convert.ToInt32(Small2.Text) > -256)
            {
                alert22.Text = "";
                num2.setNumRight(Convert.ToInt32(Small2.Text));

            }
            else
            {
                alert22.Text = "Enter num from -255 to 255";
                return;
            }

            res.Text = num1.compare(num2);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(Big1.Text) < 256 && Convert.ToInt32(Big1.Text) > -256)
            {
                alert11.Text = "";
                num1.setNumLeft(Convert.ToInt32(Big1.Text));

            }
            else
            {
                alert11.Text = "Enter num from -255 to 255";
                return;
            }
            if (Convert.ToInt32(Small1.Text) < 256 && Convert.ToInt32(Small1.Text) > -256)
            {
                alert21.Text = "";
                num1.setNumRight(Convert.ToInt32(Small1.Text));

            }
            else
            {
                alert21.Text = "Enter num from -255 to 255";
                return;
            }
            if (Convert.ToInt32(Big2.Text) < 256 && Convert.ToInt32(Big2.Text) > -256)
            {
                alert12.Text = "";
                num2.setNumLeft(Convert.ToInt32(Big2.Text));

            }
            else
            {
                alert12.Text = "Enter num from -255 to 255";
                return;
            }
            if (Convert.ToInt32(Small2.Text) < 256 && Convert.ToInt32(Small2.Text) > -256)
            {
                alert22.Text = "";
                num2.setNumRight(Convert.ToInt32(Small2.Text));

            }
            else
            {
                alert22.Text = "Enter num from -255 to 255";
                return;
            }
            if (num1.compareMore(num2))
            {
                res.Text = "Більше рівне";
            }
            else
            {
                res.Text = "Менше рівне";
            }
            
            

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(Big1.Text) < 256 && Convert.ToInt32(Big1.Text) > -256)
            {
                alert11.Text = "";
                num1.setNumLeft(Convert.ToInt32(Big1.Text));

            }
            else
            {
                alert11.Text = "Enter num from -255 to 255";
                return;
            }
            if (Convert.ToInt32(Small1.Text) < 256 && Convert.ToInt32(Small1.Text) > -256)
            {
                alert21.Text = "";
                num1.setNumRight(Convert.ToInt32(Small1.Text));

            }
            else
            {
                alert21.Text = "Enter num from -255 to 255";
                return;
            }
            if (Convert.ToInt32(Big2.Text) < 256 && Convert.ToInt32(Big2.Text) > -256)
            {
                alert12.Text = "";
                num2.setNumLeft(Convert.ToInt32(Big2.Text));

            }
            else
            {
                alert12.Text = "Enter num from -255 to 255";
                return;
            }
            if (Convert.ToInt32(Small2.Text) < 256 && Convert.ToInt32(Small2.Text) > -256)
            {
                alert22.Text = "";
                num2.setNumRight(Convert.ToInt32(Small2.Text));

            }
            else
            {
                alert22.Text = "Enter num from -255 to 255";
                return;
            }
            if (num1.equal(num2))
            {
                res.Text = "Рівне";
            }
            else
            {
                res.Text = "Не рівне";
            }
            
        }

        private void Big1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {

                return;
            }
            if (Char.IsControl(e.KeyChar))
            {

                if (e.KeyChar == (char)Keys.Back)


                    return;
            }

            e.Handled = true;
        }

        private void Big2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {

                return;
            }
            if (Char.IsControl(e.KeyChar))
            {

                if (e.KeyChar == (char)Keys.Back)

                return;
            }

            e.Handled = true;
        }

        private void Small1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {

                return;
            }
            if (Char.IsControl(e.KeyChar))
            {

                if (e.KeyChar == (char)Keys.Back)

                    return;
            }

            e.Handled = true;
        }

        private void Small2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {

                return;
            }
            if (Char.IsControl(e.KeyChar))
            {

                if (e.KeyChar == (char)Keys.Back)

                    return;
            }

            e.Handled = true;
        }
    }
}
