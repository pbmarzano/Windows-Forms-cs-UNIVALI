using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace db_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection objcon = new MySqlConnection("server=localhost;port=3307;User Id=root;database=db_test;password=J@Z*2018");
                objcon.Open();
                MessageBox.Show("conectado");
                objcon.Close();
            }

            catch
            {
                MessageBox.Show("Não conectado");
            }
        }
    }
}
