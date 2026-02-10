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
        DateTime alarmah;
        bool alarmaActiva = false;
        public FormTemporizadorcs()
        {
            InitializeComponent();
        }


        private void timeHora_Tick(object sender, EventArgs e)
        {

            DateTime ahora = DateTime.Now;
            labHora.Text = ahora.ToString("hh:mm:ss tt");

            if (alarmaActiva &&
                ahora.Hour == alarmah.Hour &&
                ahora.Minute == alarmah.Minute &&
                ahora.Second == alarmah.Second)
            {
                SoundPlayer alarma = new SoundPlayer(
                    @"C:\Universidad\Semestre 4\TopicosAP\GIt\CALCULADORA\CALCULADORA\Sonidos\psychronic-predatory-purpose-407841.wav"
                );
                alarma.Play();
                alarmaActiva = false; 
            }

        }

        private void FormTemporizadorcs_Load(object sender, EventArgs e)
        {
            timeHora.Enabled = true;
        }

        private void mnsAlarma1_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox("Ingrese la hora: ", "Sistema", ("00:00:00 tt"));
            if (DateTime.TryParse(input, out alarmah))
            {
                alarmaActiva = true;
            }
            else
            {
                MessageBox.Show("Formato inválido");
            }

        }
    }
}
