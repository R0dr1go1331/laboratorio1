using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio1
{
    namespace Laboratorio1
    {
        class Program
        {
            static void Main(string[] args)
            {
                string nombre, departamento, municipio;
                int edad;
                string[] municipiosPorDepartamento;


                string[,] datos = new string[3, 4];

                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Ingrese los siguientes datos para la persona " + (i + 1));
                    Console.Write("Nombre: ");
                    nombre = Console.ReadLine();
                    Console.Write("Edad: ");
                    edad = int.Parse(Console.ReadLine());
                    Console.Write("esbribe el  departamento donde perteneces ejemplo : San Salvador, Morazan, Chalatengo, San Miguel, La Union. elige el Departamento :  ");
                    departamento = Console.ReadLine();
                    Console.Write("Municipio: ");
                    municipio = Console.ReadLine();


                    municipiosPorDepartamento = ObtenerMunicipiosPorDepartamento(departamento);
                    while (!Array.Exists(municipiosPorDepartamento, element => element == municipio))
                    {
                        Console.WriteLine("El municipio ingresado no pertenece al departamento seleccionado.");
                        Console.Write("Municipio: ");
                        municipio = Console.ReadLine();
                    }


                    datos[i, 0] = nombre;
                    datos[i, 1] = edad.ToString();
                    datos[i, 2] = departamento;
                    datos[i, 3] = municipio;
                }


                Console.WriteLine("Edades de las personas ingresadas:");
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine(datos[i, 1]);
                }

                Console.ReadKey();
            }


            static string[] ObtenerMunicipiosPorDepartamento(string departamento)
            {
                string[] municipios;

                switch (departamento)
                {
                    case "San Salvador":
                        municipios = new string[] { "Apopa", "Cuscatancingo", "Ciudad Delgado" };
                        break;
                    case "Morazan":
                        municipios = new string[] { "San Isidro", "San simon", "San Isidro" };
                        break;
                    case "Chalatengo":
                        municipios = new string[] { "San Bartolo", "Tejutla", "Chalatengo" };
                        break;
                    case "San Miguel":
                        municipios = new string[] { "Cuidad Barrios", "Chilameca", "San Antonio" };
                        break;
                    case "La Union":
                        municipios = new string[] { "El carmen", "El Sauce", "Bolivar" };
                        break;

                    default:
                        municipios = new string[] { };
                        break;
                }

                return municipios;
            }
        }
    }
}
