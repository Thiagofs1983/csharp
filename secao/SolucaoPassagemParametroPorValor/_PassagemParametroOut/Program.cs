namespace _PassagemParametroOut
{
    class Program
    {
        static void Main()
        {
            double valor = 25;
            Console.WriteLine("Main > var valor: " + valor);

            AlterarValor(out valor);
            Console.WriteLine("Main > var valor: " + valor);
        }

        static void AlterarValor(out double valor)
        {
            valor = 10;
            Console.WriteLine("AlterarValor > var valor: " + valor);
        }
    }
}