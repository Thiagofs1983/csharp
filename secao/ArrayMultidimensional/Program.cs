using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _ArrayMultidimensional
{
    class Program
    {
        static void Main()
        {
            string[,] nomes = new string[2, 4];
            nomes[0, 0] = "Thiago";
            nomes[0, 1] = "Fonseca";
            nomes[0, 2] = "de";
            nomes[0, 3] = "Souza";
            nomes[1, 0] = "Barbara";
            nomes[1, 1] = "Ste";
            nomes[1, 2] = "Ferr";
            nomes[1, 3] = "Souza";

            string[,] marcas = new string[,] { { "Ferrari", "Chevrolet", "Volvo" }, { "Fiat", "VW", "Porche" } };
        }
    }
}