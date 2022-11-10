using _ModificadoresDeAcesso.Lib;

namespace _ModificadoresDeAcesso
{
    class Program
    {
        static void Main()
        {
            Veiculo veiculo = new Veiculo();
            Carro carro = new Carro();
            Caminhao caminhao = new Caminhao();

            veiculo.InfoVeiculo();
            carro.Marca = "Fiat";
            caminhao.AnoModelo = new DateTime(01, 01, 2012);
        }
    }
}
