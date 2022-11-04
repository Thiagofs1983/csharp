using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriacaoClasse.Veiculo
{
    internal class Carro
    {
        private bool LuzesInternas = false;
        private bool Ligado = false;
        private bool FarolLigado = false;

        public void AbrirFecharPorta()
        {
            LuzesInternas = !LuzesInternas;
            if (LuzesInternas)
            {
                Console.WriteLine("Luzes internas Ligadas");
            }
            else
            {
                Console.WriteLine("Luzes internas desligadas");
            }
        }

        private void AcenderFarol()
        {
            FarolLigado = !FarolLigado;
            if (FarolLigado == true)
            {
                Console.WriteLine("Farol ligado");
            }
            else
            {
                Console.WriteLine("Farol desligado");
            }
        }

        public void LigarDesligarCarro()
        {
            Ligado = !Ligado;
            if (Ligado)
            {
                Console.WriteLine("Carro Ligado");
            }
            else
            {
                Console.WriteLine("Carro desligado");
            }
            AcenderFarol();
        }
    }
}
