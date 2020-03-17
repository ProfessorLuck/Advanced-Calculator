using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Advanced_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string num1 = "";
        public string num2 = "";
        public decimal total = 0;
        public bool second_step = false;
        public bool add = false;
        public bool sub = false;
        public bool times = false;
        public bool div = false;
        public bool pow = false;
        public bool mod = false;
        private void plusButton_Click(object sender, EventArgs e)
        {
            second_step = true;
            add = true;
            outputLabel.Text = "";
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            second_step = true;
            sub = true;
            outputLabel.Text = "";
        }

        private void powButton_Click(object sender, EventArgs e)
        {
            second_step = true;
            pow = true;
            outputLabel.Text = "";
        }

        private void timesButton_Click(object sender, EventArgs e)
        {
            second_step = true;
            times = true;
            outputLabel.Text = "";
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            second_step = true;
            div = true;
            outputLabel.Text = "";
        }

        private void modulusButton_Click(object sender, EventArgs e)
        {
            second_step = true;
            mod = true;
            outputLabel.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(second_step == false)
            {
                num1 += "1";
                outputLabel.Text = num1.ToString();
            }
            else
            {
                num2 += "1";
                outputLabel.Text = num2.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(second_step == false)
            {
                num1 += "2";
                outputLabel.Text = num1.ToString();
            }
            else
            {
                num2 += "2";
                outputLabel.Text = num2.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(second_step == false)
            {
                num1 += "3";
                outputLabel.Text = num1.ToString();
            }
            else
            {
                num2 += "3";
                outputLabel.Text = num2.ToString();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(second_step == false)
            {
                num1 += "4";
                outputLabel.Text = num1.ToString();
            }
            else
            {
                num2 += "4";
                outputLabel.Text = num2.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(second_step == false)
            {
                num1 += "5";
                outputLabel.Text = num1.ToString();
            }
            else
            {
                num2 += "5";
                outputLabel.Text = num2.ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (second_step == false)
            {
                num1 += "6";
                outputLabel.Text = num1.ToString();
            }
            else
            {
                num2 += "6";
                outputLabel.Text = num2.ToString();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (second_step == false)
            {
                num1 += "7";
                outputLabel.Text = num1.ToString();
            }
            else
            {
                num2 += "7";
                outputLabel.Text = num2.ToString();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (second_step == false)
            {
                num1 += "8";
                outputLabel.Text = num1.ToString();
            }
            else
            {
                num2 += "8";
                outputLabel.Text = num2.ToString();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (second_step == false)
            {
                num1 += "9";
                outputLabel.Text = num1.ToString();
            }
            else
            {
                num2 += "9";
                outputLabel.Text = num2.ToString();
            }
        }
        private void button0_Click(object sender, EventArgs e)
        {
            if (second_step == false)
            {
                num1 += "0";
                outputLabel.Text = num1.ToString();
            }
            else
            {
                num2 += "0";
                outputLabel.Text = num2.ToString();
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            num1 = "";
            num2 = "";
            total = 0;
            outputLabel.Text = "";
            second_step = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (add == true)
            {
                total = Decimal.Parse(num1) + Decimal.Parse(num2);
                outputLabel.Text = total.ToString();
                num1 = total.ToString();
                num2 = "";
                second_step = false;
                add = false;
            }
            else if (sub == true)
            {
                total = Decimal.Parse(num1) - Decimal.Parse(num2);
                outputLabel.Text = total.ToString();
                num1 = total.ToString();
                num2 = "";
                second_step = false;
                sub = false;
            }
            else if (times == true)
            {
                total = Decimal.Parse(num1) * Decimal.Parse(num2);
                outputLabel.Text = total.ToString();
                num1 = total.ToString();
                num2 = "";
                second_step = false;
                times = false;
            }
            else if (div == true)
            {
                total = Decimal.Parse(num1) / Decimal.Parse(num2);
                outputLabel.Text = total.ToString();
                num1 = total.ToString();
                num2 = "";
                second_step = false;
                div = false;
            }
            else if (pow == true)
            {
                double x = double.Parse(num1);
                double y = double.Parse(num2);
                total = (decimal)Math.Pow(x, y);
                outputLabel.Text = total.ToString();
                num1 = total.ToString();
                num2 = "";
                second_step = false;
                pow = false;
            }
            else if (mod == true)
            {
                total = decimal.Parse(num1) % decimal.Parse(num2);
                outputLabel.Text = total.ToString();
                num1 = total.ToString();
                num2 = "";
                second_step = false;
                mod = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
