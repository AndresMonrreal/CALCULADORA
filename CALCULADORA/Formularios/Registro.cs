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
                Nombre=labNombre.Text,
                Apellido=labApellido.Text,  
                fecha1=dtpFechaNacimiento.Value
            });
            
        }
    }
}
