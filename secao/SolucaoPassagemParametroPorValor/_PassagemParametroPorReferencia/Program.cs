namespace _PassagemParametroPorReferencia
{
    class Program
    {
        static void Main()
        {
            double valor = 25;
            Console.WriteLine("Main > var valor: " + valor);

            AlterarValor(ref valor);
            Console.WriteLine("Main > var valor: " + valor);
        }

        static void AlterarValor(ref double valor)
        {
            Console.WriteLine("AlterarValor > var valor: " + valor);
            valor += 10;
            Console.WriteLine("AlterarValor > var valor: " + valor);
        }
    }
}