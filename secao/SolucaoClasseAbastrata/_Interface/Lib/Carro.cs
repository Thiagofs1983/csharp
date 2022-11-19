using _Interface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Interface.Lib
{
    internal class Carro : Veiculo, ITransporte
    {
        public void Mover(byte velocidade)
        {
            Console.WriteLine("Aqui está a ação de mover...");
        }
    }
}
