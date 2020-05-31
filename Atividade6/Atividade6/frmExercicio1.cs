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
    public partial class frmExercicio1 : Form
    {
        public frmExercicio1()
        {
            InitializeComponent();
        }

        private void btnBranco_Click(object sender, EventArgs e)
        {
            int b = 0;
            if (rchTexto.Text.Length < 100)
            {
                for (var x = 0; x <= rchTexto.Text.Length - 1; x++)
                {
                    if (Char.IsWhiteSpace(rchTexto.Text[x]))
                    {
                        b += 1;
                    }
                    
                }
                 MessageBox.Show("Caracteres brancos: " +  b);
            }
            else
                MessageBox.Show("Limite de caracteres: 100");
        }

        private void btnRepetR_Click(object sender, EventArgs e)
        {
            string texto = rchTexto.Text.Trim();
            int totalR = 0;
            foreach (char letraR in texto)
            {
                if (letraR == 'R')
                {
                    totalR += 1;
                }
            }
            MessageBox.Show("O Texto " + rchTexto.Text + " tem " + totalR.ToString() + " letra(s) R");
        }

        private void btnRepetPar_Click(object sender, EventArgs e)
        {
            int xx = 0;
            int numero = 0;
            string letra = "ss";
            for (xx = 0; xx <= rchTexto.Text.Length - 1; xx++)
            {
                if ((rchTexto.Text.Substring(xx, 1) != "") && (rchTexto.Text.Substring(xx, 1) == letra))
                {
                    numero += 1;
                }
                letra = rchTexto.Text.Substring(xx, 1);
            }
            MessageBox.Show(numero.ToString());

        }
    }
}
