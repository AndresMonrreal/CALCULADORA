using Microsoft.VisualBasic;
using System.ComponentModel;

namespace CALCULADORA
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }
        double numero1 = 0;
        double numero2 = 0;
        char operador;

        private void Form1_Load(object sender, EventArgs e)
        {
            txtTexto.Text = "0";
        }

        private void txtTexto_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTexto.Text == "0") txtTexto.Text = "";
            txtTexto.Text += "1";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtTexto.Text == "0") txtTexto.Text = "";
            txtTexto.Text += "4";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (txtTexto.Text == "0") txtTexto.Text = "";
            txtTexto.Text += "6";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            txtTexto.Text += "0";
        }

        private void buttonDe_Click(object sender, EventArgs e)
        {
            //Lo que hace el substring es para obtener una parte del text de mi txtxTexto
            if (txtTexto.TextLength == 1) txtTexto.Text = "0";
            else txtTexto.Text = txtTexto.Text.Substring(0, txtTexto.TextLength - 1);
        }

        private void butResta_Click(object sender, EventArgs e)
        {
            operador = '-';
            numero1 = Convert.ToDouble(txtTexto.Text);
            txtTexto.Text = "0";
        }

        private void but2_Click(object sender, EventArgs e)
        {
            if (txtTexto.Text == "0") txtTexto.Text = "";
            txtTexto.Text += "2";
        }

        private void but3_Click(object sender, EventArgs e)
        {
            if (txtTexto.Text == "0") txtTexto.Text = "";
            txtTexto.Text += "3";
        }

        private void but5_Click(object sender, EventArgs e)
        {
            if (txtTexto.Text == "0") txtTexto.Text = "";
            txtTexto.Text += "5";
        }

        private void but7_Click(object sender, EventArgs e)
        {
            if (txtTexto.Text == "0") txtTexto.Text = "";
            txtTexto.Text += "7";
        }

        private void but8_Click(object sender, EventArgs e)
        {
            if (txtTexto.Text == "0") txtTexto.Text = "";
            txtTexto.Text += "8";
        }

        private void but9_Click(object sender, EventArgs e)
        {
            if (txtTexto.Text == "0") txtTexto.Text = "";
            txtTexto.Text += "9";
        }

        private void butPunto_Click(object sender, EventArgs e)
        {
            //El contains pues es para verificar si es que ya existe ese caracter en mi archivo
            if (!txtTexto.Text.Contains(".")) txtTexto.Text += ".";
        }

        private void butEliminar_Click(object sender, EventArgs e)
        {
            txtTexto.Text = "0";
            numero1 = 0;
            numero2 = 0;
        }

        private void butSuma_Click(object sender, EventArgs e)
        {
            operador = '+';
            numero1 = Convert.ToDouble(txtTexto.Text);
            txtTexto.Text = "0";
        }

        private void butMultiplicar_Click(object sender, EventArgs e)
        {
            operador = '*';
            numero1 = Convert.ToDouble(txtTexto.Text);
            txtTexto.Text = "0";
        }

        private void butDIvision_Click(object sender, EventArgs e)
        {
            operador = '/';
            numero1 = Convert.ToDouble(txtTexto.Text);
            txtTexto.Text = "0";
        }

        private void butResto_Click(object sender, EventArgs e)
        {
            operador = '%';
            numero1 = Convert.ToDouble(txtTexto.Text);
            txtTexto.Text = "0";

        }

        private void butIgual_Click(object sender, EventArgs e)
        {
            numero2 = Convert.ToDouble(txtTexto.Text);
            double resultado = 0;
            switch (operador)
            {
                case '+':
                    resultado = numero1 + numero2;
                    break;
                case '-':
                    resultado = numero1 + numero2;
                    break;
                case '*':
                    resultado = numero1 * numero2;
                    break;
                case '/':
                    if(numero2 != 0)
                    {
                        resultado = numero1 / numero2;
                    }
                    else
                    {
                        MessageBox.Show("No se puede dividir por 0","Eror de calculo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        return;
                    }

                        break;
                case '%':
                    if(numero2 != 0)
                    {
                        resultado = numero1 % numero2;
                    }
                    else
                    {
                        MessageBox.Show("No se puede calcular el residuo de 0","Error de calculo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        return;
                    }

                        break;
                default:
                    MessageBox.Show("Operacion invalida");
                    break;    

            }

            txtTexto.Text = resultado.ToString();
        }
    }
}
