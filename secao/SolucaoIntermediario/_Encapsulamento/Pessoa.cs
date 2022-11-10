using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Encapsulamento
{
    internal class Pessoa
    {
        private string Nome;
        string CEP;
        string Endereco;
        string CPF;

        public void SetNome(string nome)
        {
            Nome = nome.ToUpper().Trim();
        }

        public string GetNome()
        {
            return Nome;
        }
    }
}
