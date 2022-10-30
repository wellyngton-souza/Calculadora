using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraCSharp
{
    public partial class Form1 : Form
    {
        private Operadores OperaracaoSelecionada { get; set; }
        private enum Operadores
        {
            Adicao,
            subtrai,
            multiplicar,
            dividir
        }

        decimal Valor;
        decimal Resultado;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "1";
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "2";
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "3";
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "4";
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "5";
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "6";
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "7";
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "8";
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "9";
        }
        private void button_reseta_Click(object sender, EventArgs e)
        {
            label1.Text = "";
        }
        private void button0_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "0";
        }

        private void button_virgula_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + ",";
        }

        private void button_soma_Click(object sender, EventArgs e)
        {
            if (label1.Text != "")
            {
                OperaracaoSelecionada = Operadores.Adicao;
                Valor = Convert.ToDecimal(label1.Text);
                label1.Text = "";
            }
        }

        private void button_subtrai_Click(object sender, EventArgs e)
        {
            if (label1.Text != "")
            {
                OperaracaoSelecionada = Operadores.subtrai;
                Valor = Convert.ToDecimal(label1.Text);
                label1.Text = "";
            }
        }

        private void button_multiplica_Click(object sender, EventArgs e)
        {
            if (label1.Text != "")
            {
                OperaracaoSelecionada = Operadores.multiplicar;
                Valor = Convert.ToDecimal(label1.Text);
                label1.Text = "";
            }
        }

        private void button_divide_Click(object sender, EventArgs e)
        {
            if (label1.Text != "")
            {
                OperaracaoSelecionada = Operadores.dividir;
                Valor = Convert.ToDecimal(label1.Text);
                label1.Text = "";
            }
        }
        private void button_igual_Click(object sender, EventArgs e)
        {
            switch (OperaracaoSelecionada)
            {
                case Operadores.Adicao:
                    Resultado = Valor + Convert.ToDecimal(label1.Text);
                    break;
                case Operadores.subtrai:
                    Resultado = Valor - Convert.ToDecimal(label1.Text);
                    break;
                case Operadores.multiplicar:
                    Resultado = Valor * Convert.ToDecimal(label1.Text);
                    break;
                case Operadores.dividir:
                    Resultado = Valor / Convert.ToDecimal(label1.Text);
                    break;
            }
            label1.Text = Resultado.ToString();
        }
    }
}
