using CALCULADORA.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CALCULADORA.Formularios
{
    public partial class FormRegistro : Form
    {
        List<Persona> persona = new List<Persona>();
        public FormRegistro()
        {
            InitializeComponent();
        }
        private void butRegistrar_Click(object sender, EventArgs e)
        {
            persona.Add(new Persona()
            {
                Nombre = tbNombre.Text,
                Apellido = tbApellido.Text,
                fecha1 = dtpFechaNacimiento.Value
            });

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                dataGridViewPersonas.DataSource = null;
                dataGridViewPersonas.DataSource = persona;
                verificarRegistro();
            }
        }

        private void verificarRegistro()
        {
            if (persona.Count == 0) butEliminar.Enabled = false;
            else butEliminar.Enabled = true;

        }

        private void butEliminar_Click(object sender, EventArgs e)
        {
            persona.RemoveAt(dataGridViewPersonas.CurrentRow.Index);
            dataGridViewPersonas.DataSource = null;
            dataGridViewPersonas.DataSource = persona;
            verificarRegistro();

        }
    }


}
