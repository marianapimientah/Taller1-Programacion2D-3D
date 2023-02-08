using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace TallerArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Crear un array de 10 posiciones, con valores puestos por defecto e imprimir el array.

            int[] numerosPares = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };

            Console.WriteLine("Punto 1: ");

            for (int indice = 0; indice < numerosPares.Length; indice++)
            {
                int elemento = numerosPares[indice];
                Console.WriteLine(elemento);
            }

            //2.Sumar los valores de un array y mostrar el resultado.

            int[] numerosImpares = { 1, 3, 5, 7, 9};

            int sum = 0;
            for ( int i = 0 ; i < numerosImpares.Length; i++)
            {
                sum += numerosImpares[i];
            }
            Console.WriteLine("Punto 2: " + sum);

            //3.Hacer la media de los valores de un array y mostrar el resultado.

            double media = (double) sum / numerosImpares.Length;

            Console.WriteLine("Punto 3: " + media);

            //4.Dado un array de números con el método Sort, ordenarlos y mostrar su contenido.
            
            int[] arrayDesordenado = {60, 50, 40, 30, 20, 10};
            
            Array.Sort(arrayDesordenado);
            
            Console.WriteLine("Punto 4: " + string.Join(", ", arrayDesordenado));

            //5.Dado un array de números, mostrar el mayor y el menor.

            int max = arrayDesordenado[0], min = arrayDesordenado[0];

            for(int i = 0; i < arrayDesordenado.Length; i++)
            {
                if (arrayDesordenado[i] > max)

                    max = arrayDesordenado[i];
                
                else if (arrayDesordenado[i] < min)

                    min = arrayDesordenado[i];
                
            }
            Console.WriteLine("Punto 5: ");
            Console.WriteLine("El mayor número es: " + max);
            Console.WriteLine("El menor número es: " + min);

            //6.Crear un arreglo multidimensional de 3x3 de la siguiente manera:100010001.
            
            Console.WriteLine("Punto 6: ");

            int[,] array2D = new int[3, 3];
        
            for (int i = 0; i < 3; i++)
            {    
                Console.WriteLine("\n");
                for (int j = 0; j < 3; j++)
                {
                    if(i==j){
                        array2D[i,j] = 1;
                    }else{
                        array2D[i,j] = 0;
                    }
                    Console.Write(array2D[i, j] + " ");
                }
            }
        }

    }

}