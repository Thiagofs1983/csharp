using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _ModificadoresDeAcesso.Lib
{
    public class Veiculo
    {
        public string Marca;
        protected string Modelo;
        private DateTime AnoFabricacao;
        internal DateTime AnoModelo;

        public void InfoVeiculo()
        {
            AnoFabricacao = DateTime.Now;
            Marca = "Fiat";
            Console.WriteLine(Marca);
        }
    }
}
