using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S4E1
{
    internal class Matematica
    {
        public static int Exponenciacao(int Base, int Exp)
        {
            int resultado = 1;
            for (int i = 1; i <= Exp; i += 1)
            {
                resultado *= Base;
            }
            return resultado;  
        }
    }
}
