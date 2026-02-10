using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Media;

namespace CALCULADORA.Formularios
{
    public partial class FormTemporizadorcs : Form
    {
        string Alarma1 = "";
        
        public FormTemporizadorcs()
        {
            InitializeComponent();
        }


        private void timeHora_Tick(object sender, EventArgs e)
        {
            labHora.Text = DateTime.Now.ToString("hh:mm:ss tt");
            if (labHora.Text == Alarma1)
            {
                SoundPlayer alarma = new SoundPlayer("C:\\Universidad\\Semestre 4\\TopicosAP\\GIt\\CALCULADORA\\CALCULADORA\\Sonidos\\psychronic-predatory-purpose-407841.wav");
                alarma.Play();
            }

        }

        private void FormTemporizadorcs_Load(object sender, EventArgs e)
        {
            timeHora.Enabled = true;
        }

        private void mnsAlarma1_Click(object sender, EventArgs e)
        {
            Alarma1 = Interaction.InputBox("Ingrese la hora: ", "Sistema", ("00:00:00 tt"));

        }
    }
}
