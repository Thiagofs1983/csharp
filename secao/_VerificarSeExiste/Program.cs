using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _VerificarSeExiste
{
    internal class Program
    {
        static void Main()
        {
            string Texto = "Olá amigos, estou muito feliz de estar aqui com vocês. Desejo a todos um feliz ano novo";
            string Palavra = "feliz";

            Console.WriteLine("Verificar existencia no inicio: " + Texto.StartsWith("Olá"));
            Console.WriteLine("Verificar existencia no final: " + Texto.EndsWith("novo"));
            Console.WriteLine("Verificar existencia: " + Texto.Contains(Palavra));
        }
    }
}
