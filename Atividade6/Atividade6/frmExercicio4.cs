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
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double Gratif;
            double A;
            int Producao;
            if (int.TryParse(txtProducao.Text, out Producao) && double.TryParse(txtCargo.Text, out A) && double.TryParse(txtCargo.Text, out Gratif))
            {
                int Bp, Cp, Dp;
                if (Producao >= 150)
                {
                    Bp = 1;
                    Cp = 1;
                    Dp = 1;
                }
                else
                    if (Producao >= 120)
                    {
                        Bp = 1;
                        Cp = 1;
                        Dp = 0;

                    }
                    else
                        if (Producao >= 100)
                        {
                            Bp = 1;
                            Cp = 0;
                            Dp = 0;

                        }
                        else if (Producao < 100)
                        {
                            Bp = 0;
                            Cp = 0;
                            Dp = 0;


                            double salBruto = A + A * (0.05 * Bp + 0.1 * Cp + 0.1 * Dp) + Gratif;
                            if (salBruto > 7000 && Dp == 1 && Gratif != 0)
                            {
                                string salBruto1 = salBruto.ToString();
                                MessageBox.Show(salBruto1);
                            }
                            else
                            {
                                 string salBruto1 = salBruto.ToString();
                                 txtSalario.Text = salBruto1;
                            }

                        }
            }
        }
    }
}