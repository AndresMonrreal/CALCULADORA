using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CALCULADORA.Formularios
{
    public partial class FormContador : Form
    {
        int contador = 0;
        public FormContador()
        {
            InitializeComponent();
        }

        private void tkbVelocidad_Scroll(object sender, EventArgs e)
        {
            tmrContador.Interval = tkbVelocidad.Value * 200;
        }

        private void tmrContador_Tick(object sender, EventArgs e)
        {
            contador++;
            lblCuenta.Text = contador.ToString();

        }

        private void butIniciar_Click(object sender, EventArgs e)
        {
            tkbVelocidad.Enabled = true;
            tmrContador.Interval = tkbVelocidad.Value * 200;
            tmrContador.Enabled = true;
            tmrContador.Start();
        }

        private void butDetener_Click(object sender, EventArgs e)
        {
            tmrContador.Enabled = false;
            tkbVelocidad.Enabled = false;

        }
    }
}
