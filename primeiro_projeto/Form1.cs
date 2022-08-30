using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace primeiro_projeto
{
    public partial class frmCalculo : Form
    {
        public frmCalculo()
        {
            InitializeComponent();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
            //fApplication.Exit()
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtNum1.Text = String.Empty;
            txtNum2.Clear();
            //txtNum1.Text = "";
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            //Declaração das variáveis

            Double num1, num2, total;

            //atribuir valor a variável

            num1 = Convert.ToDouble(txtNum1.Text);
            num2 = Convert.ToDouble(txtNum2.Text);

            //processamento

            total = (num1 + num2) * num2;

            //Saída
            lblResultado.Text = "O resultado é " + total;
            txtResultado.Text = "O resultado é " + total;
            MessageBox.Show("O resultado é " + total);
            

        }
    }
}
