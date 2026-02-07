using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CALCULADORA.Formularios
{
    public partial class FormTemporizadorcs : Form
    {
        public FormTemporizadorcs()
        {
            InitializeComponent();
        }


        private void timeHora_Tick(object sender, EventArgs e)
        {
            labHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void FormTemporizadorcs_Load(object sender, EventArgs e)
        {
            timeHora.Enabled = true;
        }
    }
}
