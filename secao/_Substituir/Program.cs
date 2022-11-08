using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Substituir
{
    internal class Program
    {
        static void Main()
        {
            string Texto = "Olá amigos, estou muito feliz de estar aqui com vocês. Desejo a todos um feliz ano novo";
            string Palavra = "feliz";
            string TextoSubstituido = Texto.Replace(Palavra, "triste");

            Console.WriteLine(Texto);
            Console.WriteLine(TextoSubstituido);
           
        }
    }
}
