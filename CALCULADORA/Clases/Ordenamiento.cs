using System;
using System.Collections.Generic;
using System.Text;

namespace CALCULADORA.Clases
{
   
    internal class Ordenamiento{
        int[] arreglo;
        public int[] burbuja(int[] arreglo)
        {
            try   
            {
                this.arreglo = arreglo;
                int aux;
                for (int i = 0; i < arreglo.Length -1; i++)
                {
                    for (int j = 0; j < arreglo.Length -1; j++)
                    {
                        if (arreglo[j] > arreglo[j+1])
                        {
                            aux = arreglo[j];
                            arreglo[j] =arreglo[j+1];
                            arreglo[j+1] = aux;
                        }
                    }
                }
                return arreglo;
            }
            catch (Exception e) { 
                throw;
            return null;
            }
        }
    }
}
