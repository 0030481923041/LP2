using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pvolume
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void raio_Click(object sender, EventArgs e)
        {

        }

        private void altura_Click(object sender, EventArgs e)
        {

        }

        private void volume_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double verify1, verify2;

            if ((double.TryParse(textBox1.Text, out verify1)) &&
                (double.TryParse(textBox2.Text, out verify2)))
            {
                double vol = Math.PI * Math.Pow(verify1,2) * verify2;
                textBox3.Text = vol.ToString("N2");
            }
            else
                MessageBox.Show("Dados inválidos!");
        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Clear();
            textBox3.Text = String.Empty;
        }

        private void Sair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
