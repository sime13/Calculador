using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        private object text;

        public Calculadora()
        {
            InitializeComponent();
        }
        private decimal resultado {  get; set; }
        private decimal valor { get; set; }
        private Operacao operadorSelecionado { get; set; }
        private enum Operacao
        {
            Addicao,
            Soustracao,
            Multiplicacao,
            Divisao
        }
        private void btnOito_Click(object sender, EventArgs e)
        {
           textBox.Text += "8";
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            textBox.Text += "0";
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            textBox.Text += "5";
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            textBox.Text += "6";
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            textBox.Text += "7";
        }

      

        private void btnNove_Click(object sender, EventArgs e)
        {
            textBox.Text += "9";
        }

      

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            textBox.Text += "4";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            textBox.Text += "3";
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            textBox.Text += "2";
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            textBox.Text += "1";
        }

        ///operador
        private void btnAdd_Click(object sender, EventArgs e)
        {
            operadorSelecionado = Operacao.Addicao;
            valor = Convert.ToDecimal(textBox.Text);
            textBox.Text = "";
        }

        private void btnSous_Click(object sender, EventArgs e)
        {
            operadorSelecionado = Operacao.Soustracao;
            valor = Convert.ToDecimal(textBox.Text);
            textBox.Text = "";
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            operadorSelecionado = Operacao.Multiplicacao;
            valor = Convert.ToDecimal(textBox.Text);
            textBox.Text = "";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            operadorSelecionado = Operacao.Divisao;
            valor = Convert.ToDecimal(textBox.Text);
            textBox.Text = "";
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            switch (operadorSelecionado)
            {
                case Operacao.Addicao:
                    resultado = valor + Convert.ToDecimal(textBox.Text);
                    break;
                case Operacao.Multiplicacao:
                    resultado = valor * Convert.ToDecimal(textBox.Text);
                    break;
                case Operacao.Divisao:
                    resultado = valor / Convert.ToDecimal(textBox.Text);
                    break;
                case Operacao.Soustracao:
                    resultado = valor - Convert.ToDecimal(textBox.Text);
                    break;
            }
            textBox.Text = Convert.ToString(resultado);
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if (textBox.Text.Contains(','))
                textBox.Text += ",";
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            textBox.Text += " ";
        }
    }
}
