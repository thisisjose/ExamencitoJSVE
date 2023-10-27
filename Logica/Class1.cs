using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamencitoJSVE.Logica
{
    internal class Class1
    {
        public void Ejercicio3()
        {

            //Imprima la matriz desordenada.
            //Ordena la matriz de forma descendente utilizando el método de ordenamiento selección.
            //Imprima el matriz ordenada.
            //Busque el número 75 en la matriz ordenada utilizando una búsqueda binaria.
            //Imprima la posición del número 75 en la matriz, si se encuentra o un texto que le informe al usuario que el valor no se encuentra.
            //Console.WriteLine("Matriz desordenada");

            int[] lista = new int[100];
            for (int i = 0; i < lista.Length; i++)
            {
                Console.WriteLine("Escribir los numeros del 1 al 100"); 
                lista[i] = Convert.ToInt32(Console.ReadLine());
            }
            int menor = 0;
            int pos = 0;
            int temp = 0;
            for (int i = 0; i < lista.Length - 1; i++)
            {
                menor = lista[i];
                pos = i;
                for (int j = i + 1; j < lista.Length; j++)
                {
                    if (lista[j] < menor)
                    {
                        menor = lista[j];
                        pos = j;
                    }

                }
                if (pos != i)
                {
                    temp = lista[i];
                    lista[i] = lista[pos];
                    lista[pos] = temp;
                }
            }
            Console.WriteLine("La lista ordenada es ");
            for(int i=0; i < lista.Length; i++)
            {
                Console.WriteLine(lista[i]);
            }
            Console.WriteLine("El orden descendente es: ");
            for (int i = lista.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(lista[i]);
            }
        }
        //Aqiu haremos la busquedad binaria del numero 75
        public void Ejercicio3Binaria()
        {
            int[] orden = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100};

                Console.WriteLine("Ponme el numerito que quereis buscar chaval: ");
                int buscarN = Convert.ToInt32(Console.ReadLine());

                int inicio = 0;
                int fin = orden.Length - 1;
                int posicion = -1;

                while (inicio <= fin)
                {
                    int medio = (inicio + fin) / 2;

                    if (orden[medio] == buscarN)
                    {
                        posicion = medio;
                        break;
                    }
                    else if (orden[medio] < buscarN)
                    {
                        inicio = medio + 1;
                    }
                    else
                    {
                        fin = medio - 1;
                    }
                }

                if (posicion != -1)
                {
                    Console.WriteLine($"Tu numero {buscarN} se encuentra en la posicion {posicion}");
                }
                else
                {
                    Console.WriteLine($"Tu numero {buscarN} no se encuentra en el arreglo");
                }
        }

        //public void Ejercicio1()
        //{
        //    Console.WriteLine("Ingresar que vendedor eres: ");
        //    int vendedor;
        //    vendedor= Convert.ToInt32(Console.ReadLine());
        //    for(int i =0; i<vendedor;i++)
        //    {
                
        //    }
        //}
     }
}

