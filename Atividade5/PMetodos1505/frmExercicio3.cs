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
    public partial class frmExercicio3 : Form
    {
        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void btnRemove1_Click(object sender, EventArgs e)
        {
            // r        ss           r
            // arara  assessoria  sorocaba
            // aara   aessoria    soocaba
            // aaa    aeoria       ----
            
            int posicao;
            posicao = txtPalavra2.Text.IndexOf(txtPalavra1.Text);

            while (posicao >=0)
            {
                txtPalavra2.Text = txtPalavra2.Text.Substring(0, posicao) +
                    txtPalavra2.Text.Substring(posicao + txtPalavra1.Text.Length,
                    txtPalavra2.Text.Length - posicao - txtPalavra1.Text.Length);

                posicao = txtPalavra2.Text.IndexOf(txtPalavra1.Text);
            }
        }

        private void btnRemove2_Click(object sender, EventArgs e)
        {
            //txtPalavra2.Text = txtPalavra2.Text.Replace(txtPalavra1.Text, "");
            txtPalavra2.Text = txtPalavra2.Text.Replace(" ", "");
        }

        private void btnInverte_Click(object sender, EventArgs e)
        {
            string s = txtPalavra1.Text;
            char[] arr = s.ToCharArray(); //joga a string para um array
            Array.Reverse(arr); //inverte o array
            s = "";
            foreach (char c in arr)
                s = s + c.ToString();
            MessageBox.Show(s);

            //ou

            //string ss = txtPalavra1.Text;
            //char[] arr1 = ss.ToCharArray();
            //Array.Reverse(arr1);
            //MessageBox.Show(ss);
        }
    }
}
