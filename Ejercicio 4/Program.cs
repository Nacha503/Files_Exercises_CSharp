using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Ejercicio_4
{
    class Program
    {
        //Write a program that compares two text files with the same number of
        //rows line by line and prints the number of equal and the number of
        //different lines.
        static void Main(string[] args)
        {
            string[] lineasTextoOriginal = ExtraerLineas(@".\LoreIpsumOriginal.txt");
            string[] lineasTextoCopia = ExtraerLineas(@".\LoreIpsumCopia.txt");

            int lineasIguales = CompararLineas(lineasTextoOriginal, lineasTextoCopia, out int lineasDiferentes);
            Console.WriteLine($"Numero de lineas iguales {lineasIguales}\nNumero de lineas diferentes {lineasDiferentes}");


            Console.ReadKey();

        }

        private static int CompararLineas(string[] lineasTextoOriginal, string[] lineasTextoCopia, out int lineasDiferentes)
        {
            int lineasIguales = 0;
            lineasDiferentes = 0;

            for (int i = 0; i < lineasTextoOriginal.Length; i++)
            {
                if (string.Equals(lineasTextoOriginal[i], lineasTextoCopia[i]))
                {
                    lineasIguales++;
                    //Console.WriteLine($"***Texto original***\n{lineasTextoOriginal[i]}\n***Texto copia***\n{lineasTextoCopia[i]}");
                }
                else
                    lineasDiferentes++;
            }


            return lineasIguales;

        }

        private static string[] ExtraerLineas(string v)
        {
            return File.ReadAllLines(v);

        }
    }
}
