using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Sobrescrita.Biblioteca
{
    internal class Veiculo
    {
        public string Marca;
        public string Modelo;
        public int Passageiros;
        public int AnoFabricação;

        public void Mover()
        {
            Console.WriteLine("Mover chamado dentro de: Veiculo.Mover");
        }
    }
}
