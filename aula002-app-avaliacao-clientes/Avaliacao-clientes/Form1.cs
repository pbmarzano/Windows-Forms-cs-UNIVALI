using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avaliacao_clientes
{
    public partial class Form1 : Form
    {
        int counterS = 0;
        int counterN = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            counterS++;
            textBox1.Text = counterS.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            counterN++;
            textBox2.Text = counterN.ToString();
        }
    }
}
