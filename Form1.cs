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
        public int Result = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (NumScreen.Text != "0")
                NumScreen.Text = NumScreen.Text + "0";
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(NumScreen.Text == "0")
                NumScreen.Text = "1";
            else
                NumScreen.Text = NumScreen.Text + "1";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (NumScreen.Text == "0")
                NumScreen.Text = "2";
            else
                NumScreen.Text = NumScreen.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (NumScreen.Text == "0")
                NumScreen.Text = "3";
            else
                NumScreen.Text = NumScreen.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (NumScreen.Text == "0")
                NumScreen.Text = "4";
            else
                NumScreen.Text = NumScreen.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (NumScreen.Text == "0")
                NumScreen.Text = "5";
            else
                NumScreen.Text = NumScreen.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (NumScreen.Text == "0")
                NumScreen.Text = "6";
            else
                NumScreen.Text = NumScreen.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (NumScreen.Text == "0")
                NumScreen.Text = "7";
            else
                NumScreen.Text = NumScreen.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (NumScreen.Text == "0")
                NumScreen.Text = "8";
            else
                NumScreen.Text = NumScreen.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (NumScreen.Text == "0")
                NumScreen.Text = "9";
            else
                NumScreen.Text = NumScreen.Text + "9";
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            int num = int.Parse(NumScreen.Text);
            Result = Result + num;
            NumScreen.Text = "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int num = int.Parse(NumScreen.Text);
            Result = Result + num;
            NumScreen.Text = Result.ToString();
            Result = 0;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Result = 0;
            NumScreen.Text = "0";
        }
    }
}
