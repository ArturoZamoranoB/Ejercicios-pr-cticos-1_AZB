using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_prácticos_1_AZB.clase
{
    internal class Practica5
    {
        public void array_5()
        {
            Console.WriteLine("Ingrese el tamaños del arreglo");
            int X = Convert.ToInt32(Console.ReadLine());

            string[] Nombres = new string[X];
            int[] Longitud = new int[X];
            
            for (int i = 0; i < X; i++)
            {
                Console.WriteLine("Escriba un nombre");
                Nombres[i] = Console.ReadLine();
                Longitud[i] = Nombres[i].Length;

                Console.WriteLine("Nombre:  " + Nombres[i] + "  Longitud = " + Longitud[i]);

            }


        }

    }
}
/*Crea dos arrays o arreglos unidimensionales que tengan el mismo tamaño (lo pedirá por teclado),
 * en uno de ellos almacenaras nombres de personas como cadenas, en el otro array o arreglo ira almacenando la longitud de los nombres, 
 * para ello puedes usar la función Length. Muestra por pantalla el nombre y la longitud que tiene. Puedes usar funciones si lo deseas.*/