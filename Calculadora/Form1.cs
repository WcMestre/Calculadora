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
        int numero1, resultado=0;
        string operacao;
        public Form1()
        {
            InitializeComponent();
        }

        private void bt0_Click(object sender, EventArgs e)
        {
            visor.Text = visor.Text + 0;
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            visor.Text = visor.Text + 1;
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            visor.Text = visor.Text + 2;
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            visor.Text = visor.Text + 3;
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            visor.Text = visor.Text + 4;
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            visor.Text = visor.Text + 5;
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            visor.Text = visor.Text + 6;
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            visor.Text = visor.Text + 7;
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            visor.Text = visor.Text + 8;
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            visor.Text = visor.Text + 9;
        }

        private void btsoma_Click(object sender, EventArgs e)
        {
            numero1 = int.Parse(visor.Text);
            visor.Text = null;
            operacao = "soma";
        }

        private void btigual_Click(object sender, EventArgs e)
        {
            if (operacao == "soma")
            {
                resultado = numero1 + int.Parse(visor.Text);
                visor.Text = Convert.ToString(resultado);
                numero1 = resultado;
            }

            else if (operacao == "subtracao")
            {
                resultado = numero1 - int.Parse(visor.Text);
                visor.Text = Convert.ToString(resultado);
                numero1 = resultado;
            }

            else if (operacao == "multiplicacao")
            {
                resultado = numero1 * int.Parse(visor.Text);
                visor.Text = Convert.ToString(resultado);
                numero1 = resultado;
            }

            else if (operacao == "divisao")
            {
                if (numero1 == 0 || int.Parse(visor.Text) == 0)
                {
                    MessageBox.Show("Não é possível dividir por 0 (zero). Reinicie a operação.");
                    numero1 = 0;
                    resultado = 0;
                    visor.Text = null;
                }

                else
                {
                    resultado = numero1 / int.Parse(visor.Text);
                    visor.Text = Convert.ToString(resultado);
                    numero1 = resultado;
                }
            }
        }

        private void btsubtracao_Click(object sender, EventArgs e)
        {
            numero1 = int.Parse(visor.Text);
            visor.Text = null;
            operacao = "subtracao";
        }

        private void btmultiplicacao_Click(object sender, EventArgs e)
        {
            numero1 = int.Parse(visor.Text);
            visor.Text = null;
            operacao = "multiplicacao";
        }

        private void btdivisao_Click(object sender, EventArgs e)
        {
            numero1 = int.Parse(visor.Text);
            visor.Text = null;
            operacao = "divisao";
        }

        private void btce_Click(object sender, EventArgs e)
        {
            visor.Text = null;
            numero1 = 0;
            resultado = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
