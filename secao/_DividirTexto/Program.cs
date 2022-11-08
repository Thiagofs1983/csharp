using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _DividirTexto
{
    internal class Program
    {
        static void Main()
        {
            string nomes = "Thiago, Barbara e Heitor";
            string[] separador = { ", ", " e " };
            string[] listaNomes = nomes.Split(separador, StringSplitOptions.None);
            foreach (string nome in listaNomes)
            {
                Console.WriteLine(nome);
            }
        }
    }
}