using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace CALCULADORA.Clases
{
    internal class Persona
    {
        private DateTime fecha;
        private String nombre="";
        private String apellido="";
        private int edad;

      

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Edad { get => edad=DateTime.Now.Year-fecha.Year; set => edad = value; }
        public DateTime fecha1 { get => fecha; set => fecha = value; }
    }
}
