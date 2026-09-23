using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerciciosemana2
{
    internal class Program
    {
        static public int[] generar_aleatorios(int n, int Valmin, int Valmax)
        {
            int[] N = new int[n];
            Random Var_random = new Random();
            for (int i = 0; i < n; i++)
            {
                N[i] = Var_random.Next(Valmin, Valmax);
            }
            return N;
        }

        static public void escribir(int[] N)
        {
            for (int i = 0; i < N.Length; i++)
            {
                Console.WriteLine("[" + N[i] + "]\t");
            }
        }

        static public void orden_seleccion(int[] N)
        {
            int aux;
            for (int i = 0; i < N.Length - 1; i++)
            {
                int minimo = i;
                for (int j = i + 1; j < N.Length; j++)
                {
                    if (N[j] < N[minimo])
                    {
                        minimo = j;
                    }

                }
                aux = N[i];
                N[i] = N[minimo];
                N[minimo] = aux;



            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Cuantos numeros aleatorios desea generar:");
            int n = int.Parse(Console.ReadLine());
            int[] arreglo = generar_aleatorios(n, 0, 20);
            Console.WriteLine("LISTA DE ALEATORIOS");
            escribir(arreglo);
            Console.WriteLine("*************************************");
            Console.WriteLine("ORDENAMIENTO ASCENDENTE POR SELECCION");
            Console.WriteLine("*************************************");
            orden_seleccion(arreglo);
            escribir(arreglo);
            Console.ReadKey();

        }
    }
}