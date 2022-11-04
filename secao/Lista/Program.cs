using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Lista
{
    class Program
    {
        static void Main()
        {
            List<string> marcas = new List<string>();
            marcas.Add("Fiat");
            marcas.Add("VW");
            marcas.Add("Renault");
            marcas.Add("Ford");

            foreach(string marca in marcas)
            {
                Console.WriteLine(marca);
            }
        }
    }
}
