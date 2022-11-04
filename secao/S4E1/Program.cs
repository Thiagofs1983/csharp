using S4E1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _S4E1
{
    class Program
    {
        static void Main()
        {
            int resultado = Matematica.Exponenciacao(5, 3);

            int resultado1 = Matematica.Exponenciacao(2, 3);

            Console.WriteLine(resultado);
            Console.WriteLine(resultado1);
        }
    }
}
