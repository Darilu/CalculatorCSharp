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

namespace tentativa
{
    public partial class Form1 : Form
    {

        double valor1 = 0;
        double valor2 = 0;
        string operacao = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)//Botao Clear
        {
            txtResultado.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)//Botao CE
        {
            txtResultado.Text = "";
            valor1 = 0;
            valor2 = 0;

        }

        private void button20_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";

        }

        private void button18_Click(object sender, EventArgs e)


        {
            if (txtResultado.Text != "")
            {
                txtResultado.Text += ".";
            }
        }

        private void button11_Click_1(object sender, EventArgs e)//bOTAO DE IGUAL=
        {
            if (txtResultado.Text != "")
            {

                valor2 = double.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

                if (operacao == "SOMA")
                {
                    txtResultado.Text = Convert.ToString(valor1 + valor2);

                }

                else if (operacao == "MENOS")

                {
                    txtResultado.Text = Convert.ToString(valor1 - valor2);
                }

                else if (operacao == "MULTI")

                {
                    txtResultado.Text = Convert.ToString(valor1 * valor2);
                }

                else

                {
                    txtResultado.Text = Convert.ToString(valor1 / valor2);
                }

            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")

            {

                valor1 = double.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "SOMA";
                labelOperacao3.Text = "+";

            }

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {

                valor1 = double.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "MENOS";
                labelOperacao3.Text = "-";

            }
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = double.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "MULTI";
                labelOperacao3.Text = "*";
            }
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = double.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "DIV";
                labelOperacao3.Text = "/";
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            txtResultado.Text = "";
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            valor1 = 0;
            valor2 = 0;
            labelOperacao3.Text = "";
        }
    }

}