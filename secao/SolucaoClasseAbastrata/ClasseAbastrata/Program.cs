using ClasseAbastrata.Lib;

namespace ClasseAbstrata
{
    class Program
    {
        static void Main()
        {
            // Veiculo veiculo = new Veiculo(); Gera um erro, pois a classe veículo é abstrata, portanto não pode ser instanciada

            Carro carro = new Carro();
            carro.Modelo = "Uno";
            carro.AnoFabricacao = 2007;

            Console.WriteLine(carro.Modelo);
            Console.WriteLine(carro.AnoFabricacao);
            Console.WriteLine(carro.Rodas);
        }
    }
}