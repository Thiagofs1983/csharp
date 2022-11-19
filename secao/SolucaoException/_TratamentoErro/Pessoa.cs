using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _TratamentoErro
{
    internal class Pessoa
    {
        private string CEP;

        public void SetCEP(string cep)
        {
            int result;
            if (int.TryParse(cep, out result))
            {
                //Valido
                CEP = cep;
            } else
            {
                throw new Exception("CEP não valido");
            }
        }

        public int getCep()
        {
            return int.Parse(CEP);
        }
    }
}
