using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade6
{
    public partial class frmExercicio2 : Form
    {
        public frmExercicio2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //double H;
            //int N;
            //int x == N;

            double N;
            double H = 1;

            if (double.TryParse(txtNumero.Text, out N))
            {
                for (double x = N; x < 2; x--)
                {
                    H = (1 / N) + H;
                    N = N - 1;
                }
                txtResultado.Text = H.ToString("N2");
            }
        }
    }
}
