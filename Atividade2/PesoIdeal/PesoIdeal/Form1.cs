using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PesoIdeal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            double altura, pesoIdeal, pesoAtual;

            if (Masculino.Checked)
            {
                double.TryParse(Altura.Text, out altura);
                double.TryParse(Peso.Text, out pesoAtual);
                pesoIdeal = (72.7 * altura) - 58;
                pesoIdeal = Math.Round(pesoIdeal, 2);

                if (pesoAtual < pesoIdeal)
                {
                    string pesoIdealShow = "Peso ideal: " + pesoIdeal;
                    MessageBox.Show("Abaixo do peso ideal");
                    MessageBox.Show(pesoIdealShow);
                }

                else if (pesoAtual > pesoIdeal)
                {
                    string pesoIdealShow = "Peso ideal: " + pesoIdeal;
                    MessageBox.Show("Acima do peso ideal");
                    MessageBox.Show(pesoIdealShow);
                }

                else
                {
                    MessageBox.Show("Está no peso ideal");
                }
            }

            else if (Feminino.Checked)
            {
                double.TryParse(Altura.Text, out altura);
                double.TryParse(Peso.Text, out pesoAtual);
                pesoIdeal = (62.7 * altura) - 44.7;
                pesoIdeal = Math.Round(pesoIdeal, 2);

                if (pesoAtual < pesoIdeal)
                {
                    string pesoIdealShow = "Peso ideal: " + pesoIdeal;
                    MessageBox.Show("Abaixo do peso ideal");
                    MessageBox.Show(pesoIdealShow);
                }

                else if (pesoAtual > pesoIdeal)
                {
                    string pesoIdealShow = "Peso ideal: " + pesoIdeal;
                    MessageBox.Show("Acima do peso ideal");
                    MessageBox.Show(pesoIdealShow);
                }

                else
                {
                    MessageBox.Show("Está no peso ideal");
                }
            }

            else
            {
                MessageBox.Show("Selecione um gênero");
            }

        }

        private void Altura_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Peso_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Masculino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Feminino_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
