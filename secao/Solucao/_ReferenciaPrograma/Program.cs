using _Biblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _ReferenciaPrograma
{
    internal class Program
    {
        static void Main()
        {
            CalculoJuros calc = new CalculoJuros();
            double resultado = calc.Soma(10, 20);

            Console.WriteLine(resultado);
        }
    }
}
