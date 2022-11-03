using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_variavel
{
    class Program
    {
        static void Main()
        {
            float meuByte = 9.1f; // f para falar que o numero é um float
            string meuByte1 = "3";

            short meuByte3 = short.Parse(meuByte1);

            Console.WriteLine("9 + 3 = " + (meuByte + meuByte3));
        }
    }
}