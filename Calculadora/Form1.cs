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
    public partial class Form1 : Form
    {
        decimal calculo = 0;
        bool adicao = false;
        bool subtracao = false;
        bool multiplicacao = false;
        bool divisao = false;
        bool resultado = false;

        // Variável global:
        bool clicouNoOperador = true;
        public Form1()
        {
            InitializeComponent();
        }
        private void Numero_Click(object sender, EventArgs e)
        {
            // Receber valor do botão pressionado:
            var btnClicado = sender as Button;
            txtTela.Text += btnClicado.Text;
            txtOperacao.Text += btnClicado.Text;

            clicouNoOperador = false;
        }
        private void Operacao_Click(object sender, EventArgs e)
        {
            var btnClicado = sender as Button;
            // Só atribuir na tela se não tiver clicado no operador:
            if (clicouNoOperador == false)
            {
                txtTela.Text += btnClicado.Text;
                clicouNoOperador = true;
            }           
        }
        private void btnIgual_Click(object sender, EventArgs e)
        {
            // Ao pressionar o "=" / Sinal de igual.
            resultado = true;

            txtOperacao.Text += "=";

            // Caso for somar:
            if (adicao == true)
            {
                txtTela.Text = Convert.ToString(calculo + Convert.ToDecimal(txtTela.Text));

                txtOperacao.Text += txtTela.Text;
            }
            // Caso for subtrair:
            if (subtracao == true)
            {
                txtTela.Text = Convert.ToString(calculo - Convert.ToDecimal(txtTela.Text));

                txtOperacao.Text += txtTela.Text;
            }
            // Caso for multiplicar:
            if (multiplicacao == true)
            {
                txtTela.Text = Convert.ToString(calculo * Convert.ToDecimal(txtTela.Text));

                txtOperacao.Text += txtTela.Text;
            }
            // Caso for dividir:
            if (divisao == true)
            {
                txtTela.Text = Convert.ToString(calculo / Convert.ToDecimal(txtTela.Text));

                txtOperacao.Text += txtTela.Text;
            }          
        }       
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // Apagar as Telas:
            txtTela.Text = null;

            txtOperacao.Text = null;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {          
            calculo = Convert.ToDecimal(txtTela.Text);

            txtOperacao.Text += "/";
            txtTela.Text = "";

            adicao = false;
            subtracao = false;
            multiplicacao = false;
            divisao = true;
        }

        private void btnMpx_Click(object sender, EventArgs e)
        {
            calculo = Convert.ToDecimal(txtTela.Text);

            txtOperacao.Text += "*";
            txtTela.Text = "";

            adicao = false;
            subtracao = false;
            multiplicacao = true;
            divisao = false;
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            calculo = Convert.ToDecimal(txtTela.Text);

            txtOperacao.Text += "-";
            txtTela.Text = "";

            adicao = false;
            subtracao = true;
            multiplicacao = false;
            divisao = false;
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            calculo = Convert.ToDecimal(txtTela.Text);

            txtOperacao.Text += "+";           
            txtTela.Text = "";

            adicao = true;
            subtracao = false;
            multiplicacao = false;
            divisao = false;
        }
    }
}
