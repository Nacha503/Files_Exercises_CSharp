using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    class Program
    {
        //Write a program that replaces every occurrence of the substring "start" with "finish" in a text file.
        static void Main(string[] args)
        {


            string[] soloPalabras = RecuperarTexto();

            string patron = "start";
            Regex miRegex = new Regex(patron);
            MatchEvaluator miMatch = new MatchEvaluator(ModificarSubCadend);

            StringBuilder sb = new StringBuilder();

            foreach (string item in soloPalabras)
            {
                sb.Append(miRegex.Replace(item, miMatch)+" ");
            }

            Console.WriteLine($"{sb.ToString()}");


            Console.ReadKey();


        }

        private static string ModificarSubCadend(Match m)
        {
            return "Finish";
        }

        private static string[] RecuperarTexto()
        {
            string recuperaTodoElTexto;
            string[] soloPalabras;
            using (StreamReader sReader = new StreamReader(@".\Palabras De Prueba.txt"))
            {
                recuperaTodoElTexto = sReader.ReadToEnd();
                soloPalabras = recuperaTodoElTexto.Split(new char[] { ' ', ',', '!', '-', '^','.' }, StringSplitOptions.RemoveEmptyEntries);
            }

            return soloPalabras;
        }
    }
}
