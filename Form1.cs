using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora {
    public partial class Form1 : Form {

        decimal valor1 = 0;
        decimal valor2 = 0;
        string operacao = "";

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void TxtResultado_TextChanged(object sender, EventArgs e) {

        }

        private void labelOperacao_Click(object sender, EventArgs e) {

        }

        private void button6_Click(object sender, EventArgs e) {
            TxtResultado.Text = TxtResultado.Text + "5";
        }

        private void button5_Click(object sender, EventArgs e) {
            TxtResultado.Text = TxtResultado.Text + "4";
        }

        private void button15_Click(object sender, EventArgs e) {
            valor2 = decimal.Parse(TxtResultado.Text, CultureInfo.InvariantCulture);
            if(operacao == "SOMA") {
                TxtResultado.Text = Convert.ToString(valor1 + valor2);
            } else if (operacao == "DIVIDIR") {
                TxtResultado.Text = Convert.ToString(valor1 / valor2);
            }else if (operacao == "MULTIPLICAR") {
                TxtResultado.Text = Convert.ToString(valor1 * valor2);
            }else if (operacao == "SUBTRAÇÃO") {
                TxtResultado.Text = Convert.ToString(valor1 - valor2);
            }

         }

        private void button16_Click(object sender, EventArgs e) {
            valor1 = decimal.Parse(TxtResultado.Text, CultureInfo.InvariantCulture);

            TxtResultado.Text = "";

            operacao = "DIVIDIR";

            labelOperacao.Text = "÷";
        }

        private void button18_Click(object sender, EventArgs e) {
            TxtResultado.Text = TxtResultado.Text + "0";
        }

        private void button17_Click(object sender, EventArgs e) {
            TxtResultado.Text = ".";
        }

        private void button11_Click(object sender, EventArgs e) {
            TxtResultado.Text = TxtResultado.Text + "1";
        }

        private void button12_Click(object sender, EventArgs e) {
            TxtResultado.Text = TxtResultado.Text + "2";
        }

        private void button13_Click(object sender, EventArgs e) {
            TxtResultado.Text = TxtResultado.Text + "3";
        }

        private void button7_Click(object sender, EventArgs e) {
            TxtResultado.Text = TxtResultado.Text + "6";
        }

        private void button1_Click(object sender, EventArgs e) {
            TxtResultado.Text = TxtResultado.Text + "7";
        }

        private void button2_Click(object sender, EventArgs e) {
            TxtResultado.Text = TxtResultado.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e) {
            TxtResultado.Text = TxtResultado.Text + "9";
        }

        private void button4_Click(object sender, EventArgs e) {

            valor1 = decimal.Parse(TxtResultado.Text, CultureInfo.InvariantCulture);

            TxtResultado.Text = "";

            operacao = "SUBTRAÇÃO";

            labelOperacao.Text = "-";
        }

        private void button3_Click(object sender, EventArgs e) {

            valor1 = decimal.Parse(TxtResultado.Text,CultureInfo.InvariantCulture);

            TxtResultado.Text = "";

            operacao = "SOMA";

            labelOperacao.Text = "+";
        }

        private void button14_Click(object sender, EventArgs e) {
            valor1 = decimal.Parse(TxtResultado.Text, CultureInfo.InvariantCulture);

            TxtResultado.Text = "";

            operacao = "MULTIPLICAR";

            labelOperacao.Text = "x";
        }

       
    }
}
