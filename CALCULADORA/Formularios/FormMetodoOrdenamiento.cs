using CALCULADORA.Clases;
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

        private void butOrdenado_Click(object sender, EventArgs e)
        {
            Ordenamiento ordenamiento = new Ordenamiento();
  
            int[] arreglo = new int[DGVdesordenado.Rows.Count];

            for (int i = 0; i < DGVdesordenado.Rows.Count; i++)
            {
                arreglo[i] = Convert.ToInt32(DGVdesordenado.Rows [i].Cells[0].Value);
            }
            arreglo = ordenamiento.burbuja(arreglo);
            DGVOrdenado.Rows.Clear(); 

            for (int i = 0; i < arreglo.Length; i++)
            {
                int fila = DGVOrdenado.Rows.Add();
                DGVOrdenado.Rows[fila].Cells[0].Value = arreglo[i];
            }

        }
    }
}
