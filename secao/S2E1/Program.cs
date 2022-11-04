using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _S2E1
{
    class Program
    {
        static void Main()
        {
            // Desafio é receber o nome e idade e retornar o ano de nascimento do usuário
            Console.WriteLine("Digite seu nome");
            string nome = Console.ReadLine();
            
            Console.WriteLine("Digite sua idade");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Já fez aniversário esse ano?");
            string aniversario = Console.ReadLine();

            Console.WriteLine("----------------------------------------------");

            if (aniversario == "sim")
            {
                int anoNascimento = DateTime.Now.Year - idade;
                Console.WriteLine(nome + " nasceu em: " + anoNascimento);
            } else
            {
                int anoNascimento = DateTime.Now.Year - idade - 1;
                Console.WriteLine(nome + " nasceu em: " + anoNascimento);
            }
        }
    }
}