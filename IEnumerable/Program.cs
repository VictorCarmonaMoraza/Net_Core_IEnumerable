using System;
using System.Collections.Generic;
using System.Linq;

namespace IEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creacion de un array 
            int[] valoresNumericos = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] valoresNumericos2 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //Lista para almacenar los numeros
            List<int> numerosPares = new List<int>();
            


            //--Parte tradicional
            //
            //Recorremos el array y imprimimos sus elementos
            foreach (int i in valoresNumericos)
            {
                if (i%2==0)
                {
                    numerosPares.Add(i);
                }
            }

            //Recorro la lista de numeros pares y los imprimo
            foreach (var item in numerosPares)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---------------------------");

            //--Con Linq
            IEnumerable<int> numerosPares2 = from numero in valoresNumericos2 where numero % 2 == 0 select numero;

            //Recorro la lista de numeros pares y los imprimo
            foreach (var item in valoresNumericos2)
            {
                Console.WriteLine(item);
            }
        }
    }
}
