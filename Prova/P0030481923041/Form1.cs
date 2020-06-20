using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace P0030481923041
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double[,] vetor = new double[1,4];
            double totalMensal = 0;
            double totalGeral = 0;
            string valor = "";

            for (var y = 0; y < 1; y++)
            {
                totalMensal = 0;
                for (var x = 0; x < 4; x++)
                {
                    valor = Interaction.InputBox("Digite o total de vendas da semana " + (x + 1) + "\n" + "Referente ao mês" + (y + 1), "Entrada de dados das vendas");
                    if (double.TryParse(valor, out vetor[y,x]))
                    {
                        totalMensal = vetor[y,x] + totalMensal;
                    }
                    else
                    {
                        break;
                        x--;
                    }
                    listBox1.Items.Add("Mês: " + (y + 1) + " Semana: " + (x + 1) + " R$ " + (vetor[y,x].ToString("N2")) + "\n");
                }
                listBox1.Items.Add(">> Total do mes: " + (y + 1) + " R$ " + totalMensal.ToString("N2"));
                listBox1.Items.Add("...................");
                totalGeral = totalMensal + totalGeral;
            }
            listBox1.Items.Add(">> Total geral: " + "R$ " + totalGeral.ToString("N2"));
        }
    }
}
