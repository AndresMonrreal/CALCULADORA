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
            

            for (int i = 0; i < dgvXml.Rows.Count-1; i++)
            {
                 XElement persona = new XElement("Persona");
                 persona.SetAttributeValue("id", dgvXml.Rows[i].Cells[0].Value);
                 persona.SetAttributeValue("Nombre", dgvXml.Rows[i].Cells[1].Value);
                 persona.SetAttributeValue("Telefono", dgvXml.Rows[i].Cells[2].Value);
                 oEle.Add(persona);

                /*oEle.Add(
                    new XElement("Persona",
                    new XAttribute("ID", dgvXml.Rows[i].Cells[0].Value),
                    new XElement("Nombre", dgvXml.Rows[i].Cells[1].Value),
                    new XElement("Telefono", dgvXml.Rows[i].Cells[2].Value)
                    ));
                */
            }
            try
            {
                oEle.Save("Archivo xml");
                MessageBox.Show("Archivo ml guardado correctamente","Sistema",MessageBoxButtons.OK,MessageBoxIcon.Information);
                
            }catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           

        }
    }
}
