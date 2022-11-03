using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _conversaoNumero
{
    class Program
    {
        static void Main()
        {
            short MeuShort = 10;
            int MeuInt = MeuShort;
            long MeuLong = MeuInt;

            long MeuLong2 = 10;
            int MeuInt2 = Convert.ToInt32(MeuLong2);
            short MeuShort2 = Convert.ToInt16(MeuInt2);
        }
    }
}
