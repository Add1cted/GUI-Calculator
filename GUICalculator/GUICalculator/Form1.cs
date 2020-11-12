using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUICalculator
{
    public partial class Form1 : Form
    {
        public string equation = "";
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = equation + Environment.NewLine + "-----------";
        }

        private void button4_Click(object sender, EventArgs e) //1
        {
            equation += 1;
            textBox1.Text = equation + Environment.NewLine + "-----------";
        }

        private void button5_Click(object sender, EventArgs e) //2
        {
            equation += 2;
            textBox1.Text = equation + Environment.NewLine + "-----------";
        }

        private void button6_Click(object sender, EventArgs e) //3
        {
            equation += 3;
            textBox1.Text = equation + Environment.NewLine + "-----------";
        }

        private void button7_Click(object sender, EventArgs e) //4
        {
            equation += 4;
            textBox1.Text = equation + Environment.NewLine + "-----------";
        }

        private void button8_Click(object sender, EventArgs e) //5
        {
            equation += 5;
            textBox1.Text = equation + Environment.NewLine + "-----------";
        }

        private void button9_Click(object sender, EventArgs e) //6  
        {
            equation += 6;
            textBox1.Text = equation + Environment.NewLine + "-----------";
        }

        private void button10_Click(object sender, EventArgs e) //7
        {
            equation += 7;
            textBox1.Text = equation + Environment.NewLine + "-----------";
        }

        private void button11_Click(object sender, EventArgs e) //8
        {
            equation += 8;
            textBox1.Text = equation + Environment.NewLine + "-----------";
        }

        private void button12_Click(object sender, EventArgs e) //9
        {
            equation += 9;
            textBox1.Text = equation + Environment.NewLine + "-----------";
        }

        private void button14_Click(object sender, EventArgs e) //0
        {
            equation += 0;
            textBox1.Text = equation + Environment.NewLine + "-----------";
        }

        private void button15_Click(object sender, EventArgs e) //.
        {
            equation += ".";
            textBox1.Text = equation + Environment.NewLine + "-----------";
        }

        private void button1_Click(object sender, EventArgs e) //AC
        {
            equation = "";
            textBox1.Text = equation + Environment.NewLine + "-----------";
        }

        private void button2_Click(object sender, EventArgs e) //+/-
        {
            equation += "-";
            textBox1.Text = equation + Environment.NewLine + "-----------";
        }

        private void button3_Click(object sender, EventArgs e) //%
        {
            equation += "+";
            textBox1.Text = equation + Environment.NewLine + "-----------";
        }
        private void button13_Click(object sender, EventArgs e) // / 
        {
            equation += "/";
            textBox1.Text = equation + Environment.NewLine + "-----------";
        }        

        private void button16_Click(object sender, EventArgs e) //+
        {
            equation += "+";
            textBox1.Text = equation + Environment.NewLine + "-----------";
        }

        private void button17_Click(object sender, EventArgs e) //-
        {
            equation += "-";
            textBox1.Text = equation + Environment.NewLine + "-----------";
        }

        private void button18_Click(object sender, EventArgs e) //x
        {
            equation += "*";
            textBox1.Text = equation + Environment.NewLine + "-----------";
        }

        private void button19_Click(object sender, EventArgs e) //=
        {
            string value = new DataTable().Compute(equation, null).ToString();
            textBox1.Text = equation + Environment.NewLine + "-----------" + Environment.NewLine + value;
        }
    }
}
