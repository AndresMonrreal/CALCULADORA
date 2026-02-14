using CALCULADORA.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CALCULADORA
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCalculadora oFCalculadora = new FormCalculadora();
            oFCalculadora.Show();
        }

        private void metodoOrdenamientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMetodoOrdenamiento oFMetodoOrdenamiento = new FormMetodoOrdenamiento();
            oFMetodoOrdenamiento.Show();
        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRegistro oFr = new FormRegistro();
            oFr.Show();
        }

        private void temporizadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTemporizadorcs oFTem = new FormTemporizadorcs();
            oFTem.Show();
        }

        private void editorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEditor oFEditor = new FormEditor();
            oFEditor.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void contadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormContador oFc = new FormContador();
            oFc.Show();
        }
    }
}
