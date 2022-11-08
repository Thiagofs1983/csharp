using _Polimorfismo.Biblioteca;
using _Polimorfismo.Biblioteca.Derivada;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Polimorfismo
{
    internal class Program
    {
        static void Main()
        {
            Carro carro = new Carro();
            Moto moto = new Moto();

            MoverVeiculo(carro);
            MoverVeiculo(moto);
        }

        public static void MoverVeiculo(Veiculo veiculo)
        {
            veiculo.Mover();
        }
    }
}