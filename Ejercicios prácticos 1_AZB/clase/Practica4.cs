using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_prácticos_1_AZB.clase
{
    internal class Practica4
    {
        public void array_4()
        {
            Console.WriteLine("Ingrese el tamaños del arreglo");
            int Numeros = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese un numero");
            int Multiplo = Convert.ToInt32(Console.ReadLine());

            int[] Multiplos = new int[Numeros];

            int respuesta = 0;
            for(int i = 0; i < Numeros; i++)
            {
                Console.WriteLine(respuesta = respuesta + Multiplo);
            }
            

        }


    }
}
