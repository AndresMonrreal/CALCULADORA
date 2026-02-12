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
        public bool saved = false;
        public string path = "";
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

        }
    }

}
