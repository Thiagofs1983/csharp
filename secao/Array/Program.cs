using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Array
{
    class Program
    {
        static void Main()
        {
            string[] nomes = { "Thiago", "Barbara", "Heitor" };
            Console.WriteLine(nomes[0]);
            nomes[0] = "Fonseca";
            Console.WriteLine(nomes[0]);
        }
    }
}
