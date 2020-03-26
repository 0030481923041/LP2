using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int ladoA, ladoB, ladoC;

            if ((int.TryParse(txtLadoA.Text, out ladoA)) &&
                (int.TryParse(txtLadoB.Text, out ladoB)) &&
                (int.TryParse(txtLadoC.Text, out ladoC)))
            {
                if (ladoA > 0 && ladoB > 0 && ladoC > 0)
                {
                    if (ladoA + ladoB >= ladoC && ladoA + ladoC >= ladoB && ladoB + ladoC >= ladoA)
                    {
                        if (ladoA == ladoB && ladoB == ladoC && ladoC == ladoA)
                        {
                            MessageBox.Show("Triangulo Equilatero");
                        }
                        else if (ladoA == ladoB || ladoB == ladoC || ladoC == ladoA)
                        {
                            MessageBox.Show("Triangulo Isósceles");
                        }
                        else if (ladoA != ladoB && ladoB != ladoC && ladoC != ladoA)
                        {
                            MessageBox.Show("Triangulo Escaleno");
                        }
                    }
                }
                else
                    MessageBox.Show("Dados inválidos!");
            }
            else
                MessageBox.Show("Dados inválidos!");
        }

        private void txtLadoA_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtLadoB_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtLadoC_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
