using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mywindowapp
{

    public partial class Form1 : Form
    {
        static string IsOperand = "";
        static string myval = "";

        public Form()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            app_function();
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            app_function1();
        }
        private void app_function()
        {
            this.Text = "I am single click";

        }
        private void app_function1()
        {
            this.Text = "I am double click";

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (IsOperand != "")
            {
                textBox2.Text = textBox2.Text + "2";
            }
            else
            {
                textBox2.Text = textBox2.Text + "2";
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button10_Click(object sender, EventArgs e)
        {

            if (IsOperand != "")
            {
                textBox2.Text = textBox2.Text + "0";
            }
            else
            {
                textBox2.Text = textBox2.Text + "0";
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (IsOperand != "")
            {
                textBox2.Text = textBox2.Text + "3";
            }
            else
            {
                textBox2.Text = textBox2.Text + "3";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsOperand != "")
            {
                textBox2.Text = textBox2.Text + "1";
            }
            else
            {
                textBox2.Text = textBox2.Text + "1";
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (IsOperand != "")
            {
                textBox2.Text = textBox2.Text + "4";
            }
            else
            {
                textBox2.Text = textBox2.Text + "4";
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (IsOperand != "")
            {
                textBox2.Text = textBox2.Text + "5";
            }
            else
            {
                textBox2.Text = textBox2.Text + "5";
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (IsOperand != "")
            {
                textBox2.Text = textBox2.Text + "6";
            }
            else
            {
                textBox2.Text = textBox2.Text + "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (IsOperand != "")
            {
                textBox2.Text = textBox2.Text + "7";
            }
            else
            {
                textBox2.Text = textBox2.Text + "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (IsOperand != "")
            {
                textBox2.Text = textBox2.Text + "8";
            }
            else
            {
                textBox2.Text = textBox2.Text + "8";
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (IsOperand != "")
            {
                textBox2.Text = textBox2.Text + "9";
            }
            else
            {
                textBox2.Text = textBox2.Text + "9";
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {

            myval = textBox2.Text;
            IsOperand = "+";
            textBox2.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {

            myval = textBox2.Text;
            IsOperand = "-";
            textBox2.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            myval = textBox2.Text;
            IsOperand = "*";
            textBox2.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            myval = textBox2.Text;
            IsOperand = "/";
            textBox2.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {

            textBox2.Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (IsOperand == "+")
            {

                textBox2.Text = Convert.ToString(Convert.ToInt32(myval) + Convert.ToInt32(textBox2.Text));

            }
            else if (IsOperand == "-")
            {

                textBox2.Text = Convert.ToString(Convert.ToInt32(myval) - Convert.ToInt32(textBox2.Text));

            }

            else if (IsOperand == "*")
            {

                textBox2.Text = Convert.ToString(Convert.ToInt32(myval) * Convert.ToInt32(textBox2.Text));

            }
            else if (IsOperand == "/")
            {

                textBox2.Text = Convert.ToString(Convert.ToInt32(myval) / Convert.ToInt32(textBox2.Text));

            }
            else
            {
                return;
            }
        }
    }
}
