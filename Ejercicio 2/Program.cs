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

            //contenidoFinal = 
            UnirArchivos(contenidoArchivo1, contenidoArchivo2);
            //Console.WriteLine("Se recupero la informacion de dos archivos y se unio en una sola cadena de caracteres "+contenidoFinal);





            Console.ReadKey();



        }

        private static void UnirArchivos(string contenidoArchivo1, string contenidoArchivo2)
        {
            using (StreamWriter wr = new StreamWriter(@".\Archivo Final.txt"))
            {
                Console.WriteLine("USANDO UN STREAMWRITER para unir dos archivos\n\n");
                wr.Write(contenidoArchivo1 + contenidoArchivo2);
                
            }
            Console.Write(File.ReadAllText(@".\Archivo Final.txt"));
            //return contenidoArchivo1 +"\n"+ contenidoArchivo2;
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
