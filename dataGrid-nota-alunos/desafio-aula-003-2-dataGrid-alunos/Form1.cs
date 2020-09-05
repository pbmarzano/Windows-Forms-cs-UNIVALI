using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desafio_aula_003_2_dataGrid_alunos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(nome.Text, textbox_idade.Text, serie.Text, nota.Text);
            nome.Text = "";
            textbox_idade.Text = "";
            serie.Text = "";
            nota.Text = "";
        }
    }
}
