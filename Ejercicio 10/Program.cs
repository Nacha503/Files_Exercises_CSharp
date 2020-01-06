using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    class Program
    {
        //Write a program that extracts from an XML file the text only(without the tags). Sample input file:
        //<?xml version = "1.0" >< student >< name > Peter </ name > < age > 21 </ age >< interests count="3"><interest> Games</interest><interest>C#</interest><interest> Java</interest></interests></student>
        static void Main(string[] args)
        {

            string leerXML = DevolverInformacionXML();
            string textoSinEtiquetas = DevolverSoloTexto(leerXML);

            Console.WriteLine("Texto Original");
            Console.WriteLine(@"<?xml version=""1.0""><student><name> Peter </name> <age> 21 </age><interests count=""3""><interest> Games </interest><interest> C# </interest><interest> Java </interest></interests></student>"+"\n" + "\n");
            Console.WriteLine("Texto sin etiquetas" + "\n");
            Console.WriteLine(textoSinEtiquetas);

            Console.ReadKey();

        }


        public static string DevolverInformacionXML()
        {
            string informacion = null;

            using(StreamReader miStreamReader = new StreamReader(@".\ArchivoXML.txt"))
            {
                informacion = miStreamReader.ReadToEnd();

            }

            return informacion;

        }

        public static string DevolverSoloTexto(string informacion)
        {
            StringBuilder soloTexto = new StringBuilder();
            string pattern = @"[>\s][\w#]+[<\?\/\s]";
            string input = @"<?xml version=""1.0""><student><name> Peter </name> <age> 21 </age><interests count=""3""><interest> Games </interest><interest> C# </interest><interest> Java </interest></interests></student>";
            RegexOptions options = RegexOptions.Multiline;

            foreach (Match m in Regex.Matches(input, pattern, options))
            {
                soloTexto.Append(m.Value + "\n");

                //Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
             
            }

            return soloTexto.ToString();
        }

    }
}
