using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Ejercicio_3
{
    class Program
    {
        //Write a program that reads the contents of a text file and inserts the
        //line numbers at the beginning of each line, then rewrites the file
        //contents.
        static void Main(string[] args)
        {
            string[] lineasDelDocumento = RecuperarLineaPorLinea();

            string nuevasLineas =  EscribirLineas(lineasDelDocumento);

            CopiarInformacionAlArchivoOriginal(nuevasLineas);

           Console.ReadKey();





        }

        private static void CopiarInformacionAlArchivoOriginal(string nuevasLineas)
        {
            using (StreamWriter miStreamWriter = new StreamWriter(@".\LoreIpsum.txt"))
            {
                miStreamWriter.Write(nuevasLineas);

            }
        }

        private static string EscribirLineas(string[] lineasDelDocumento)
        {
            StringBuilder uniendoLineas = new StringBuilder();

            for (int i = 0; i < lineasDelDocumento.Length; i++)
            {
                using (StreamWriter miStreamWriter = new StreamWriter(@".\LoreIpsumAuxiliar.txt", true))
                {
                    miStreamWriter.Write(uniendoLineas.Append(string.Format($"{i + 1} {lineasDelDocumento[i]}\n")));

                }

            }

            return uniendoLineas.ToString();

        }

        private static string[] RecuperarLineaPorLinea()
        {
            string[] lineasDelArchivo;
            lineasDelArchivo = File.ReadAllLines(@".\LoreIpsum.txt");

            return lineasDelArchivo;
        }
    }
}
