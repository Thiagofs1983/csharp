using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _SwitchCase
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Você é casado: 'S' para sim e 'N' para não");
            string valor = Console.ReadLine();

            switch (valor)
            {
                case "S":
                    Console.WriteLine("Parabéns");
                    break;
                case "N":
                    Console.WriteLine("Vem que a água ta quentinha. hahhaha");
                    break;
                default:
                    Console.WriteLine("Comando não reconhecido");
                    break;
            }
        }
    }
}