using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Construtor
{
    internal class Carro
    {
        public string Marca;
        private string Modelo;
        private int Ano;
        public Carro()
        {
            Marca = "Fiat";
            Modelo = "Uno";
            Ano = 2010;
        }

        public Carro(string Marca, string modelo, int ano)
        {
            this.Marca = Marca;
            Modelo = modelo;
            Ano = ano;
        }
    }
}
