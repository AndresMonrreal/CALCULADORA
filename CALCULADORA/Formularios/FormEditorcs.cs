using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CALCULADORA.Formularios
{
    public partial class FormEditorcs : Form
    {
        int contador = 0;
        int contadorPalabras = 0;
        bool saved = false;
        string path = "";
        string texto = "";
        public FormEditorcs()
        {
            InitializeComponent();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (odfEditor.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(odfEditor.FileName))
                {
                    rtbEditor.Text = File.ReadAllText(odfEditor.FileName);
                }
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saved == false)
            {
                Guardar();
                saved = true;
            }
            else
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.Write(rtbEditor.Text);
                }
            }

        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbEditor.Clear();
            path = "";
            saved = false;
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Guardar();
        }


        private void Guardar()
        {
            if (sfdEditor.ShowDialog() == DialogResult.OK)
            {
                path = sfdEditor.FileName;
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.Write(rtbEditor.Text);
                }

            }
        }

        private void rtbEditor_TextChanged(object sender, EventArgs e)
        {
            texto = rtbEditor.Text;
            string[] palabras = texto.Split(new char[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            stsEditar.Text = palabras.Length.ToString() + "palabras";
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();


        }

        private void tssEditor_Click(object sender, EventArgs e)
        {
            string[] palabras = texto.Split(new char[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            string[] parrafos = texto.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            MessageBox.Show("Estadisticas:\n\nPalabras: "
                + palabras.Length.ToString()
                + "\nLetras: " + texto.Length.ToString()
                + "\nParrafos: "
                + parrafos.Length.ToString(), "Contador de Palabras");
        }
    }

}
