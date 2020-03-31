using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INSS_IRPF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void maskedTextBox6_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedSalB_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string NomeFunc;
            double Salario;
            int filhos;
            if (double.TryParse(maskedSalB.Text, out Salario) && int.TryParse(maskedFilho.Text, out filhos) && maskedNome.Text != "")
            {
                NomeFunc = maskedNome.Text;
                if (Salario > 0 && filhos >= 0)
                {
                    double aliqINSS, aliqIRPF, valorINSS, valorIRPF, valorSalFamilia = 0, valorSalLiquido;
                    if (Salario.CompareTo(800.47) <= 0)
                    {
                        aliqINSS = 0.0765;
                        maskedINSS.Text = aliqINSS * 100 + "%";
                    }
                    else
                    {
                        if (Salario.CompareTo(1050.00) <= 0)
                        {
                            aliqINSS = 0.0865;
                            maskedINSS.Text = aliqINSS * 100 + "%";
                        }
                        else
                        {
                            if (Salario.CompareTo(1400.00) <= 0)
                            {
                                aliqINSS = 0.09;
                                maskedINSS.Text = aliqINSS * 100 + "%";
                            }
                            else
                            {
                                if (Salario.CompareTo(2801.56) <= 0)
                                {
                                    aliqINSS = 0.11;
                                    maskedINSS.Text = aliqINSS * 100 + "%";
                                }
                                else
                                {
                                    aliqINSS = 0.00;
                                    maskedINSS.Text = "Teto";
                                }
                            }
                        }
                    }
                    if (aliqINSS > 0)
                    {
                        valorINSS = Math.Round((Salario * aliqINSS), 2);
                    }
                    else
                    {
                        valorINSS = 308.17;
                    }

                    maskedDescINSS.Text = Math.Round((aliqINSS * 100), 2).ToString() + "%";

                    maskedDescINSS.Text = valorINSS.ToString();

                    if (Salario.CompareTo(1257.12) <= 0)
                    {
                        aliqIRPF = 0;
                        maskedIRPF.Text = aliqIRPF * 100 + "%";
                    }
                    else
                    {
                        if (Salario.CompareTo(2512.08) <= 0)
                        {
                            aliqIRPF = 0.15;
                            maskedIRPF.Text = aliqIRPF * 100 + "%";
                        }
                        else
                        {
                            aliqIRPF = 0.275;
                            maskedIRPF.Text = aliqIRPF * 100 + "%";
                        }
                    }

                    valorIRPF = Math.Round((Salario * aliqIRPF), 2);
                    maskedDescIRPF.Text = Math.Round((aliqIRPF * 100), 2).ToString() + "%";
                    maskedDescIRPF.Text = valorIRPF.ToString();

                    if (filhos > 0)
                    {
                        if (Salario.CompareTo(435.52) <= 0)
                        {
                            valorSalFamilia = Math.Round((filhos * 22.33), 2);
                        }
                        else if (Salario.CompareTo(654.51) <= 0)
                        {
                            valorSalFamilia = Math.Round((filhos * 15.74), 2);
                        }
                        else
                        {
                            valorSalFamilia = 0.00;
                        }
                    }

                    maskedSalFam.Text = valorSalFamilia.ToString();

                    valorSalLiquido = Salario - valorINSS - valorIRPF + valorSalFamilia;
                    maskedSLiq.Text = valorSalLiquido.ToString();

                    string strfilhos = maskedFilho.ToString();
                    LblDados.Text = "Os descontos do salário ";

                    if (radioFem.Checked)
                    {
                        LblDados.Text += "da Sra." + NomeFunc;
                    }
                    else
                    {
                        LblDados.Text += "do Sr." + NomeFunc;
                    }
                    if (checkBox1.Checked)
                    {
                        LblDados.Text += " que é casado(a)";
                    }
                    else
                    {
                        LblDados.Text += " que é solteiro(a)";
                    }
                    if (filhos > 0)
                    {
                        LblDados.Text += " e possui " + filhos;
                    }
                    else
                    {
                        LblDados.Text += " e não possui";
                    }
                    LblDados.Text += " filho(s) são:";
                }
                else
                {
                    MessageBox.Show("Valores não podem ser negativos e salario deve ser maior que Zero!");
                }
            }
            else
            {
                MessageBox.Show("Valores inválidos");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            maskedDescINSS.Text = "";
            maskedDescIRPF.Text = "";
            maskedINSS.Text = "";
            maskedIRPF.Text = "";
            maskedFilho.Text = "";
            maskedNome.Text = "";
            maskedSalB.Text = "";
            maskedSalFam.Text = "";
            maskedSLiq.Text = "";
            checkBox1.Checked = false;
            LblDados.Text = "";
        }

        private void maskedSLiq_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
