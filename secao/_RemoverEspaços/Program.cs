using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _RemoverEspacos
{
    internal class Program
    {
        static void Main()
        {
            string Texto = "       Olá amigos          ";
            Console.WriteLine(Texto.TrimStart());
            Console.WriteLine(Texto.TrimEnd());
            Console.WriteLine(Texto.Trim());
        }
    }
}