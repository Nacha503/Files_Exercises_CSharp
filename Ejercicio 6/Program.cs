using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    class Program
    {
        //Write a program that reads a list of names from a text file, arranges
        //them in alphabetical order, and writes them to another file.The lines
        //are written one per row.
        static void Main(string[] args)
        {
            string lineasSinCaracteresDeSeparacion = QuitarEspaciosInnecesarios(@".\ListOfNames.txt");

            //string resultadoFinal = OrdenarNombres(lineasSinCaracteresDeSeparacion);

            Console.WriteLine("Resultado Final\n\n{0}",lineasSinCaracteresDeSeparacion);
            Console.ReadKey();


        }

        static string OrdenarNombres(string listaDeNombres)
        {
            string nombresOrdenados = null;




            return nombresOrdenados;
        }

        static string QuitarEspaciosInnecesarios(string pathFile)
        {
            string[] lineaLimpia = null;
            string lineaLeida;
            StringBuilder nombresConcatenados = new StringBuilder();


            using (StreamReader sReader = new StreamReader(pathFile))
            {
                while ((lineaLeida = sReader.ReadLine()) != null)
                {
                    lineaLimpia = lineaLeida.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

                    foreach (string item in lineaLimpia)
                    {
                        nombresConcatenados.Append(item + " ");

                    }
                }
            }



            return nombresConcatenados.ToString();
        }

     
    }
}
