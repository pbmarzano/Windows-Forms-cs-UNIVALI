using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula001_conversor_moedas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void valor_real_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_dolar_Click(object sender, EventArgs e)
        {
            decimal dinheiro = Convert.ToDecimal(txt_valor.Text);
            decimal taxa = Convert.ToDecimal(txt_cambio.Text);

            var valor = dinheiro / taxa;
            var valstr = Convert.ToString(valor);

            txt_res.Text = valstr;

        }

        private void btn_real_Click(object sender, EventArgs e)
        {
            decimal dinheiro = Convert.ToDecimal(txt_valor.Text);
            decimal taxa = Convert.ToDecimal(txt_cambio.Text);

            var valor = dinheiro * taxa;
            var valstr = Convert.ToString(valor);

            txt_res.Text = valstr;
        }
    }
}
