namespace _PassagemParametroParams
{
    class Program
    {
        static void Main()
        {
            VariasEntradas("Thiago", "Heitor", "Barbara");
        }

        static void VariasEntradas(params string[] nomes)
        {
            foreach (string nome in nomes)
            {
                Console.WriteLine(nome);
            }
        }
    }
}