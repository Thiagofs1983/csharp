using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _LocalizarTexto
{
    internal class Program
    {
        static void Main()
        {
            string Texto = "Olá amigos, estou muito feliz de estar aqui com vocês. Desejo a todos um feliz ano novo";
            string Palavra = "feliz";

            Console.WriteLine("Tamanho do texto: " + Texto.Length);
            Console.WriteLine("Localizar: " + Texto.IndexOf(Palavra));
            Console.WriteLine("Localizar: " + Texto.LastIndexOf(Palavra));
            Console.WriteLine("Localizar: " + Texto.IndexOf(Palavra, 30));
        }
    }
}