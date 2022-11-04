using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _For
{
    class Program
    {
        static void Main()
        {
            string[] nomes = { "Thiago", "Fonseca", "de", "Souza" };
            for (int i = 0; i < nomes.Length ; i += 1)
            {
                Console.Write(nomes[i].ToUpper() + " ");
            }
            Console.WriteLine("---------------------------");

            for (int i = 0; i <= 10; i += 1)
            {
                Console.WriteLine("Linha: " + i);
            }
        }
    }
}
