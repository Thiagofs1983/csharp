using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _ForEach
{
    class Program
    {
        static void Main()
        {
            string[] nomes = { "Thiago", "Heitor", "Barbara", "Thales" };

            Console.WriteLine("------Repetição com For-------");

            for (int i = 0; i < nomes.Length; i += 1)
            {
                if (i == 2)
                {
                    continue;
                }
                Console.WriteLine("Nome: " + nomes[i]);
            }

            Console.WriteLine("------Repetição com ForEach-------");

            foreach (string nome in nomes)
            {
                Console.WriteLine("Nome: " + nome);
            }
        }
    }
}
