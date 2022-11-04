using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Dicionario
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, int> dicionario = new Dictionary<string, int>();
            dicionario.Add("T1", 10);
            dicionario.Add("T2", 20);

            Console.Write(dicionario["T1"]);
        }
    }
}