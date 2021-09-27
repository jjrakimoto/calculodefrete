using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculodefrete
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Calcular()
        {
            decimal valor = 0;
            decimal porcentagem = 0;

            valor = Convert.ToDecimal(txtvalor.Text);
            switch (cbestado.Text)
            {

                case "AM":
                    porcentagem = 0.6m;
                    break;
                case "MG":
                    porcentagem = 0.35m;
                    break;
                case "RJ":
                    porcentagem = 0.30m;
                    break;
                case "SP":
                    porcentagem = 0.2m;
                    break;
                default:
                    porcentagem = 0.75m;
                    break;

            }
            txtvalor.Text = valor.ToString("N2");

            txtfrete.Text = porcentagem.ToString("P1");

            lblresultado.Text = (valor * (1 + porcentagem)).ToString("c2");

        }
        private void LimparTudo()
        {
            txtnome.Text = "";
            txtfrete.Clear();
            txtvalor.Clear();
            cbestado.SelectedIndex = -1;
            lblresultado.Text = string.Empty;
            txtnome.Focus();
        }
            


        private void ptmcalcular_Click(object sender, EventArgs e)
        {
            txtfrete.Text = string.Empty;
            lblresultado.Text = string.Empty;

            if (txtnome.Text.Trim().Equals(""))
            {
                MessageBox.Show("Campo Nome Obrigatório", "Alerte", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtnome.Focus();
                return;
            }

            if (txtvalor.Text.Trim().Equals(""))
            {
                MessageBox.Show("Campo Valor Obrigatório", "Alerte", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtnome.Focus();
                return;
            }
            
            Calcular();
        }
    }
}