using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora_cs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int operacao = 1;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            operacao = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            operacao = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            operacao = 3;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            operacao = 4; 
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            operacao = 5;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            operacao = 6;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n1;
            double n2;
            double res;

            n1 = double.Parse(textBox1.Text);
            n2 = double.Parse(textBox2.Text);

            if  (operacao == 1)
            {
                res = n1 + n2;
                textBox3.Text = res.ToString();
            }

            if (operacao == 2)
            {
                res = n1 - n2;
                textBox3.Text = res.ToString();
            }

            if (operacao == 3)
            {
                res = n1 / n2;
                textBox3.Text = res.ToString();
            }

            if (operacao == 4)
            {
                res = n1 * n2;
                textBox3.Text = res.ToString();
            }

            if (operacao == 5)
            {
                res = Math.Pow(n1, n2);
                textBox3.Text = res.ToString();
            }

            if (operacao == 6)
            {
                res = n1 % n2;
                textBox3.Text = res.ToString();
            }
        }
    }
}
