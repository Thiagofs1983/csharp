using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _conversaoNumTexto
{
    class Program
    {
        static void Main()
        {
            string NumeroTexto = "30";
            int Numero = 30;
            int NumeroConvertido = int.Parse(NumeroTexto);

            Console.WriteLine("30 + 30 = " + (NumeroConvertido + Numero));
            Console.WriteLine(NumeroTexto.GetType() == typeof(string));
        }
    }
}
