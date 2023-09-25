using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frmTelaPrincipal : Form
    {
        public frmTelaPrincipal()
        {
            InitializeComponent();
        }

        private void btmSomar_Click(object sender, EventArgs e)
        {
            // variaveis
            double n1, n2, resp;

            // entrada
            n1 = Convert.ToDouble(txtNumero1.Text.Replace('.',','));
            n2 = Convert.ToDouble(txtNumero2.Text.Replace('.', ','));

            // processamento
            resp = n1 + n2;
            
            // saída
            lblResposta.Text = resp.ToString("#0.0#");
        }

        private void btmSubtrair_Click(object sender, EventArgs e)
        {
            // variaveis
            double n1, n2, resp;

            // entrada
            n1 = Convert.ToDouble(txtNumero1.Text.Replace('.', ','));
            n2 = Convert.ToDouble(txtNumero2.Text.Replace('.', ','));

            // processamento
            resp = n1 - n2;

            // saída
            lblResposta.Text = resp.ToString("#0.0#");
        }

        private void btmDividir_Click(object sender, EventArgs e)
        {
            // variaveis
            double n1, n2, resp;

            // entrada
            n1 = Convert.ToDouble(txtNumero1.Text.Replace('.', ','));
            n2 = Convert.ToDouble(txtNumero2.Text.Replace('.', ',')); ;

            // processamento
            resp = n1 / n2;

            // saída
            lblResposta.Text = resp.ToString("#0.0#");
        }

        private void btmMultiplicar_Click(object sender, EventArgs e)
        {
            // variaveis
            double n1, n2, resp;

            // entrada
            n1 = Convert.ToDouble(txtNumero1.Text.Replace('.', ','));
            n2 = Convert.ToDouble(txtNumero2.Text.Replace('.', ','));

            // processamento
            resp = n1 * n2;

            // saída
            lblResposta.Text = resp.ToString("#0.0#");
        }
    }
}
