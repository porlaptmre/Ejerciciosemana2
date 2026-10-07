using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerciciosemana8
{
    internal class Program
    {
        static int max = 100;



        static string[] nombres = new string[max];



        static double[] notas = new double[max];



        static int contador = 0;



        static public void titulo()



        {



            Console.WriteLine("Sistema de Gestión de Notas");



        }



        static public void registrar_estudiante()



        {



            Console.WriteLine("Resgistro de Estudiante Nuevo: ");



            if (contador >= 100)



            {



                Console.WriteLine("Alcanzo la Capacidad Maxima");



                return;



            }



            Console.Write("Ingresar Nombre del Estudiante: ");



            string nombre = Console.ReadLine();



            double nota;



            while (true)



            {



                Console.Write("Ingresar Nota[0-20]: ");



                nota = double.Parse(Console.ReadLine());



                if (nota >= 0 && nota <= 20)



                {



                    break;



                }



                Console.WriteLine("Error volver a ingresar la nota[0-20]. ");



            }



            nombres[contador] = nombre;



            notas[contador] = nota;



            contador++;



            Console.WriteLine("Registro con exito...!!");



        }



        static public void buscar_estudiante()

        {

            Console.WriteLine("Buscar Estudiante");

            if (contador == 0)

            {

                Console.WriteLine("No hay estudiantes registardos");

                return;

            }

            Console.Write("Ingresar nombre a buscar: ");

            string nom_buscar = Console.ReadLine().ToLower();

            bool encontrado = false;

            for (int i = 0; i < contador; i++)

            {

                if (nombres[i].ToLower() == nom_buscar)

                {

                    Console.WriteLine("Estudiante Encontrado: ");

                    Console.WriteLine(nombres[i] + "tiene" + notas[i]);

                    encontrado = true;

                    break;

                }

            }

            if (!encontrado)

                Console.WriteLine("Estudiante No Encontrado...");

        }

        static public void modificar_nota()

        {

            Console.WriteLine("Modificar Nota");

            if (contador == 0)

            {

                Console.WriteLine("No hay estudiantes registrados");

                return;

            }

            Console.Write("Ingresar nombre del estudiante: ");

            string nom_buscar = Console.ReadLine().ToLower();

            for (int i = 0; i < contador; i++)

            {

                if (nombres[i].ToLower() == nom_buscar)

                {

                    Console.WriteLine(nombres[i] + " tiene " + notas[i]);

                    double nueva_nota;

                    while (true)

                    {

                        Console.Write("Ingresar la nueva nota: ");

                        nueva_nota = double.Parse(Console.ReadLine());

                        if (nueva_nota >= 0 && nueva_nota <= 20)

                        {

                            notas[i] = nueva_nota;

                            Console.WriteLine("Nota Modificada Correctamente");

                            return;

                        }

                        Console.WriteLine("Nota fuera de rango[0-20]");

                    }

                }

            }

            Console.WriteLine("Estudiante no encontrado...");

        }

        static public void mostrar()

        {

            Console.WriteLine("Listado Original");

            if (contador == 0)

            {

                Console.WriteLine("No hay estudiantes registrados");

                return;

            }

            Console.WriteLine("\tNOMBRE \t\tNOTAS");

            for (int i = 0; i < contador; i++)

            {

                Console.WriteLine("\t" + nombres[i] + "\t\t" + notas[i]);

            }

        }

        static public void burbuja()

        {

            Console.WriteLine("ORDENAMIENTO ASCENDENTE");

            double temp_nota;

            string temp_nombre;

            for (int i = 0; i < contador; i++)

            {

                for (int j = 0; j < contador - 1 - i; j++)

                {

                    if (notas[j] > notas[j + 1])

                    {

                        temp_nota = notas[j];

                        notas[j] = notas[j + 1];

                        notas[j + 1] = temp_nota;



                        temp_nombre = nombres[j];

                        nombres[j] = nombres[j + 1];

                        nombres[j + 1] = temp_nombre;

                    }

                }

            }



        }

        static public void seleccion_desc()

        {

            Console.WriteLine("ORDENAMIENTO DESCENDENTE");

            double temp_nota;

            string temp_nombre;

            int max;



            for (int i = 0; i < contador - 1; i++)

            {

                max = i;

                for (int j = i + 1; j < contador; j++)

                {

                    if (notas[j] > notas[max])

                    {

                        max = j;

                    }

                }



                temp_nota = notas[i];

                notas[i] = notas[max];

                notas[max] = temp_nota;



                temp_nombre = nombres[i];

                nombres[i] = nombres[max];

                nombres[max] = temp_nombre;



            }

        }

        static public void nota_max_prom()

        {

            Console.WriteLine("NOTA MÁXIMA");



            if (contador == 0)

            {

                Console.WriteLine("No hay registros ingresados.");

                return;

            }



            double nota_max = notas[0];

            string nombre_max = nombres[0];



            for (int i = 1; i < contador; i++)

            {

                if (notas[i] > nota_max)

                {

                    nota_max = notas[i];

                    nombre_max = nombres[i];

                }

            }



            Console.WriteLine($"La nota máxima es: {nota_max}");

            Console.WriteLine($"Pertenece al estudiante: {nombre_max}");

        }

        static void Main(string[] args)

        {

            titulo();

            int opc = 0;

            while (opc != 7)

            {

                Console.WriteLine("MENU PRINCIPAL");

                Console.WriteLine("[1]Registrar estudiante");

                Console.WriteLine("[2]Buscar estudiante");

                Console.WriteLine("[3]Modificar nota");

                Console.WriteLine("[4]Mostrar lista sin ordenar");

                Console.WriteLine("[5]Ordenar con Burbuja");

                Console.WriteLine("[6]Ordenar con Seleccion");

                Console.WriteLine("[7]Salir");

                Console.Write("Ingresar opción: ");

                opc = int.Parse(Console.ReadLine());

                switch (opc)

                {

                    case 1:

                        registrar_estudiante();

                        break;

                    case 2:

                        buscar_estudiante();

                        break;

                    case 3:

                        modificar_nota();

                        break;

                    case 4:

                        mostrar();

                        break;

                    case 5:

                        burbuja();

                        break;

                    case 6:

                        seleccion_desc();

                        break;

                    case 7:

                        Console.WriteLine("Gracias por usar el sistema");

                        break;

                    default:

                        Console.WriteLine("Opción incorrecta...!!");

                        break;



                }

                Console.ReadKey();

            }

        }



        }
    }
