using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ejercicio_1
{
    class Program
    {
        //Write a program that reads a text file and prints its odd lines on the
        //console
        private static string textoPreProcesado;
        private static StringBuilder textoFinal = new StringBuilder();


        static void Main(string[] args)
        {
            string texto = LeerLineasImpares();
            ImprimirLineasImpares(texto);

            Console.ReadKey();



        }


        // no me imprime las lineas impares T_T

        public static string LeerLineasImpares()
        {
            int numeroDeLinea = 1;
            using (StreamReader lectorDeTexto = new StreamReader(@".\LoreIpsum.txt"))
            {
                do
                {
                    if ((numeroDeLinea % 2) != 0)
                    {
                        textoPreProcesado = lectorDeTexto.ReadLine();
                        textoFinal.Append(textoPreProcesado + "\n");
                        numeroDeLinea++;
                    }
                    else
                    {
                        //textoPreProcesado = null;
                        numeroDeLinea++;
                    }


                } while (textoPreProcesado != null);

            }

            return textoFinal.ToString();


        }

        public static void ImprimirLineasImpares(string lineasImpares)
        {
            Console.WriteLine(lineasImpares);

        }


    }
}
