using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Ejercicio_2
{
    class Program
    {
        //Write a program that joins two text files and records the results in a third file.

        static void Main(string[] args)
        {
            string contenidoArchivo1, contenidoArchivo2, contenidoFinal;

            contenidoArchivo1 = RecuperarArchivo1();
            contenidoArchivo2 = RecuperarArchivo2();

            contenidoFinal = UnirArchivos(contenidoArchivo1, contenidoArchivo2);

            Console.WriteLine(contenidoFinal);

            Console.ReadKey();



        }

        private static string UnirArchivos(string contenidoArchivo1, string contenidoArchivo2)
        {
            return contenidoArchivo1 +"\n"+ contenidoArchivo2;
        }

        private static string RecuperarArchivo2()
        {
            return File.ReadAllText(@".\Archivo 2.txt");

        }

        private static string RecuperarArchivo1()
        {
            return File.ReadAllText(@".\Archivo 1.txt");
        }
    }
}
