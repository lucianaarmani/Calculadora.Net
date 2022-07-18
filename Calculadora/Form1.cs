using System.Globalization;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";

        public object Tostring { get; private set; }
        public NumberStyles Cultureinfo { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }
        private void button16_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }
        private void button11_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }
        private void button12_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }
        private void button13_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }
        private void button6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }
        private void button7_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }
        private void button8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }
        private void button1_Click_1(object sender, EventArgs e)
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
        private void button15_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

            if (operacao == "SOMA")
            {
                txtResultado.Text = Convert.ToString(valor1 + valor2);
            }
            else if (operacao == "SUB")
            {
                txtResultado.Text = Convert.ToString(valor1 - valor2);

            }
            else if (operacao == "MULT")
            {
                txtResultado.Text = Convert.ToString(valor1 * valor2);
            }
            else
            {
                txtResultado.Text = Convert.ToString(valor1 / valor2);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            operacao = "SOMA";
            lblOperacao.Text = "+";
        }
        private void Button17_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            operacao = "SUB";
            lblOperacao.Text= "-";               
        }
        private void button14_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            operacao = "MULT";
            lblOperacao.Text = "X";
        }
        private void button19_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            operacao = "DIV";
            lblOperacao.Text = "/";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            operacao = "CE";
            lblOperacao.Text = "CE";
        }
        private void button10_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            operacao = "C";
            lblOperacao.Text = "C";
        }        
        private void button18_Click(object sender, EventArgs e)
        {
            txtResultado.Text += ".";
        }
    }
}