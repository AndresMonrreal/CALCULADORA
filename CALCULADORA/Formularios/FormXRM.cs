using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CALCULADORA.Formularios
{
    public partial class FormXRM : Form
    {
        public FormXRM()
        {
            InitializeComponent();
        }

        private void butGuardar_Click(object sender, EventArgs e)
        {
            XElement oEle = new XElement("Root");
            

            for (int i = 0; i < dgvXml.Rows.Count; i++)
            {
                XElement persona = new XElement("Persona");
                oEle.SetAttributeValue("id", dgvXml.Rows[i].Cells[0].Value);
                oEle.SetAttributeValue("Nombre", dgvXml.Rows[i].Cells[1].Value);
                oEle.SetAttributeValue("Telefono", dgvXml.Rows[i].Cells[2].Value);
                oEle.Add(persona);

            }
            oEle.Save("Archivo xml");

        }
    }
}
