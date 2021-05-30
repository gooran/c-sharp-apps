using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Calculator
{
    public partial class Form1 : Form
    {
        bool clearResult = false;
        bool canChangeOprator = false;
        double firstOprand;
        string opr = "";
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            firstOprand = 0;
            textBox1.Text = "0";
        }
        private void buttonDigit_Click(object sender, EventArgs e)
        {
            canChangeOprator = false;
            if (clearResult)
            {
                textBox1.Text = "0";
                clearResult = false;
            }
            if (textBox1.Text == "0" && ((Button)sender).Text != ".")
                textBox1.Text = "";
            textBox1.Text += ((Button)sender).Text;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (clearResult)
            {
                textBox1.Text = "0";
                clearResult = false;
            }
            string text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            if (text.Length == 0 || text == "-" || text == "-0")
                text = "0";
            textBox1.Text = text;
        }

        private void buttonSign_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            string sign = text.Substring(0, 1);

            if (sign == "-")
                text = text.Substring(1, text.Length - 1);
            else
                if (text != "0")
                    text = "-" + text;

            textBox1.Text = text;
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "";
            opr = "";
            clearResult = false;
        }
        private void buttonSingleOpration_Click(object sender, EventArgs e)
        {
            string newOpr = ((Button)sender).Text;
            switch (newOpr)
            {
                case "%":
                    if (opr == "")
                        textBox1.Text = "0";
                    else
                        textBox1.Text = ((firstOprand / 100) * double.Parse(textBox1.Text.Replace(".", "/"))).ToString().Replace("/", ".");
                    break;
                case "√":
                    textBox1.Text = Math.Sqrt(double.Parse(textBox1.Text.Replace(".", "/"))).ToString().Replace("/", ".");
                    break;
                case "x^2":
                    textBox1.Text = Math.Pow(double.Parse(textBox1.Text.Replace(".", "/")), 2).ToString().Replace("/", ".");
                    break;
                case "1/x":
                    textBox1.Text = (1 / double.Parse(textBox1.Text.Replace(".", "/"))).ToString().Replace("/", ".");
                    break;
                default:
                    break;
            }
            clearResult = true;
            canChangeOprator = false;
        }
        private void buttonBasicOpration_Click(object sender, EventArgs e)
        {
            string newOpr = ((Button)sender).Text;

            if (canChangeOprator)
            {
                opr = newOpr;
                textBox2.Text = firstOprand.ToString() + opr;
                return;
            }
            switch (opr)
            {
                case "+":
                    firstOprand = firstOprand + double.Parse(textBox1.Text.Replace(".", "/"));
                    break;
                case "−":
                    firstOprand = firstOprand - double.Parse(textBox1.Text.Replace(".", "/"));
                    break;
                case "×":
                    firstOprand = firstOprand * double.Parse(textBox1.Text.Replace(".", "/"));
                    break;
                case "÷":
                    firstOprand = firstOprand / double.Parse(textBox1.Text.Replace(".", "/"));
                    break;
                case "":
                    firstOprand = double.Parse(textBox1.Text.Replace(".", "/"));
                    break;
                default:
                    break;
            }
            opr = newOpr;
            textBox1.Text = firstOprand.ToString().Replace("/", ".");
            textBox2.Text = firstOprand.ToString().Replace("/", ".") + opr;
            clearResult = true;
            canChangeOprator = true;
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            switch (opr)
            {
                case "+":
                    firstOprand = firstOprand + double.Parse(textBox1.Text.Replace(".", "/"));
                    break;
                case "−":
                    firstOprand = firstOprand - double.Parse(textBox1.Text.Replace(".", "/"));
                    break;
                case "×":
                    firstOprand = firstOprand * double.Parse(textBox1.Text.Replace(".", "/"));
                    break;
                case "÷":
                    firstOprand = firstOprand / double.Parse(textBox1.Text.Replace(".", "/"));
                    break;
                case "":
                    firstOprand = double.Parse(textBox1.Text.Replace(".", "/"));
                    break;
                default:
                    break;
            }
            opr = "";
            textBox1.Text = firstOprand.ToString().Replace("/", ".");
            textBox2.Text = "";
            clearResult = true;
            canChangeOprator = false;
        }

    }
}
