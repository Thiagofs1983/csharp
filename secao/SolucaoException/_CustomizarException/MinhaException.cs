using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _CustomizarException
{
    internal class MinhaException : Exception
    {
        string LinhaDoErro;
        public MinhaException(string linhaDoErro) : base("Minha exception") // base chama o construtor da classe pai
        {
            LinhaDoErro = linhaDoErro;
        }
    }
}
