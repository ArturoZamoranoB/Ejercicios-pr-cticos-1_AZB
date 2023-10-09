using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_prácticos_1_AZB.clase
{
    internal class Practica3
    {
        public void array_3()
        {
            int[] numeros = new int[10] ;
            double suma = 0;
            double respuesta;
            for ( int i = 0; i < numeros.Length; i++)
            {

                Console.WriteLine("Escriba un numero");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
                suma = suma + numeros[i];
            }
             Console.WriteLine($"La media es {respuesta = suma / 10} ");
        }
    }
}

