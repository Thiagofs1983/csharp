// using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Construtor
{
    internal class Program
    {
        static void Main()
        {
            Carro carro = new Carro();
            Carro carro2 = new Carro("VW", "Gol", 2020);

            Console.WriteLine(carro2.Marca);
            Console.WriteLine(carro.Marca);
        }
    }
}
