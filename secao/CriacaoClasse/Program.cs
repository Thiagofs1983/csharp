using CriacaoClasse.Veiculo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _CriacaoClasse
{
    class Program
    {
        static void Main()
        {
            Carro carro1 = new Carro();
            Carro carro2 = new Carro();
            Moto moto1 = new Moto();
            carro1.LigarDesligarCarro();
            carro1.LigarDesligarCarro();
            Console.WriteLine("----------------------------");
            carro2.AbrirFecharPorta();
            carro2.AbrirFecharPorta();
            carro2.LigarDesligarCarro();
            carro2.LigarDesligarCarro();
            carro2.AbrirFecharPorta();
            carro2.AbrirFecharPorta();
        }
    }
}
