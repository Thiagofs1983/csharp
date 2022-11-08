using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _FormatarTexto
{
    internal class Program
    {
        static void Main()
        {
            string nome = "Thiago";
            string natal = "natal";

            string TextoFormatado = string.Format("Olá {0}! Feliz {1}!!!", nome, natal);

            Console.WriteLine(TextoFormatado);
            Console.WriteLine(TextoFormatado.ToLower());
            Console.WriteLine(TextoFormatado.ToUpper());
        }
    }
}
