using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_prácticos_1_AZB.clase
{
    internal class Practica2
    {
        public void array2()
        {
            
            int[] numeros = new int[] { 1, 2, 3, 4, 5 };
           

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Escriba un numero");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);
            }
        }
    }
}
