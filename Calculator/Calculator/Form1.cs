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
        double result = 0, later;
        bool cal = false;
        bool IsOp = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "0";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
            result = later = 0;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "0";
            }
            else if (label1.Text != "0")
            {
                label1.Text += "0";
            }
            else { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0" || IsOp == true)
            {
                label1.Text = "1";
                IsOp = false;
            }
            else
            {
                label1.Text += "1";

            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "2";
            }
            else if (label1.Text != "0")
            {
                label1.Text += "2";
            }
            else { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "3";
            }
            else if (label1.Text != "0")
            {
                label1.Text += "3";
            }
            else { }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "4";
            }
            else if (label1.Text != "0")
            {
                label1.Text += "4";
            }
            else { }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "5";
            }
            else if (label1.Text != "0")
            {
                label1.Text += "5";
            }
            else { }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "6";
            }
            else if (label1.Text != "0")
            {
                label1.Text += "6";
            }
            else { }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "7";
            }
            else if (label1.Text != "0")
            {
                label1.Text += "7";
            }
            else { }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "8";
            }
            else if (label1.Text != "0")
            {
                label1.Text += "8";
            }
            else { }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "9";
            }
            else if (label1.Text != "0")
            {
                label1.Text += "9";
            }
            else { }
        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void buttonADD_Click(object sender, EventArgs e)
        {           
            if (cal == false)
            {                
                if (result == 0)
                {
                    later = Convert.ToDouble(label1.Text);
                    result += later;
                    label1.Text = "";
                    cal = true;
                }

                else if (result != 0)
                {
                    result = Convert.ToDouble(label1.Text);
                    label1.Text = "";
                    cal = true;
                }
            }
            else if (cal == true)
            {
                later = Convert.ToDouble(label1.Text);
                result += later;
                label1.Text = Convert.ToString(result);
                cal = false;
               
            }
            IsOp = true;
        }
       
    }
}
