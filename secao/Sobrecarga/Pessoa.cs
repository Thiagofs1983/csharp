using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga
{
    internal class Pessoa
    {
        public int Andar()
        {
            return 1;
        }

        public int Andar(int lvl) // Pode ter 2 metodos com o mesmo nome se diferenciando pelos parametros
        {
            return Andar() * lvl;
        }

        public int Correr()
        {
            return Andar() * 2;
        }

        public int Pedalar()
        {
            return Correr() * 2;
        }
    }
}
