using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CALCULADORA
{
    public partial class FormMetodoOrdenamiento : Form
    {
        public FormMetodoOrdenamiento()
        {
            InitializeComponent();
        }

        private void butRandom_Click(object sender, EventArgs e)
        {
            Random rdn = new Random();
            int numeroR = rdn.Next(1, 50);
            int indice = DGVdesordenado.Rows.Add();
            //Selecionamos la fila que se va generando con mi variable indice ,despues seleccionamos la columna y con 
            //value le asignamos el valor que queremos poner
            DGVdesordenado.Rows[indice].Cells[0].Value = numeroR;
        }

    }
}
