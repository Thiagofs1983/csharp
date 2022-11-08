using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Sobrescrita.Biblioteca
{
    internal class Moto : Veiculo
    {
        int Rodas = 2;

        public override void Mover()
        {
            Console.WriteLine("Mover chamado dentro de: Moto.Mover com " + Rodas + " rodas");
            base.Mover();
        }
    }
}