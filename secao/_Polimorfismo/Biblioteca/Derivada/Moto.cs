﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Polimorfismo.Biblioteca.Derivada
{
    internal class Moto : Veiculo
    {
        public override void Mover()
        {
            Console.WriteLine("Moto se movendo!!!");
        }
    }
}
