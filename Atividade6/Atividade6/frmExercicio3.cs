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
    public partial class frmExercicio3 : Form
    {
        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtTexto.Text.Length < 50)
            {
                string textSemEspaco = txtTexto.Text.Replace(" ", "");
                string textInv = textSemEspaco;
                char[] arr = textInv.ToCharArray(); 
                Array.Reverse(arr);
                textInv = "";
                foreach (char c in arr)
                    textInv = textInv + c.ToString();

                textInv = textInv.ToUpper();
                textSemEspaco = textSemEspaco.ToUpper();

                if (String.Compare(textSemEspaco, textInv, true) == 0)
                    MessageBox.Show("É Palindromo");
                else
                    MessageBox.Show("Não é palindromo");
            }
            else
                MessageBox.Show("Limite de caracteres: 50");
        }
    }
}
