using Heranca.Biblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Heranca
{
    class Program
    {
        static void Main()
        {
            Carro carro = new Carro();
            Moto moto = new Moto();
            Veiculo veiculo = new Veiculo();
            
            carro.AnoFabricação = 2019;
            moto.Modelo = "Honda";
            veiculo.Passageiros = 4;
        }
    }
}
