using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMetodos1505
{
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void Numerico_Click(object sender, EventArgs e)
        {
            //dias 10 melhores 1000

            int contador = 0;

            for (var x = 0; x <= rchtxtTexto.Text.Length - 1; x++)
            {
                //if (Char.IsNumber(Convert.ToChar(rchtxtTexto.Text.Substring(x, 1)))

                if (Char.IsNumber(rchtxtTexto.Text[x]))
                    contador += 1; //contador=contador+1
            }
            MessageBox.Show("Caracteres numéricos:" + contador);
        }

        private void btnBranco_Click(object sender, EventArgs e)
        {
            int x = 0;

            //hoje tem sol - 14 caracteres
            //4 - desenvolvedor 5 - usuario

            while (x<rchtxtTexto.Text.Length)
            {
                if (Char.IsWhiteSpace(rchtxtTexto.Text[x]))
                {
                    MessageBox.Show("Primeiro caracter branco:" + (x + 1));
                    break;

                }
                x += 1; //x=x+1;
            }
        }

        private void btnAlfabetico_Click(object sender, EventArgs e)
        {
            //vejo flores em voce

            int contador = 0;

            foreach (char c in rchtxtTexto.Text)
            {
                if (Char.IsLetter(c))
                    contador += 1;
            }
            MessageBox.Show("Caracteres Alfabéticos:" + contador);
        }
    }
}
