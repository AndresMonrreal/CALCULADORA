namespace CALCULADORA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double a = 0;
        double b = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            txtTexto.Text = "0";
        }

        private void txtTexto_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTexto.Text == "o") txtTexto.Text = "";
            txtTexto.Text += "1";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtTexto.Text == "0") txtTexto.Text = "";
            txtTexto.Text += "4";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (txtTexto.Text == "6") txtTexto.Text = "";
            txtTexto.Text += "6";
        }

        private void button10_Click(object sender, EventArgs e)
        {

            if (txtTexto.Text == "0") txtTexto.Text = "";
            txtTexto.Text += "0";
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (txtTexto.TextLength == 1) txtTexto.Text = "o";
            else (txtTexto.TextLength != 1) t
        }

        private void butResta_Click(object sender, EventArgs e)
        {

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

        }

        private void butEliminar_Click(object sender, EventArgs e)
        {
            txtTexto.Text = " 0";
            a = 0;
            b = 0;
        }
    }
}
